using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSV_Aufgabe
{
    class CSVHandler
    {
        private static string getFirstLine(string fileContent)
        {
            return fileContent.Split(Environment.NewLine.ToCharArray())[0];
        }

        private static int getColumnNum(string firstline)
        {
            return firstline.Split(';').Count();
        }

        public static void fillComboBox(Dictionary<string, string> CSVValues, ComboBox comboBox)
        {
            comboBox.Items.Clear();

            foreach(var item in CSVValues["titleStrings"].Split(';'))
            {
                comboBox.Items.Add(item);
            }

            comboBox.SelectedIndex = 0;
        }

        public static Dictionary<string, string> readCSV(OpenFileDialog openFileDialog)
        {
            Dictionary<string, string> CSVValues = new Dictionary<string, string>();

            CSVValues.Add("filePath", openFileDialog.FileName);

            var fileStream = openFileDialog.OpenFile();
            string fileContent = "";

            using (StreamReader reader = new StreamReader(fileStream))
            {
                fileContent = reader.ReadToEnd();
                CSVValues.Add("fileContent", fileContent);
            }

            string titleStrings = getFirstLine(fileContent);
            CSVValues.Add("titleStrings", titleStrings);
            int columnCounter = getColumnNum(titleStrings);
            CSVValues.Add("columnCounter", columnCounter.ToString());

            return CSVValues;
        }

        public static void showCSV(Dictionary<string, string> CSVValues, DataGridView dataGridView, Form form)
        {
            // Adds Filename to Application Name
            form.Text += " - " + Path.GetFileName(CSVValues["filePath"]);

            // Clears the DataGridView
            dataGridView.Columns.Clear();

            DataTable dt = new DataTable();

            int columnCounter = Int32.Parse(CSVValues["columnCounter"]);
            Dictionary<int, string[]> contentSnippets = getCodeSnippets(CSVValues);
            
            // Adds the Columns to DataTabel
            foreach (string title in contentSnippets[0])
            {
                dt.Columns.Add(title);
            }

            // Adds the Rows to DataTable
            for (int i = 1; i < contentSnippets.Keys.Count(); i++)
            {
                string[] dataSnippets = contentSnippets[i];
                DataRow dataRow = dt.NewRow();
                int columnIndex = 0;

                foreach (string title in contentSnippets[0])
                {
                    dataRow[title] = dataSnippets[columnIndex++];
                }

                dt.Rows.Add(dataRow);
            }

            //Adds DataTable to DataGridView
            if(dt.Rows.Count > 0)
            {
                dataGridView.DataSource = dt;
            }
        }

        private static Dictionary<int, string[]> getCodeSnippets(Dictionary<string, string> CSVValues)
        {
            Dictionary<int, string[]> lineSnippets = new Dictionary<int, string[]>();
            string fileContent = CSVValues["fileContent"];
            int snippetsPerPoint = Int32.Parse(CSVValues["columnCounter"]);
            bool lastSnippet = false;
            bool lastRound = false;
            int index = 0;

            while (!lastRound)
            {
                string[] lineData = new string[snippetsPerPoint];
                int DelemiterIndex = 0;
                for (int i = 0; i < snippetsPerPoint; i++)
                {
                    if(i == (snippetsPerPoint - 1))
                    {
                        string tempSnippet = fileContent.Remove(DelemiterIndex + 1);
                        fileContent = fileContent.Remove(0, DelemiterIndex+1);

                        int indexLineFeed = fileContent.IndexOf("\r\n");
                        int indexLastLineFeed = fileContent.LastIndexOf("\r\n");
                        
                        string tempLastSnippet = fileContent.Remove(indexLineFeed);
                        string snippet = tempSnippet + tempLastSnippet;

                        if (snippet.Contains("\r\n"))
                            snippet = snippet.Replace("\r\n", "");
                        if (snippet.Contains("\n"))
                            snippet = snippet.Replace("\n", "");

                        if(indexLineFeed == indexLastLineFeed)
                            lastSnippet = true;
                        if (lastSnippet)
                            lastRound = true;

                        fileContent = fileContent.Remove(0, indexLineFeed);

                        string[] tempArray = getSnippetArray(snippet, snippetsPerPoint);
                        int itemIndex = 0;
                        foreach(string item in tempArray)
                        {
                            lineData[itemIndex] = item;
                            itemIndex++;
                        }
                    }
                    else
                    {
                        DelemiterIndex = fileContent.IndexOf(';', DelemiterIndex+1);
                    }
                }
                lineSnippets.Add(index, lineData);
                index++;
            }

            return lineSnippets;
        }

        private static string[] getSnippetArray(string snippets, int columnCounter)
        {
            if (snippets == null) return null;
            string[] snippetArray = new string[columnCounter];

            for(int i = 0; i < columnCounter; i++)
            {
                if (snippets.StartsWith("\""))
                {
                    int nextMark = snippets.IndexOf('"', 1);
                    int nextDelemiter = snippets.IndexOf(';', nextMark);

                    snippetArray[i] = snippets.Remove(nextDelemiter);
                    snippets = snippets.Remove(0, nextDelemiter + 1);
                }
                else
                {
                    if(i == (columnCounter - 1))
                    {
                        snippetArray[i] = snippets;
                    }
                    else
                    {
                        int nextDelemiter = snippets.IndexOf(';');
                        snippetArray[i] = snippets.Remove(nextDelemiter);
                        snippets = snippets.Remove(0, nextDelemiter + 1);
                    }
                }
                    
            }

            return snippetArray;
        }
    }
}
