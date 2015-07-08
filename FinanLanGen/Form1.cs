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

        private void consoleLog(string log)
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

        private void preiviewText()
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

                foreach (DataRow row in dtMine.Rows)
                {
                    if (row["Key"].ToString() != string.Empty)
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
            preiviewText();
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
                string tableName = "[Sheet1$]"; //在頁簽名稱後加$，再用中括號[]包起來
                string sql = txt_JSSQL.Text + " " + tableName; //SQL查詢
                _dtJsDataTable = ExcelHelper.GetExcelDataTable(fileName, sql);
                //dtMine.Columns.Add("Comment");
                JSdataGridView.DataSource = _dtJsDataTable;
                //DataCount_BeChanged.Text = "DataCount : " + DataCount(dataGridView1);
            }
        }

        private void btn_JSReadWrite_Click(object sender, EventArgs e)
        {
            var variableName = "";
            var directory = new DirectoryInfo(txt_selectJsFolder.Text);
            var fileEntries = directory.GetFiles().Where(f => f.Extension == ".js").ToList();
            //            string[] fileEntries = Directory.GetFiles(txt_selectJsFolder.Text);
            var isCreateNew = MessageBox.Show("Do you want to create new file?", "Question", MessageBoxButtons.YesNo)==DialogResult.Yes;
            foreach (FileInfo fileinfo in fileEntries)
            {
                string fullPath = fileinfo.FullName;// fileEntries[i];
                string content = isCreateNew? "": File.ReadAllText(fullPath);//File.ReadAllText(fullPath);
                int start = content.IndexOf('{') + 1;
                foreach (DataColumn column in _dtJsDataTable.Columns)
                {
                    //得到Excel column對應的檔案名(e.g. en-gb), 如果此檔名和現在的fileInfo檔名相同，就使用該column當Value
                    if (fileinfo.Name.Contains(LanguageMappingHelper.GetMappingFilename(column.ColumnName)))
                    {
                        if (isCreateNew)//代表檔案是空的
                        {
                            if (variableName == "")
                            {
                                variableName = Microsoft.VisualBasic.Interaction.InputBox("Question?", "Please type a variable you want to use in js file", "languageJS");
                            }
                            content = string.Format("var {0} = {{{1}}}", variableName, jsonHelper.ToJsonByColumnName(_dtJsDataTable, column.ColumnName).TrimEnd(','));

                        }
                        else
                        {
                            content = content.Insert(start,
                                jsonHelper.ToJsonByColumnName(_dtJsDataTable, column.ColumnName));
                        }
                        break;
                    }
                }

                File.WriteAllText(fullPath, content);

            }
            System.Diagnostics.Process.Start(txt_selectJsFolder.Text);
        }

        private void TargetJSFolder_Click(object sender, EventArgs e)
        {
            var temp = FileHelper.OpenFolder();
            if (temp != string.Empty)
            {
                txt_selectJsFolder.Text = temp;
            }

        }


    }
}
