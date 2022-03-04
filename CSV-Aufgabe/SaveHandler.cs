using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSV_Aufgabe
{
    class SaveHandler
    {
        public static void SaveAsCSV(DataGridView dataGridView, SaveFileDialog saveFileDialog, string filePath)
        {
            saveFileDialog.Filter = "CSV Dateien (*.csv)|*.csv";
            saveFileDialog.FileName = Path.GetFileName(filePath);
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.ShowDialog();

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                SaveCSV(dataGridView, saveFileDialog.FileName);
            }
        }

        public static void SaveCSV(DataGridView dataGridView, string filePath)
        {
            if (filePath == null) return;

            if (dataGridView.Rows.Count > 0)
            {
                try
                {
                    var sb = new StringBuilder();

                    var headers = dataGridView.Columns.Cast<DataGridViewColumn>();
                    Dictionary<int, string> fullData = new Dictionary<int, string>();
                    string titleStrings = string.Join(";", headers.Select(column => $"{column.HeaderText}").ToArray());
                    fullData.Add(0, titleStrings);

                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        var cells = row.Cells.Cast<DataGridViewCell>();
                        string rowString = string.Join(";", cells.Select(cell => $"{cell.Value}").ToArray());
                        fullData.Add(row.Index + 1, rowString);
                    }

                    string[] dataArray = new string[fullData.Keys.Count + 1];
                    foreach (int line in fullData.Keys)
                    {
                        dataArray[line] = fullData[line];
                    }

                    if (File.Exists(filePath))
                        File.WriteAllText(filePath, string.Empty);

                    File.WriteAllLines(filePath, dataArray, Encoding.UTF8);
                    MessageBox.Show("Datei erfolgreich gespeichert!", "CSV-Aufgabe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Fehler: " + e.Message, "CSV-Aufgabe - Speichern fehlgeschlagen! (2)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Es wurde keine Inhalte gefunden!", "CSV-Aufgabe", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
