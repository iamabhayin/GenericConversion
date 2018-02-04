namespace GenericConversion
{
    using System.Collections.Generic;
    using System.Data;

    public partial class Cast
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static DataTable ToDatatable<T>(List<T> list)
        {
            var _dataTable = ConvertToDatatable.ToDataTable<T>(list);
            return _dataTable;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataTable"></param>
        /// <returns></returns>
        public static List<T> ToGenericList<T>(DataTable dataTable)
        {
            var _list = ConvertToGenericList.ConvertDataTable<T>(dataTable);
            return _list;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string ToJson<T>(List<T> data)
        {
            string json = ConvertToJson.ListToJson<T>(data);
            return json;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataTable"></param>
        /// <returns></returns>
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
        public static void ObjectToJson<T>(T value)
        {

        }
    }
}
