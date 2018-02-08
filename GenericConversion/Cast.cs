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
        /// Convert DataTable into Generic List.
        /// </summary>
        /// <typeparam name="T">Generic type object.</typeparam>
        /// <param name="dataTable">DataTable</param>
        /// <returns>List of generic type object.</returns>
        public static List<T> ToGenericList<T>(DataTable dataTable)
        {
            var _list = ConvertToGenericList.ConvertDataTable<T>(dataTable);
            return _list;
        }

        /// <summary>
        /// Convert a Generic List into Json.
        /// </summary>
        /// <typeparam name="T">Generic type object.</typeparam>
        /// <param name="data">Generic list.</param>
        /// <returns>Json formatted string.</returns>
        public static string ToJson<T>(List<T> data)
        {
            string json = ConvertToJson.ListToJson<T>(data);
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
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        private static void ObjectToJson<T>(T value)
        {

        }
    }
}
