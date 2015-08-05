
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanLanGen
{
    static class ExcelHelper
    {
        public static DataTable GetExcelDataTable(string filePath, string sql)
        {
            try
            {
                //Office 2003
                //OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties='Excel 8.0;HDR=YES;IMEX=1;Readonly=0'");

                //Office 2007
                OleDbConnection conn =
                    new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath +
                                        ";Extended Properties='Excel 12.0 Xml;HDR=YES'");

                OleDbDataAdapter da = new OleDbDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dt.TableName = "tmp";
                conn.Close();
                return dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Please input correct SQL Command for your file!");
                return null;
            }
        }

        public static DataTable GetExcelDataTable(string filePath)
        {
            try
            {
                //Office 2003
                //OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filePath + ";Extended Properties='Excel 8.0;HDR=YES;IMEX=1;Readonly=0'");

                //Office 2007
                OleDbConnection conn =
                    new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath +
                                        ";Extended Properties='Excel 12.0 Xml;HDR=YES'");

                OleDbDataAdapter da = new OleDbDataAdapter("select * from", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dt.TableName = "tmp";
                conn.Close();
                return dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Please input correct SQL Command for your file!");
                return null;
            }
        }

        public static DataTable ImportExcel(string query, string excelPath)
        {
            string sheetName = Microsoft.VisualBasic.Interaction.InputBox("Question?", "Please type the sheetName you want to use", "Message");
            string tableName = sheetName == "" ? "[Sheet1$]" : string.Format("[{0}$]", sheetName); //在頁簽名稱後加$，再用中括號[]包起來
            string inputsql = query == "" ? "select * from " : query;
            string sql = inputsql + " " + tableName; //SQL查詢
            return GetExcelDataTable(excelPath, sql);
        }

    }
}
