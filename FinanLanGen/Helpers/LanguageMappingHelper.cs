using System.Collections.Generic;

namespace FinanLanGen.Helpers
{
    static class LanguageMappingHelper
    {
        public static string GetMappingFilename(string key)
        {
            var result = "fsdafsdagasgafsdfa";
            Dictionary<string, string> mapDictionary = new Dictionary<string, string>()
            {
               {"English","en-gb"},{"Brazil","pt-br" },{"Cambodia" ,"km-kh" },{"Khmer","km-kh"},{"China" ,"zh-cn" },{"Chinese","zh-cn"},{"Indonesia" ,"id-id" },{"Japan" ,"ja-jp" },{"Korea" ,"ko-kr" },{"Malaysia" ,"zh-cn" },{"Thai" ,"th-th" },{"Vietnam" ,"vi-vn" }
            };


            foreach (var map in mapDictionary)
            {
                if (key.ToLower().Contains(map.Key.ToLower())||key.ToLower().Contains(map.Value.ToLower()))
                {
                    result = map.Value;
                    break;
                }
            }

            return result;
        }

        public static string mapReplace(string fileName, string containFolder)
        {
            var result = "";
            Dictionary<string, string> mapDictionary = new Dictionary<string, string>()
            {
                {"Brazil","pt-br" },{"Cambodia" ,"km-kh" },{"China" ,"zh-cn" },{"Indonesia" ,"id-id" },{"Japan" ,"ja-jp" },{"Korea" ,"ko-kr" },{"Malaysia" ,"zh-cn" },{"ROA" ,"zh-cn" },{"ROE" ,"zh-cn" },{"ROW" ,"zh-cn" },{"Thailand" ,"th-th" },{"UK" ,"zh-cn" },{"Vietnam" ,"vi-vn" }
            };
            foreach (var map in mapDictionary)
            {
                if (containFolder == map.Key)
                {
                    result = fileName.Replace("en-gb", map.Value);
                }
            }

            return result;
        }
    }
}
