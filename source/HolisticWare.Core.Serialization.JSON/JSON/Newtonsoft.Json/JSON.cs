using System;
using System.Threading.Tasks;

namespace Core.Serialization.JSON.Newtonsoft.Json
{
    /// <summary>
    /// 
    /// </summary>
    /// https://www.newtonsoft.com/json/help/html/SerializingJSON.htm
    public class JSON : IStorageTransmission
    {
        public T DeserializeUnmarshall<T>(string text)
        {
            return global::Newtonsoft.Json.JsonConvert.DeserializeObject<T>(text);
        }

        public string SerializeMarshall<T>(T t)
        {
            string json = global::Newtonsoft.Json.JsonConvert.SerializeObject(t);

            return json;
        }

    }
}
