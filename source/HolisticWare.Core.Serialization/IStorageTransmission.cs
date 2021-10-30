using System.Threading.Tasks;

namespace Core.Serialization
{
    /// <summary>
    /// 
    /// </summary>
    /// https://en.wikipedia.org/wiki/Marshalling_(computer_science)
    public interface IStorageTransmission
                        :
                        ISerializerMarshaller,
                        IDeserializerUnmarshaller
    {
    }
}