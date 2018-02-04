using System;
using System.Collections.Generic;
using System.Data;
using Newtonsoft.Json;

namespace GenericConversion
{
    internal class ConvertToJson
    {
        public static string DataTableToJson(DataTable table)
        {
            string JSONString = string.Empty;
            JSONString = JsonConvert.SerializeObject(table);
            return JSONString;
        }

        public static string ListToJson<T>(List<T> list)
        {
            string JSONString = string.Empty;
            JSONString = JsonConvert.SerializeObject(list);
            return JSONString;
        }
    }
}
