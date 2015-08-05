using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace FinanLanGen
{
    public partial class Form1 : Form
    {


        DataTable dtMine = new DataTable();
        JsonHelper jsonHelper = new JsonHelper();
        DataTable _dtJsDataTable = new DataTable();

     

        public Form1()
        {
            InitializeComponent();
            txtSelectFolder.Text = "D:\\Project\\DEV\\star2\\src\\AgileBet.Cash.Portal.WebSite\\App_GlobalResources\\";
        }

        private void ConsoleLog(string log)
        {
            richTextBox2.Text += log;
            richTextBox2.Text += Environment.NewLine;
        }

        
        #region resxGen
        private void btn_SelectResxFolder_Click(object sender, EventArgs e)
        {
            txtSelectFolder.Text = FileHelper.OpenFolder();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            WriteResx("Text");
        }

        private void PreiviewText()
        {
            if (!Directory.Exists(txtSelectFolder.Text))
            {
                txtSelectFolder.Text = folderBrowserDialog1.SelectedPath;
            }

            var directory = new DirectoryInfo(txtSelectFolder.Text);
            var fileEntries = directory.GetFiles().Where(f => f.Name.Contains("Text") && f.Name.EndsWith("resx")).OrderBy(f => f.Name).ToList();
            richTextBox1.Text += "This take first two for example, call \"write to message\" will write these to Message.xxxx" + Environment.NewLine;
            var previewLine = dtMine.Rows.Count >= 2 ? 2 : 1;
            for (int i = 0; i < fileEntries.Count; i++)
            {
                var path = fileEntries[i].FullName;
                string appendData = "============= " + fileEntries[i].Name + " =============" + Environment.NewLine;
                for (int j = 0; j < previewLine; j++)
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
            if (!Directory.Exists(txtSelectFolder.Text))
            {
                txtSelectFolder.Text = folderBrowserDialog1.SelectedPath;
            }

            var directory = new DirectoryInfo(txtSelectFolder.Text);
            var fileEntries = directory.GetFiles().Where(f => f.Name.Contains(destination) && f.Name.EndsWith("resx")).OrderBy(f => f.Name).ToList();

            for (int i = 0; i < fileEntries.Count; i++)
            {
                var path = fileEntries[i].FullName;
                string content = File.ReadAllText(path);
                int start = content.IndexOf("</root>");
                string appendData = "";
                //                foreach (DataColumn dataColumn in dtMine.Columns)
                //                {
                //                    if (fileEntries[i].Name.Contains(LanguageMappingHelper.GetMappingFilename(dataColumn.ColumnName)))
                //                    {
                //                        
                //                    }
                //                }

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {
                        if (row.Cells["Key"].Value != string.Empty)
                        {
                            appendData += ResxHelper.ToXml(row.Cells["Key"].Value.ToString(), row.Cells[i + 2].Value.ToString(), row.Cells["Comment"].Value.ToString());
                        }
                    }
                }
                else
                {
                    foreach (DataRow row in dtMine.Rows)
                    {
                        if (row["Key"].ToString() != string.Empty)
                        {
                            appendData += ResxHelper.ToXml(row["Key"].ToString(), row[i + 2].ToString(), row["Comment"].ToString());
                        }
                    }
                }

                content = content.Insert(start, appendData);
                richTextBox1.Text = appendData;
                try
                {
                    File.WriteAllText(path, content);

                    ConsoleLog("Success write " + fileEntries[i].Name);
                }
                catch (Exception)
                {
                    ConsoleLog("Fail in" + fileEntries[i].Name);
                }
            }
            System.Diagnostics.Process.Start(txtSelectFolder.Text);
        }

        private void btnSelectExcel_Click(object sender, EventArgs e)
        {

            var fileName = FileHelper.OpenFile();
            if (fileName != string.Empty)
            {
                string tableName = "[Sheet1$]"; //在頁簽名稱後加$，再用中括號[]包起來
                string inputsql = textBox1.Text == "" ? "select * from " : textBox1.Text;
                string sql = inputsql + " " + tableName; //SQL查詢
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
            PreiviewText();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            string dir = FileHelper.OpenFolder();
            if (dir != string.Empty)
            {
                txtSelectFolder.Text = dir;
            }
        }
        #endregion

        private void btn_JSImportExcel_Click(object sender, EventArgs e)
        {
            var fileName = FileHelper.OpenFile();
            if (fileName != string.Empty)
            {
                _dtJsDataTable = ExcelHelper.ImportExcel(txt_JSSQL.Text, fileName);
                JSdataGridView.DataSource = _dtJsDataTable;
            }
        }
        private void btn_JSReadWrite_Click(object sender, EventArgs e)
        {
            jsonHelper.WriteToJs(JsonHelper.JsFormat.Esports, txt_selectJsFolder.Text, _dtJsDataTable);
        }

        private void TargetJSFolder_Click(object sender, EventArgs e)
        {
            var temp = FileHelper.OpenFolder();
            if (temp != string.Empty)
            {
                txt_selectJsFolder.Text = temp;
            }

        }

        private void button_WriteToi18n_Click(object sender, EventArgs e)
        {
            jsonHelper.WriteToJs(JsonHelper.JsFormat.I18N, txt_selectJsFolder.Text, _dtJsDataTable);
        }
    }
}
