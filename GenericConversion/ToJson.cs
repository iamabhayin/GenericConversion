using System;
using System.Collections.Generic;
using System.Data;
using Newtonsoft.Json;

namespace GenericConversion
{
    internal class ToJson
    {
        public string DataTableToJson(DataTable table)
        {
            string JSONString = string.Empty;
            JSONString = JsonConvert.SerializeObject(table);
            return JSONString;
        }

        public string ListToJson<T>(T list)
        {
            string JSONString = string.Empty;
            JSONString = JsonConvert.SerializeObject(list);
            return JSONString;
        }
    }
}
