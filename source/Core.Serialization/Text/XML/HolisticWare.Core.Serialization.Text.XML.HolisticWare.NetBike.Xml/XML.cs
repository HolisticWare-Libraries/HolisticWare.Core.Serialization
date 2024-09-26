using System.IO;
using System.Threading.Tasks;

using NetBike.Xml;

namespace Core.Serialization.Text.XML.HolisticWare.NetBike.Xml;

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
        T t = default(T);
        XmlSerializer serializer = new ();

        using (var reader = new StringReader(text))
        {
            t = serializer.Deserialize<T>(reader);
        }

        return t;
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
        string xml;
        XmlSerializer serializer = new();

        using (StringWriter writer = new())
        {
            serializer.Serialize(writer, t);
            xml = writer.ToString();
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
