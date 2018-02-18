namespace GenericConversion
{
    using System.Collections.Generic;
    using System.Data;

    public partial class Cast
    {
        /// <summary>
        /// Convert Generic List into DataTable.
        /// </summary>
        /// <typeparam name="T">Genric type object.</typeparam>
        /// <param name="list">Genrtic list</param>
        /// <returns>DataTable</returns>
        public static DataTable ToDatatable<T>(List<T> list)
        {
            var _dataTable = ConvertToDatatable.ToDataTable<T>(list);
            return _dataTable;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static DataTable ToDataTable(string json)
        {
            var _dataTable = ConvertToDatatable.JsonToDataTable(json);
            return _dataTable;
        }

        /// <summary>
        /// Convert DataTable into Generic List.
        /// </summary>
        /// <typeparam name="T">Generic type object.</typeparam>
        /// <param name="dataTable">DataTable</param>
        /// /// <param name="ignore">Pass 'true' if want to match the fields name between DataTable and Generic type T else 'false'.</param>
        /// <returns>List of generic type object.</returns>
        public static List<T> ToGenericList<T>(DataTable dataTable, bool ignore)
        {
            var _list = ConvertToGenericList.ConvertDataTable<T>(dataTable, ignore);
            return _list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json">Json formatted string.</param>
        /// /// <param name="ignore">Pass 'true' if want to match the fields name between Json and Generic type T else 'false'.</param>
        /// <returns></returns>
        public static List<T> ToGenericList<T>(string json, bool ignore)
        {
            var _list = ConvertToGenericList.ConvertDataTable<T>(json, ignore);
            return _list;
        }

        /// <summary>
        /// Convert a Generic List into Json.
        /// </summary>
        /// <typeparam name="T">Generic type object.</typeparam>
        /// <param name="data">Generic list.</param>
        /// <returns>Json formatted string.</returns>
        public static string ToJson<T>(T data)
        {
            string json = ConvertToJson.JsonSerializer<T>(data);
            return json;
        }

        /// <summary>
        /// Convert DataTable into Json.
        /// </summary>
        /// <param name="dataTable">DataTable</param>
        /// <returns>Json formatted string.</returns>
        public static string ToJson(DataTable dataTable)
        {
            string json = ConvertToJson.DataTableToJson(dataTable);
            return json;
        }

        /// <summary>
        /// Convert a json object string into generic type object.
        /// </summary>
        /// <typeparam name="T">T is type in which you want to convert the json string.</typeparam>
        /// <param name="json">json string</param>
        /// <param name="checkFieldName">Pass true for checking the fields of T type and fields in json string.</param>
        /// <returns>Return the T type object.</returns>
        public static T ToObject<T>(string json, bool checkFieldName)
        {
            var obj = ConvertToObject.JsonDeserialize<T>(json, checkFieldName);
            return obj;
        }

        /// <summary>
        /// Convert a json string into object.
        /// </summary>
        /// <param name="json">Json string</param>
        /// <returns>Return object type.</returns>
        public static object ToObject(string json)
        {
            var obj = ConvertToObject.JsonDeserialize<object>(json, false);
            return obj;
        }

    }
}
