using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace FinanLanGen
{
    public partial class Form1 : Form
    {

        DataTable dtMine = new DataTable();
        JsonHelper jsonHelper = new JsonHelper();

        public Form1()
        {
            InitializeComponent();

        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {
             WriteResx("Text");
        }

        private void WriteResx(string destination)
        {
           string sourceDir = "D:\\Project\\DEV\\star2\\src\\AgileBet.Cash.Portal.WebSite\\App_GlobalResources\\";
            var fileEntries =  Directory.GetFiles(sourceDir).Where(s=>s.StartsWith(destination)).ToList();
            bool firstTime = true; 

            for (int i = 0; i < fileEntries.Count; i++)
            {
                var path = fileEntries[i];
                string content = File.ReadAllText(path);
                int start = content.IndexOf("</root>");
                string appendData = "";
                foreach (DataRow row in dtMine.Rows)
                {
                    appendData += ResxHelper.ToXml(row["key"].ToString(),row[i+2].ToString() , row["comment"].ToString());
                }
                content = content.Insert(start, appendData);
                richTextBox1.Text = content;
                if (i==0)
                {
                    if (MessageBox.Show("Is it alright?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                         File.WriteAllText(path, content);    
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                     File.WriteAllText(path, content);    
                }
            }
            System.Diagnostics.Process.Start(sourceDir);
        }

        private void btnSelectExcel_Click(object sender, EventArgs e)
        {

            var fileName = FileHelper.OpenFile();
            if (fileName != string.Empty)
            {
                string tableName = "[Sheet1$]"; //在頁簽名稱後加$，再用中括號[]包起來
                string sql = textBox1.Text + " " + tableName; //SQL查詢
                dtMine = ExcelHelper.GetExcelDataTable(fileName, sql);
                //dtMine.Columns.Add("Comment");
                dataGridView1.DataSource = dtMine;
                //DataCount_BeChanged.Text = "DataCount : " + DataCount(dataGridView1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sourceDir = "D:\\Project\\DEV\\star2\\src\\AgileBet.Cash.Portal.WebSite\\Public\\JS\\Language\\Financials\\";
            string[] fileEntries = Directory.GetFiles(sourceDir);
            for (int i = 0; i < fileEntries.Length; i++)
            {
                string fullPath = fileEntries[i];
                string content = File.ReadAllText(fullPath);
                int start = content.IndexOf('{') + 1;
                content = content.Insert(start, jsonHelper.ToLanJSON(dtMine, i + 1));
                //fullPath= fullPath.Replace(sourceDir, "D:\\test\\");
                File.WriteAllText(fullPath, content);

            }
            System.Diagnostics.Process.Start(sourceDir);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //string sourceDir = "D:\\Project\\DEV\\star2\\src\\AgileBet.Cash.Portal.WebSite\\Public\\JS\\Language\\Financials\\";
            //System.Diagnostics.Process.Start(sourceDir);
        }

        private void BtnWrite2Message_Click(object sender, EventArgs e)
        {
            WriteResx("Message");
        }
    }
}
