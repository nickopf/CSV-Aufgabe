using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CSV_Aufgabe
{
    public partial class Form1 : Form
    {
        bool fileLoaded = false;

        Dictionary<string, string> CSVValues;

        List<double> xValues = new List<double>();
        List<double> yValues = new List<double>();

        BackgroundWorker worker = new BackgroundWorker();

        public Form1()
        {
            InitializeComponent();

            xValues.Add(0);
            yValues.Add(1);

            xValues.Add(1);
            yValues.Add(3);

            xValues.Add(10);
            yValues.Add(3.5);

            // Edits the Closing Event
            this.FormClosing += Form1_FormClosing;
        }

        #region File Menu Strip
        private void FileMenuStripItemOpen_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "CSV Dateien (*.csv)|*.csv|Alle Dateien (*.*)|*.*";
            openFileDialog.RestoreDirectory = true;

            openFileDialog.ShowDialog();
        }

        private void FileMenuStripItemSave_Click(object sender, EventArgs e)
        {
            if (fileLoaded)
                SaveHandler.SaveCSV(dataGridView1, CSVValues["filePath"]);
            else
                MessageBox.Show("Es ist keine Datei geladen, die gespeichert werden könnte.", "CSV-Aufgabe", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FileMenuStripItemSaveAs_Click(object sender, EventArgs e)
        {
            if (fileLoaded)
                SaveHandler.SaveAsCSV(dataGridView1, saveFileDialog, CSVValues["filePath"]);
            else
                MessageBox.Show("Es ist keine Datei geladen, die gespeichert werden könnte.", "CSV-Aufgabe", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region Diagram Menu Strip
        private void DiagramMenuStripItemBar_Click(object sender, EventArgs e)
        {
            if (chartPanel.Series["Series1"].ChartType != SeriesChartType.Column)
                chartPanel.Series["Series1"].ChartType = SeriesChartType.Column;
        }

        private void DiagramMenuStripItemPie_Click(object sender, EventArgs e)
        {
            if (chartPanel.Series["Series1"].ChartType != SeriesChartType.Pie)
                chartPanel.Series["Series1"].ChartType = SeriesChartType.Pie;
        }

        private void DiagramMenuStripItemDoughnut_Click(object sender, EventArgs e)
        {
            if (chartPanel.Series["Series1"].ChartType != SeriesChartType.Doughnut)
                chartPanel.Series["Series1"].ChartType = SeriesChartType.Doughnut;
        }
        #endregion

        #region Dialogs
        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            loadBar.Visible = true;
            loadBar.Style = ProgressBarStyle.Marquee;
            Thread loadCSVThread = new Thread(new ThreadStart(ThreadLoadCSV));
            loadCSVThread.Start();

            loadBar.BeginInvoke(new ThreadStart(ThreadShowCSV));

            fileLoaded = true;
        }
        #endregion

        #region Threads
        private void ThreadLoadCSV()
        {
            CSVValues = CSVHandler.readCSV(openFileDialog);
        }
        private void ThreadShowCSV()
        {
            CSVHandler.fillComboBox(CSVValues, comboBoxChart);

            CSVHandler.showCSV(CSVValues, dataGridView1, this);

            MessageBox.Show($"Datei {Path.GetFileName(CSVValues["filePath"])} wurde erfolgreich geladen.", "CSV-Aufgabe", MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadBar.Visible = false;
        }
        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if(e.CloseReason == CloseReason.UserClosing)
            {
                if (fileLoaded && this.Text.EndsWith("*"))
                {
                    e.Cancel = true;
                    var result = MessageBox.Show("Sollen die Änderungen wirklich gespeichert werden?", "CSV-Aufgabe", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        SaveHandler.SaveCSV(dataGridView1, Path.GetFileName(CSVValues["filePath"]));
                        Application.Exit();
                    }
                    else if (result == DialogResult.No)
                    {
                        Application.Exit();
                    }
                }
                else
                    Application.Exit();
            }
        }
    }
}
