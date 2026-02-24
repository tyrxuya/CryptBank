namespace View.Controls
{
    partial class PerfView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            splitMain = new SplitContainer();
            panelControlsCard = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tlpControls = new TableLayoutPanel();
            lblPassword = new Label();
            progressBar1 = new ProgressBar();
            btnExportCsv = new Button();
            lblSubtitle = new Label();
            lblTitle = new Label();
            textBox1 = new TextBox();
            lblIterations = new Label();
            checkedListBox1 = new CheckedListBox();
            btnRunTest = new Button();
            tlpResults = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            panelControlsCard.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tlpControls.SuspendLayout();
            tlpResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // splitMain
            // 
            splitMain.Dock = DockStyle.Fill;
            splitMain.Location = new Point(0, 0);
            splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.Controls.Add(panelControlsCard);
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.Controls.Add(tlpResults);
            splitMain.Size = new Size(880, 724);
            splitMain.SplitterDistance = 300;
            splitMain.TabIndex = 0;
            // 
            // panelControlsCard
            // 
            panelControlsCard.BackColor = Color.White;
            panelControlsCard.Controls.Add(tableLayoutPanel1);
            panelControlsCard.Dock = DockStyle.Fill;
            panelControlsCard.Location = new Point(0, 0);
            panelControlsCard.Margin = new Padding(12);
            panelControlsCard.Name = "panelControlsCard";
            panelControlsCard.Size = new Size(300, 724);
            panelControlsCard.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tlpControls, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(300, 724);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tlpControls
            // 
            tlpControls.Anchor = AnchorStyles.None;
            tlpControls.AutoSize = true;
            tlpControls.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlpControls.ColumnCount = 1;
            tlpControls.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpControls.Controls.Add(lblPassword, 0, 2);
            tlpControls.Controls.Add(progressBar1, 0, 8);
            tlpControls.Controls.Add(btnExportCsv, 0, 7);
            tlpControls.Controls.Add(lblSubtitle, 0, 1);
            tlpControls.Controls.Add(lblTitle, 0, 0);
            tlpControls.Controls.Add(textBox1, 0, 3);
            tlpControls.Controls.Add(lblIterations, 0, 4);
            tlpControls.Controls.Add(checkedListBox1, 0, 5);
            tlpControls.Controls.Add(btnRunTest, 0, 6);
            tlpControls.Location = new Point(16, 204);
            tlpControls.Name = "tlpControls";
            tlpControls.RowCount = 9;
            tlpControls.RowStyles.Add(new RowStyle());
            tlpControls.RowStyles.Add(new RowStyle());
            tlpControls.RowStyles.Add(new RowStyle());
            tlpControls.RowStyles.Add(new RowStyle());
            tlpControls.RowStyles.Add(new RowStyle());
            tlpControls.RowStyles.Add(new RowStyle());
            tlpControls.RowStyles.Add(new RowStyle());
            tlpControls.RowStyles.Add(new RowStyle());
            tlpControls.RowStyles.Add(new RowStyle());
            tlpControls.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpControls.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpControls.Size = new Size(268, 315);
            tlpControls.TabIndex = 0;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(3, 40);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(97, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password for test";
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Top;
            progressBar1.Location = new Point(3, 294);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(262, 18);
            progressBar1.TabIndex = 8;
            // 
            // btnExportCsv
            // 
            btnExportCsv.Anchor = AnchorStyles.None;
            btnExportCsv.Location = new Point(24, 248);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(220, 40);
            btnExportCsv.TabIndex = 7;
            btnExportCsv.Text = "Export CSV";
            btnExportCsv.UseVisualStyleBackColor = true;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.ForeColor = Color.FromArgb(110, 106, 134);
            lblSubtitle.Location = new Point(3, 25);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(245, 15);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Measure hashing time for different iterations.";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 14F);
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(262, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "PBKDF2 Performance Test";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left;
            textBox1.Location = new Point(3, 58);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 23);
            textBox1.TabIndex = 3;
            // 
            // lblIterations
            // 
            lblIterations.AutoSize = true;
            lblIterations.Location = new Point(3, 84);
            lblIterations.Name = "lblIterations";
            lblIterations.Size = new Size(56, 15);
            lblIterations.TabIndex = 4;
            lblIterations.Text = "Iterations";
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "1000", "10000", "100000", "500000", "1000000" });
            checkedListBox1.Location = new Point(3, 102);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 94);
            checkedListBox1.TabIndex = 5;
            // 
            // btnRunTest
            // 
            btnRunTest.Anchor = AnchorStyles.None;
            btnRunTest.Location = new Point(24, 202);
            btnRunTest.Name = "btnRunTest";
            btnRunTest.Size = new Size(220, 40);
            btnRunTest.TabIndex = 6;
            btnRunTest.Text = "Run test";
            btnRunTest.UseVisualStyleBackColor = true;
            // 
            // tlpResults
            // 
            tlpResults.ColumnCount = 1;
            tlpResults.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpResults.Controls.Add(dataGridView1, 0, 0);
            tlpResults.Controls.Add(formsPlot1, 0, 1);
            tlpResults.Dock = DockStyle.Fill;
            tlpResults.Location = new Point(0, 0);
            tlpResults.Name = "tlpResults";
            tlpResults.RowCount = 2;
            tlpResults.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tlpResults.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tlpResults.Size = new Size(576, 724);
            tlpResults.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(221, 211, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(45, 42, 58);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(230, 223, 255);
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(570, 428);
            dataGridView1.TabIndex = 0;
            // 
            // formsPlot1
            // 
            formsPlot1.BackColor = Color.White;
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Dock = DockStyle.Fill;
            formsPlot1.Location = new Point(3, 437);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(570, 284);
            formsPlot1.TabIndex = 1;
            // 
            // PerfView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(246, 243, 255);
            Controls.Add(splitMain);
            Name = "PerfView";
            Size = new Size(880, 724);
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            panelControlsCard.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tlpControls.ResumeLayout(false);
            tlpControls.PerformLayout();
            tlpResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitMain;
        private Panel panelControlsCard;
        private TableLayoutPanel tlpControls;
        private Button btnExportCsv;
        private Label lblPassword;
        private Label lblSubtitle;
        private Label lblTitle;
        private TextBox textBox1;
        private Label lblIterations;
        private CheckedListBox checkedListBox1;
        private Button btnRunTest;
        private ProgressBar progressBar1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tlpResults;
        private DataGridView dataGridView1;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
    }
}
