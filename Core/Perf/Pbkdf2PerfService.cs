using Core.Security;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Core.Perf
{
    public sealed record Pbkdf2PerfRow(int Iterations, double T_ms, double Hps);

    public static class Pbkdf2PerfService
    {
        public static Pbkdf2PerfRow MeasureOnce(string password, int iterations)
        {
            var sw = Stopwatch.StartNew();
            _ = PasswordHashService.HashPassword(password, iterations);
            sw.Stop();

            double tMs = sw.Elapsed.TotalMilliseconds;
            double hps = tMs <= 0 ? 0 : 1000.0 / tMs;

            return new Pbkdf2PerfRow(iterations, tMs, hps);
        }
    }
}
