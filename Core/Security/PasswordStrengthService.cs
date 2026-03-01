using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Security
{
    public sealed record PasswordStrengthResult(
        int Length,
        int AlphabetSize,
        double EntropyBits,
        double GuessesPerSecond,
        double CrackTimeSeconds,
        string Label,
        int Score
    );

    public static class PasswordStrengthService
    {
        public static PasswordStrengthResult Evaluate(string password, double guessesPerSecond)
        {
            password ??= "";
            int passLength = password.Length;

            bool hasLower = password.Any(char.IsLower);
            bool hasUpper = password.Any(char.IsUpper);
            bool hasDigit = password.Any(char.IsDigit);
            bool hasSpecial = password.Any(ch => !char.IsLetterOrDigit(ch));

            int N = 0;
            if (hasLower)
            {
                N += 26;
            }

            if (hasUpper)
            {
                N += 26;
            }

            if (hasDigit)
            {
                N += 10;
            }

            if (hasSpecial)
            {
                N += 33;
            }

            if (N == 0 || passLength == 0)
            {
                return new PasswordStrengthResult(0, 0, 0, guessesPerSecond, 0, "много слаба", 0);
            }
                
            double entropy = passLength * Math.Log2(N);

            double crackSeconds = (0.5 * Math.Pow(2, entropy)) / guessesPerSecond;

            var (label, score) = Classify(entropy, passLength, hasLower, hasUpper, hasDigit, hasSpecial);

            return new PasswordStrengthResult(passLength, N, entropy, guessesPerSecond, crackSeconds, label, score);
        }

        private static (string label, int score) Classify(double entropy, int L, bool lower, bool upper, bool digits, bool special)
        {
            int variety = (lower ? 1 : 0) + (upper ? 1 : 0) + (digits ? 1 : 0) + (special ? 1 : 0);

            int score = 0;
            score += Math.Min(40, L * 4);
            score += variety * 10;
            score += (int)Math.Min(40, entropy / 2);

            score = Math.Clamp(score, 0, 100);

            string label =
                score < 30 ? "слаба" :
                score < 60 ? "средна" :
                score < 80 ? "силна" : "много силна";

            return (label, score);
        }

        public static string FormatTime(double seconds)
        {
            if (seconds < 60) return $"{seconds:F1} сек";
            double minutes = seconds / 60;
            if (minutes < 60) return $"{minutes:F1} мин";
            double hours = minutes / 60;
            if (hours < 24) return $"{hours:F1} часа";
            double days = hours / 24;
            if (days < 365) return $"{days:F1} дни";
            double years = days / 365;
            return $"{years:E2} години";
        }
    }
}
