using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AgileBet.Cash.Portal.Common;
using FinanLanGen;
using Microsoft.VisualBasic;
using Newtonsoft.Json;

namespace WindowsFormsApplication1
{
    class JsonHelper
    {
        public string ToJSON(DataTable dataTable)
        {
            string result = "[";

            foreach (DataRow row in dataTable.Rows)
            {
                string s = String.Empty;

                for (int i = 0; i < row.ItemArray.Length; i++) // "xxx":"yyy", "ttt","ggg"
                {
                    s += String.Format("\"{0}\":\"{1}\"", dataTable.Columns[i].ColumnName,row[i]);
                    if (i!=row.ItemArray.Length-1)
                    {
                        s+=",";
                    }
                }
                string jsonObjectString = String.Format("{{ {0} }},",s);

                result += jsonObjectString;
            }

            result = result.TrimEnd(',')+ "]";
            return result;
        }

        

        public string ToLanJSON(DataTable dataTable,int i)
        {
            string result="";

            foreach (DataRow row in dataTable.Rows)
            {
                if(row[0].ToString()!=String.Empty)
                //每一種語系 "key":"Value"
                result += String.Format("\"{0}\":\"{1}\",", row[0], row[i]);
            }

            //result = result.TrimEnd(',');
            return result;
        }

        public string ToJsonByColumnName(DataTable dataTable, string columnName)
        {
            string result = "";
           
            foreach (DataRow row in dataTable.Rows)
            {
                string key = row[0].ToString();
                if (key != String.Empty)
                {
                    key = key.Replace(" ", "_");
                    string value = row[columnName].ToString()
                        .Replace("\"", "\'");
                       // .Replace(System.Environment.NewLine, "");
                    value = Regex.Replace(value, @"\r\n?|\n", "");
                    //每一種語系 "key":"Value"
                    result += String.Format("\"{0}\":\"{1}\",", key, value);
                }
            }

            //result = result.TrimEnd(',');
            return result;
        }

        public string useDictionaryJsonStringify(DataTable dataTable, string columnName)
        {
            Dictionary<string, object> dictionary = new Dictionary<string, object>();
            foreach (DataRow row in dataTable.Rows)
            {
                string key = row[0].ToString();
                if (key != String.Empty)
                {
                    key = key.Replace(" ", "_");
                    string value = row[columnName].ToString();//.Replace("\"", "\'");
                    //每一種語系 "key":"Value"
                    //result += string.Format("\"{0}\":\"{1}\",", key, value);
                    dictionary.Add(key, value);
                }

            }

            //result = result.TrimEnd(',');
            return JsonSerializerHelper.Serialize(dictionary);
        }

        public void WriteToJs(JsFormat jformat, string targetFolder, DataTable dtJsDataTable)
        {
            var variableName = "";
            var directory = new DirectoryInfo(targetFolder);
            var fileEntries = directory.GetFiles().Where(f => f.Extension == ".js").ToList();
            //            string[] fileEntries = Directory.GetFiles(txt_selectJsFolder.Text);
            var isCreateNew = MessageBox.Show("Do you want to create new file?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes;
            foreach (FileInfo fileinfo in fileEntries)
            {
                string fullPath = fileinfo.FullName;// fileEntries[i];
                string content = isCreateNew ? "" : File.ReadAllText(fullPath);//File.ReadAllText(fullPath);
                int start = content.IndexOf('{') + 1;
                foreach (DataColumn column in dtJsDataTable.Columns)
                {
                    //得到Excel column對應的檔案名(e.g. en-gb), 如果此檔名和現在的fileInfo檔名相同，就使用該column當Value
                    if (fileinfo.Name.Contains(LanguageMappingHelper.GetMappingFilename(column.ColumnName)))
                    {
                        if (isCreateNew)//代表檔案是空的
                        {
                            switch (jformat)
                            {
                                case JsFormat.Esports:
                                    if (variableName == "")
                                    {
                                        variableName = Interaction.InputBox("Question?", "Please type a variable you want to use in js file", "languageJS");
                                    }
                                    content = String.Format("var {0} = {{{1}}}", variableName, this.ToJsonByColumnName(dtJsDataTable, column.ColumnName).TrimEnd(','));
                                    break;
                                case JsFormat.I18N:
                                    content = string.Format("{{{0}}}", this.ToJsonByColumnName(dtJsDataTable, column.ColumnName).TrimEnd(','));
                                    break;
                            }
                        }
                        else
                        {
                            content = content.Insert(start,
                                this.ToJsonByColumnName(dtJsDataTable, column.ColumnName));
                        }
                        break;
                    }
                }

                File.WriteAllText(fullPath, content);

            }
            Process.Start(targetFolder);
        }

        public enum JsFormat
        {
            I18N, Esports, Financial
        }

        //public string useDictionaryJsonStringify(DataTable dataTable, string columnName)
        //{
        //    Dictionary<string,string> dictionary = new Dictionary<string, string>();
        //    foreach (DataRow row in dataTable.Rows)
        //    {
        //        string key = row[0].ToString();
        //        if (key != string.Empty)
        //        {
        //            key = key.Replace(" ", "_");
        //            string value = row[columnName].ToString();//.Replace("\"", "\'");
        //            //每一種語系 "key":"Value"
        //            //result += string.Format("\"{0}\":\"{1}\",", key, value);
        //            dictionary.Add(key,value);
        //        }
               
        //    }

        //    //result = result.TrimEnd(',');
        //    return JsonSerializerHelper.Serialize(dictionary); 
        //}
    }
}
