﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanLanGen
{
    public class ResxHelper
    {
        public static string ToXml(string key,string value,string comment)
        {
            var result = string.Format(
                "<data name=\"{0}\" xml:space=\"preserve\">{3}<value>{1}</value>{3}<comment>{2}</comment>{3}</data>{3}"
                ,key,value,comment,Environment.NewLine);
            return result;
        }
    }

    class Resx
    {

  //       <data name="WorldCup_Final" xml:space="preserve">
  //  <value>វគ្គផ្ដាច់ព្រាត់</value>
  //  <comment>WorldCup Final</comment>
  //</data>
  //<data name="WorldCup_Venue" xml:space="preserve">
  //  <value>ទីលានប្រកួត</value>
  //  <comment>WorldCup Venue</comment>
  //</data>
    }
}
