using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace AgileBet.Cash.Portal.Common
{
    public static class JsonSerializerHelper
    {
        private static readonly Dictionary<string, DataContractJsonSerializer> cache = new Dictionary<string, DataContractJsonSerializer>();
        private static readonly object syncRoot = new object();

        public static string Serialize<T>(T obj)
        {
            DataContractJsonSerializer serializer = GetSerializer(typeof(T));
            using (MemoryStream stream = new MemoryStream())
            {
                serializer.WriteObject(stream, obj);
                return Encoding.UTF8.GetString(stream.ToArray());
            }
        }

        public static TReturn ToObj<TReturn>(string json)
        {
            if(string.IsNullOrEmpty(json)) return default(TReturn);
            DataContractJsonSerializer serializer = GetSerializer(typeof(TReturn));
            using (MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(json)))
            {
                return (TReturn)serializer.ReadObject(stream);
            }
        }

        private static DataContractJsonSerializer GetSerializer(Type type)
        {
            DataContractJsonSerializer serializer;
            //QAT-5322 avoid duplicate list<> case happen again
            string typeName = type.ToString();
            if (!cache.TryGetValue(typeName, out serializer))
            {
                lock (syncRoot)
                {
                    if (!cache.TryGetValue(typeName, out serializer))
                    {
                        serializer = new DataContractJsonSerializer(type);
                        cache[typeName] = serializer;
                    }
                }
            }

            return serializer;
        }
    }
}