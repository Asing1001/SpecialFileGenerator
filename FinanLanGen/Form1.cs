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

        private void consoleLog(string log)
        {
            richTextBox2.Text += log;
            richTextBox2.Text += Environment.NewLine;
        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {
             WriteResx("Text");
        }

        private void preiviewText()
        {
            string sourceDir = "D:\\Project\\DEV\\star2\\src\\AgileBet.Cash.Portal.WebSite\\App_GlobalResources\\";
            if (!Directory.Exists(sourceDir))
            {
                sourceDir = folderBrowserDialog1.SelectedPath;  
            }

            var directory = new DirectoryInfo(sourceDir);
            var fileEntries = directory.GetFiles().Where(f=>f.Name.Contains("Text") && f.Name.EndsWith("resx")).OrderBy(f=>f.Name).ToList();
            richTextBox1.Text+="This take first two for example, call \"write to message\" will write these to Message.xxxx"+Environment.NewLine;
            for (int i = 0; i < fileEntries.Count; i++)
            {
                var path = fileEntries[i].FullName;
                string appendData = "============= " + fileEntries[i].Name + " ============="+Environment.NewLine;
                for (int j = 0; j < 2; j++)
                {
                    var row = dtMine.Rows[j];
                    if (row["Key"].ToString() != string.Empty)
                    {
                        appendData += ResxHelper.ToXml(row["Key"].ToString(), row[i + 2].ToString(),
                            row["Comment"].ToString());
                    }
                }
                
                richTextBox1.Text += appendData;
            }
            
        }

        private void WriteResx(string destination)
        {
            string sourceDir = "D:\\Project\\DEV\\star2\\src\\AgileBet.Cash.Portal.WebSite\\App_GlobalResources\\";
            if (!Directory.Exists(sourceDir))
            {
                sourceDir = folderBrowserDialog1.SelectedPath;  
            }

            var directory = new DirectoryInfo(sourceDir);
            var fileEntries = directory.GetFiles().Where(f=>f.Name.Contains(destination) && f.Name.EndsWith("resx")).OrderBy(f=>f.Name).ToList();
            
            for (int i = 0; i < fileEntries.Count; i++)
            {
                var path = fileEntries[i].FullName;
                string content = File.ReadAllText(path);
                int start = content.IndexOf("</root>");
                string appendData = "";
                foreach (DataRow row in dtMine.Rows)
                {
                    if (row["Key"].ToString()!=string.Empty)
                    {
                        appendData += ResxHelper.ToXml(row["Key"].ToString(), row[i + 2].ToString(), row["Comment"].ToString());
                    }
                }
                content = content.Insert(start, appendData);
                richTextBox1.Text = appendData;
                try
                {
                    File.WriteAllText(path, content);
                  
                    consoleLog("Success write " + fileEntries[i].Name);
                }
                catch (Exception)
                {
                    consoleLog("Fail in" + fileEntries[i].Name);
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
                dataGridView1.DataSource = dtMine;
                
            }

        }

        private void BtnWrite2Message_Click(object sender, EventArgs e)
        {
            WriteResx("Message");
        }

        private void PreviewText_Click(object sender, EventArgs e)
        {
            preiviewText();
        }
    }
}
