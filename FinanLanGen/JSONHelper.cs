using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using AgileBet.Cash.Portal.Common;
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
                string s = string.Empty;

                for (int i = 0; i < row.ItemArray.Length; i++) // "xxx":"yyy", "ttt","ggg"
                {
                    s += string.Format("\"{0}\":\"{1}\"", dataTable.Columns[i].ColumnName,row[i]);
                    if (i!=row.ItemArray.Length-1)
                    {
                        s+=",";
                    }
                }
                string jsonObjectString = string.Format("{{ {0} }},",s);

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
                if(row[0].ToString()!=string.Empty)
                //每一種語系 "key":"Value"
                result += string.Format("\"{0}\":\"{1}\",", row[0], row[i]);
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
                if (key != string.Empty)
                {
                    key = key.Replace(" ", "_");
                    string value = row[columnName].ToString()
                        .Replace("\"", "\'");
                       // .Replace(System.Environment.NewLine, "");
                    value = Regex.Replace(value, @"\r\n?|\n", "");
                    //每一種語系 "key":"Value"
                    result += string.Format("\"{0}\":\"{1}\",", key, value);
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
                if (key != string.Empty)
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
