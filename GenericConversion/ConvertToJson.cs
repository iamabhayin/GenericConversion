using System;
using System.Collections.Generic;
using System.Data;
using Newtonsoft.Json;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;

namespace GenericConversion
{
    internal class ConvertToJson
    {
        public static string DataTableToJson(DataTable table)
        {
            try
            {
                string JSONString = string.Empty;
                JSONString = JsonConvert.SerializeObject(table);
                return JSONString;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public static string JsonSerializer<T>(T t)
        {
            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
                MemoryStream ms = new MemoryStream();
                ser.WriteObject(ms, t);
                string jsonString = Encoding.UTF8.GetString(ms.ToArray());
                ms.Close();
                return jsonString;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }

        public static T JsonDeserialize<T>(string jsonString)
        {
            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
                MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
                T obj = (T)ser.ReadObject(ms);
                return obj;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
