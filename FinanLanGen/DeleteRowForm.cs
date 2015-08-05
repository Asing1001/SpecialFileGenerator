using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace FinanLanGen
{
    public partial class DeleteRowForm : Form
    {
        public DeleteRowForm()
        {
            InitializeComponent();
        }
        DataTable dtMine = new DataTable();
        List<string> deleteList = new List<string>();
        private DataTable finalDataTable;
        JsonHelper jsonHelper = new JsonHelper();
        private void button1_Click(object sender, EventArgs e)
        {
            var fileName = FileHelper.OpenFile();
            if (fileName != string.Empty)
            {
                dtMine = ExcelHelper.ImportExcel(textBox1.Text, fileName);
                priviewDataGridView.DataSource = dtMine;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dataSource = new DataTable();
            
            var fileName = FileHelper.OpenFile();
            if (fileName != string.Empty)
            {
                string tableName = "[Sheet1$]"; //在頁簽名稱後加$，再用中括號[]包起來
                string inputsql = "select * from ";
                string sql = inputsql + " " + tableName; //SQL查詢
                dataSource = ExcelHelper.GetExcelDataTable(fileName, sql);
                foreach (DataRow dataRow in dataSource.Rows)
                {
                    deleteList.Add(dataRow[0].ToString());    
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            finalDataTable = dtMine.Clone();

            foreach (DataRow dtRow in dtMine.Rows)
            {
                if (!isInDeleteList(dtRow[0].ToString()))
                {
                    finalDataTable.Rows.Add(dtRow.ItemArray);
                }
            }

            dataGridView1.DataSource = finalDataTable;
        }

        private bool isInDeleteList(string s)
        {
            bool result = false;
            foreach (string ds in deleteList)
            {
                if (ds.TrimStart('_') == s)
                {
                    result = true;
                }
            }
            return result;
        }

        private void button4_Click(object sender, EventArgs e)
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
                foreach (DataColumn column in finalDataTable.Columns)
                {
                    //得到Excel column對應的檔案名(e.g. en-gb), 如果此檔名和現在的fileInfo檔名相同，就使用該column當Value
                    if (fileinfo.Name.Contains(LanguageMappingHelper.GetMappingFilename(column.ColumnName)))
                    {
                        if (isCreateNew)//代表檔案是空的
                        {
                            //if (variableName == "")
                            //{
                            //    variableName = Microsoft.VisualBasic.Interaction.InputBox("Question?", "Please type a variable you want to use in js file", "languageJS");
                            //}
                            //content = string.Format("var {0} = {{{1}}}", variableName, jsonHelper.ToJsonByColumnName(finalDataTable, column.ColumnName).TrimEnd(',')); 
                            content = string.Format("{{{1}}}", variableName, jsonHelper.ToJsonByColumnName(finalDataTable, column.ColumnName).TrimEnd(',')); 
                            //content = jsonHelper.ToJsonByColumnName(finalDataTable, column.ColumnName);

                        }
                        else
                        {
                            content = content.Insert(start,
                                jsonHelper.ToJsonByColumnName(finalDataTable, column.ColumnName));
                        }
                        break;
                    }
                }

                File.WriteAllText(fullPath, content);

            }
            System.Diagnostics.Process.Start(txt_selectJsFolder.Text);
        

        }

        private void selectTargetFolder_Click(object sender, EventArgs e)
        {
            var temp = FileHelper.OpenFolder();
            if (temp != string.Empty)
            {
                txt_selectJsFolder.Text = temp;
            }
        }
    }
}
