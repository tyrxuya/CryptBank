using Core.Perf;
using CsvHelper;
using CsvHelper.Configuration;
using ScottPlot.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace View.Controls
{
    public partial class PerfView : UserControl
    {
        private readonly DataTable table = new DataTable();

        private sealed record PerfCsvRow(int iterations_c, double T_ms, double Hps);

        public PerfView()
        {
            InitializeComponent();

            table.Columns.Add("iterations_c", typeof(int));
            table.Columns.Add("T_ms", typeof(double));
            table.Columns.Add("Hps", typeof(double));
            dataGridView1.DataSource = table;

            btnRunTest.Click += (_, __) => RunTest();
            btnExportCsv.Click += (_, __) => ExportCsv();
        }

        private void RunTest()
        {
            string password = string.IsNullOrWhiteSpace(textBox1.Text) ? "TestPassword123!" : textBox1.Text;

            table.Rows.Clear();

            var iterations = checkedListBox1.CheckedItems
                .Cast<object>()
                .Select(x => Convert.ToInt32(x))
                .ToList();

            progressBar1.Value = 0;
            progressBar1.Maximum = Math.Max(1, iterations.Count);

            foreach (var it in iterations)
            {
                var row = Pbkdf2PerfService.MeasureOnce(password, it);
                table.Rows.Add(row.Iterations, Math.Round(row.T_ms, 3), Math.Round(row.Hps, 3));

                progressBar1.Value = Math.Min(progressBar1.Maximum, progressBar1.Value + 1);
                Application.DoEvents();
            }

            RenderPlot();
        }

        private void ExportCsv()
        {
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Няма данни за експорт. Пусни тест първо.");
                return;
            }

            using var sfd = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                FileName = "pbkdf2_performance.csv"
            };

            if (sfd.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ",",
                HasHeaderRecord = true,
                NewLine = Environment.NewLine,
            };

            var rows = table.Rows
                .Cast<DataRow>()
                .Select(r => new PerfCsvRow(
                    iterations_c: Convert.ToInt32(r["iterations_c"]),
                    T_ms: Convert.ToDouble(r["T_ms"], CultureInfo.InvariantCulture),
                    Hps: Convert.ToDouble(r["Hps"], CultureInfo.InvariantCulture)
                ))
                .ToList();

            using var writer = new StreamWriter(sfd.FileName, false, Encoding.UTF8);
            using var csv = new CsvWriter(writer, config);

            csv.WriteRecords(rows);

            MessageBox.Show("Файлът е успешно записан!");
        }

        private void RenderPlot()
        {
            formsPlot1.Plot.Clear();

            if (dataGridView1.Rows.Count == 0 || dataGridView1.Rows[0].IsNewRow)
            {
                formsPlot1.Plot.Title("PBKDF2 Performance");
                formsPlot1.Plot.Add.Text("Run test to see results", 0, 0);
                formsPlot1.Refresh();
                return;
            }

            var xs = new List<double>();
            var tms = new List<double>();
            var hps = new List<double>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells["iterations_c"].Value is null) continue;

                double it = Convert.ToDouble(row.Cells["iterations_c"].Value);
                double t = Convert.ToDouble(row.Cells["T_ms"].Value);
                double h = Convert.ToDouble(row.Cells["Hps"].Value);

                xs.Add(it);
                tms.Add(t);
                hps.Add(h);
            }

            if (xs.Count == 0)
            {
                formsPlot1.Refresh();
                return;
            }

            // Series: време (ms)
            var s1 = formsPlot1.Plot.Add.Scatter(xs.ToArray(), tms.ToArray());
            s1.Label = "T_ms";

            // Series: H/s
            var s2 = formsPlot1.Plot.Add.Scatter(xs.ToArray(), hps.ToArray());
            s2.Label = "Hps";

            formsPlot1.Plot.Title("PBKDF2 Performance");
            formsPlot1.Plot.XLabel("iterations_c");
            formsPlot1.Plot.YLabel("value");

            formsPlot1.Plot.ShowLegend();

            formsPlot1.Plot.Axes.AutoScale();
            formsPlot1.Refresh();
        }
    }
}
