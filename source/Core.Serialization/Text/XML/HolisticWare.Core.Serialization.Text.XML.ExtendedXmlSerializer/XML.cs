using System.IO;
using System.Threading.Tasks;
using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;

namespace Core.Serialization.Text.XML.ExtendedXmlSerializer;

/// <summary>
/// XML class for serialization/deserialization with System.Xml.Serialization.XmlSerializer
/// </summary>
/// https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlserializer
public partial class 
                                        XML 
                                        :
                                        IStorageTransmission
{
    public 
        T 
                                        DeserializeUnmarshall<T>
                                        (
                                            string text
                                        )
                                        where T 
                                        :
                                        new()
    {
        T result = default(T);
        
        IExtendedXmlSerializer serializer = new ConfigurationContainer().Create();

        using (MemoryStream stream = new (System.Text.Encoding.UTF8.GetBytes(text)))
        {
            result = serializer.Deserialize<T>(stream);
        }      

        return result;
    }

    public async 
        Task<T> 
                                        DeserializeUnmarshallAsync<T>
                                        (
                                            string text
                                        )
                                        where T 
                                        :
                                        new()
    {
        return await Task.Run
                            (
                                () =>
                                {
                                    return DeserializeUnmarshall<T>(text);
                                }
                            );
    }

    public 
        string
                                        SerializeMarshall<T>
                                        (
                                            T t
                                        )
    {
        IExtendedXmlSerializer serializer = new ConfigurationContainer().Create();

        string xml;
        using (MemoryStream stream = new MemoryStream())
        {
            serializer.Serialize(stream, t);
            stream.Position = 0;
            using (StreamReader reader = new StreamReader(stream))
            {
                xml = reader.ReadToEnd();
            }
        }

        return xml;
    }

    public async 
        Task<string> 
                                        SerializeMarshallAsync<T>
                                        (
                                            T t
                                        )
    {
        return await Task.Run
                            (
                                () =>
                                {
                                    return SerializeMarshallAsync<T>(t);
                                }
                            );
    }
}
