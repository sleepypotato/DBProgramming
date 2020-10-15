using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketBrowser
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private List<List<string>> MakeColumnnarDataStructure()
        {
            StreamReader sr = new StreamReader(new FileStream("market.csv", FileMode.Open), Encoding.Default);
            

            string str = "";

            var line = sr.ReadLine();
            var headers = line.Split(',');
            List<List<string>> data = new List<List<string>>();
            foreach(string header in headers)
            {
                List<string> list = new List<string> ();
                list.Add(header);
                data.Add(list);
            }

            int row = 0;
            while (sr.EndOfStream == false)
            {
                line = sr.ReadLine();
                var values = line.Split(',');
                for (int i = 0; i < values.Length; i++)
                {
                    data[i].Add(values[i]);
                }
                if (row++ == 10)
                    break;
            }
            
            sr.Close();
            return data;
        }

        private void printColumnData(List<List<string>>  columnIdx) {
            List<List<string>> data = MakeColumnnarDataStructure();
            string str = "";
            textBoxCSVViewer.Text = "";
            foreach (string value in columnIdx[1]) {
                str += value + "\r\n";
            }
            textBoxCSVViewer.Text = str;
        }

        private void printRowData(List<List<string>> rowIdx) {
            string str = "";
            for (int row = 0; row < rowIdx[0].Count; row++) {
                foreach (List<string> list in rowIdx) {
                    str += list[row] + "\t";
                }
                str += "\r\n";
            }
            textBoxCSVViewer.Text = str;
        }

        private List<string> parseCSVLine (string line)
        {
            var values = line.Split(',');
            
            List<string> val = new List<string>();

            foreach (string value in values)
            {
                val.Add(value);
            }

            for (int i = 0; i < val.Count; i++)
            {
                if (val[i].Contains('('))
                {
                    for (int j = i; !val[j].Contains(')'); j++)
                    {
                        if(!val[j].Contains(','))
                        {
                            val[i] = val[i] + val[i + 1];
                            val.RemoveAt(i + 1);
                            j--;
                        }
                    }
                }
            }

            if (val[3] != "상설" && val[3] != "5일")
            {
                val[2] = val[2] + val[3];
                val.RemoveAt(3);
            }

            if (val.Count > 12)
            {
                val[4] = val[4] + val[5];
                val.RemoveAt(5);
            }
            return val;
        }
        
        private List<List<string>> MakeRowbasedDataStructure() {
            StreamReader sr = new StreamReader(new FileStream("market.csv", FileMode.Open), Encoding.Default);
            
            var line = sr.ReadLine();

            List<List<string>> data = new List<List<string>>();
            
            while (sr.EndOfStream == false)
            {
                line = sr.ReadLine();
                var values = parseCSVLine(line);
                // "시장(구, 우리시장)" 에서 중간, 없애면 됨

                data.Add(values.ToList());

                // 문제 = if 없애도 돌아가기
            }
            
            sr.Close();
            return data;
        }

        private void printRowData_rowbased(List<List<string>> data) {
            string str = "";
            foreach (List<string> rowlist in data){
                foreach (string value in rowlist)
                    str += value + "\t";
                 str += "\r\n";
            }

            textBoxCSVViewer.Text = str;
        }

        private void printColumnData_rowbased(List<List<string>> data, int colIdx) {

            string str = "";
            foreach(List<string> rowlist in data) {
                str += rowlist[colIdx] + "\r\n";
            }
            textBoxCSVViewer.Text = str;
        }

        private void buttonOpenCSV_Click(object sender, EventArgs e)
        {
            List<List<string>> data = MakeRowbasedDataStructure();
            printRowData_rowbased(data);
            //printColumnData_rowbased(data, 5);

            // List<List<string>> data = MakeColumnnarDataStructure(); 
            // printColumnData(data);
            // printRowData(data);
            
        }
    }
}
