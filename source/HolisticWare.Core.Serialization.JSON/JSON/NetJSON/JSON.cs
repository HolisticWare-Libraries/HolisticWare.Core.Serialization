using System;
using System.Threading.Tasks;

namespace Core.Serialization.JSON.NetJSON
{
    /// <summary>
    /// 
    /// </summary>
    /// https://github.com/rpgmaker/NetJSON/
    /// https://theburningmonk.com/2014/08/json-serializers-benchmarks-updated-2/
    /// NetJSON did not handle the following:
    //      1 – Classes that contain collections of Interfaces or abstract class (e.g.List)
    //      2 – Classes that implement IEnumerable<DictionaryEntry>
    //      3 – Classes that have several equals operator overloads
    //      4 – Classes that implement an interface with generic parameters.
    public class JSON : IStorageTransmission
    {
        public T DeserializeUnmarshall<T>(string text)
        {
            return global::NetJSON.NetJSON.Deserialize<T>(text);
        }

        public Task<T> DeserializeUnmarshallAsync<T>(string text)
        {
            throw new NotImplementedException();
        }

        public string SerializeMarshall<T>(T t)
        {
            return global::NetJSON.NetJSON.Serialize(t);
        }

        public async Task<string> SerializeMarshallAsync<T>(T t)
        {
            throw new NotImplementedException();
        }
    }
}
