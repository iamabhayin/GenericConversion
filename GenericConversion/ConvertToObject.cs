using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using Newtonsoft;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace GenericConversion
{
    internal class ConvertToObject
    {
        public ConvertToObject()
        {

        }

        public static T JsonDeserialize<T>(string jsonString, bool checkFields)
        {
            try
            {
                var jObj = JObject.Parse(jsonString);

                if (checkFields)
                {
                    Type temp = typeof(T);
                    T _obj = Activator.CreateInstance<T>();

                    var props = jObj.Properties();
                    foreach (var item in props)
                    {
                        if(!temp.GetProperties().Any(x=>x.Name == item.Name))
                        {
                            throw new Exception("Fields of object and json does not match.");
                        }
                    }
                }

                //DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
                //MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
                //T obj = (T)ser.ReadObject(ms);
                //return obj;

                return JsonConvert.DeserializeObject<T>(jsonString);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
