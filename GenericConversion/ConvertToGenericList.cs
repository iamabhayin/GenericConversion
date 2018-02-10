using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace GenericConversion
{
    internal class ConvertToGenericList
    {
        internal static List<T> ConvertDataTable<T>(DataTable dt, bool ignore)
        {
            try
            {
                List<T> data = new List<T>();
                foreach (DataRow row in dt.Rows)
                {
                    T item = GetItem<T>(row, ignore);
                    data.Add(item);
                }
                return data;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private static T GetItem<T>(DataRow dr, bool ignore)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                if(!temp.GetProperties().Any(x=>x.Name == column.ColumnName) && ignore)
                {
                    throw new Exception("Fields name doesn't match with class type.");
                }

                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                    {
                        var value = Convert.ChangeType(dr[column.ColumnName].ToString(), pro.PropertyType , CultureInfo.InvariantCulture);
                        //pro.SetValue(obj, dr[column.ColumnName], null);
                        pro.SetValue(obj, value, null);
                    }
                }
            }
            return obj;
        }

        internal static List<T> ConvertDataTable<T>(string jsonString, bool ignore)
        {
            try
            {
                var _dataTable = ConvertToDatatable.JsonToDataTable(jsonString);
                var _list = ConvertDataTable<T>(_dataTable, false);
                return _list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
