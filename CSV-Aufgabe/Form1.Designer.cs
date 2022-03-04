
namespace CSV_Aufgabe
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, "30,0");
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4D, 40D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 25D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chartPanel = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuStripItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuStripSeperator = new System.Windows.Forms.ToolStripSeparator();
            this.FileMenuStripItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuStripItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.DiagramMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.DiagramMenuStripItemBar = new System.Windows.Forms.ToolStripMenuItem();
            this.DiagramMenuStripItemPie = new System.Windows.Forms.ToolStripMenuItem();
            this.DiagramMenuStripItemDoughnut = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxChart = new System.Windows.Forms.ComboBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.loadBar = new System.Windows.Forms.ProgressBar();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chartPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartPanel
            // 
            this.chartPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartPanel.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPanel.Legends.Add(legend1);
            this.chartPanel.Location = new System.Drawing.Point(701, 55);
            this.chartPanel.Name = "chartPanel";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            dataPoint1.LegendText = "Nakedshirt";
            dataPoint2.LegendText = "Jassz";
            dataPoint3.LegendText = "Anvil";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.YValuesPerPoint = 2;
            this.chartPanel.Series.Add(series1);
            this.chartPanel.Size = new System.Drawing.Size(300, 300);
            this.chartPanel.TabIndex = 0;
            this.chartPanel.Text = "chartPanel";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(683, 327);
            this.dataGridView1.TabIndex = 1;
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuStrip,
            this.DiagramMenuStrip});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1013, 24);
            this.MenuStrip.TabIndex = 2;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // FileMenuStrip
            // 
            this.FileMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuStripItemOpen,
            this.FileMenuStripSeperator,
            this.FileMenuStripItemSave,
            this.FileMenuStripItemSaveAs});
            this.FileMenuStrip.Name = "FileMenuStrip";
            this.FileMenuStrip.Size = new System.Drawing.Size(46, 20);
            this.FileMenuStrip.Text = "Datei";
            // 
            // FileMenuStripItemOpen
            // 
            this.FileMenuStripItemOpen.Name = "FileMenuStripItemOpen";
            this.FileMenuStripItemOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.FileMenuStripItemOpen.Size = new System.Drawing.Size(291, 22);
            this.FileMenuStripItemOpen.Text = "Öffnen";
            this.FileMenuStripItemOpen.Click += new System.EventHandler(this.FileMenuStripItemOpen_Click);
            // 
            // FileMenuStripSeperator
            // 
            this.FileMenuStripSeperator.Name = "FileMenuStripSeperator";
            this.FileMenuStripSeperator.Size = new System.Drawing.Size(288, 6);
            // 
            // FileMenuStripItemSave
            // 
            this.FileMenuStripItemSave.Name = "FileMenuStripItemSave";
            this.FileMenuStripItemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.FileMenuStripItemSave.Size = new System.Drawing.Size(291, 22);
            this.FileMenuStripItemSave.Text = "Speichern";
            this.FileMenuStripItemSave.Click += new System.EventHandler(this.FileMenuStripItemSave_Click);
            // 
            // FileMenuStripItemSaveAs
            // 
            this.FileMenuStripItemSaveAs.Name = "FileMenuStripItemSaveAs";
            this.FileMenuStripItemSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.FileMenuStripItemSaveAs.Size = new System.Drawing.Size(291, 22);
            this.FileMenuStripItemSaveAs.Text = "Speichern unter...";
            this.FileMenuStripItemSaveAs.Click += new System.EventHandler(this.FileMenuStripItemSaveAs_Click);
            // 
            // DiagramMenuStrip
            // 
            this.DiagramMenuStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DiagramMenuStripItemBar,
            this.DiagramMenuStripItemPie,
            this.DiagramMenuStripItemDoughnut});
            this.DiagramMenuStrip.Name = "DiagramMenuStrip";
            this.DiagramMenuStrip.Size = new System.Drawing.Size(64, 20);
            this.DiagramMenuStrip.Text = "Diagram";
            // 
            // DiagramMenuStripItemBar
            // 
            this.DiagramMenuStripItemBar.Name = "DiagramMenuStripItemBar";
            this.DiagramMenuStripItemBar.Size = new System.Drawing.Size(162, 22);
            this.DiagramMenuStripItemBar.Text = "Balken Diagram";
            this.DiagramMenuStripItemBar.Click += new System.EventHandler(this.DiagramMenuStripItemBar_Click);
            // 
            // DiagramMenuStripItemPie
            // 
            this.DiagramMenuStripItemPie.Name = "DiagramMenuStripItemPie";
            this.DiagramMenuStripItemPie.Size = new System.Drawing.Size(162, 22);
            this.DiagramMenuStripItemPie.Text = "Kuchen Diagram";
            this.DiagramMenuStripItemPie.Click += new System.EventHandler(this.DiagramMenuStripItemPie_Click);
            // 
            // DiagramMenuStripItemDoughnut
            // 
            this.DiagramMenuStripItemDoughnut.Name = "DiagramMenuStripItemDoughnut";
            this.DiagramMenuStripItemDoughnut.Size = new System.Drawing.Size(162, 22);
            this.DiagramMenuStripItemDoughnut.Text = "Donut Diagram";
            this.DiagramMenuStripItemDoughnut.Click += new System.EventHandler(this.DiagramMenuStripItemDoughnut_Click);
            // 
            // comboBoxChart
            // 
            this.comboBoxChart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxChart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChart.FormattingEnabled = true;
            this.comboBoxChart.Location = new System.Drawing.Point(701, 28);
            this.comboBoxChart.Name = "comboBoxChart";
            this.comboBoxChart.Size = new System.Drawing.Size(300, 21);
            this.comboBoxChart.TabIndex = 3;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // loadBar
            // 
            this.loadBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.loadBar.Location = new System.Drawing.Point(12, 359);
            this.loadBar.Name = "loadBar";
            this.loadBar.Size = new System.Drawing.Size(141, 14);
            this.loadBar.Step = 1;
            this.loadBar.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 377);
            this.Controls.Add(this.loadBar);
            this.Controls.Add(this.comboBoxChart);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chartPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MinimumSize = new System.Drawing.Size(1029, 416);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSV-Aufgabe";
            ((System.ComponentModel.ISupportInitialize)(this.chartPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileMenuStripItemOpen;
        private System.Windows.Forms.ToolStripSeparator FileMenuStripSeperator;
        private System.Windows.Forms.ToolStripMenuItem FileMenuStripItemSave;
        private System.Windows.Forms.ToolStripMenuItem FileMenuStripItemSaveAs;
        private System.Windows.Forms.ToolStripMenuItem DiagramMenuStrip;
        private System.Windows.Forms.ComboBox comboBoxChart;
        private System.Windows.Forms.ToolStripMenuItem DiagramMenuStripItemBar;
        private System.Windows.Forms.ToolStripMenuItem DiagramMenuStripItemPie;
        private System.Windows.Forms.ToolStripMenuItem DiagramMenuStripItemDoughnut;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ProgressBar loadBar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}

