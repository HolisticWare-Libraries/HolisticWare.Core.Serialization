using System.IO;
using System.Threading.Tasks;
using StackXML;

namespace Core.Serialization.Text.XML.HolisticWare.StackXML;

/// <summary>
/// XML class for serialization/deserialization with System.Xml.Serialization.XmlSerializer
/// </summary>
/// https://docs.microsoft.com/en-us/dotnet/api/system.xml.serialization.xmlserializer
public partial class 
                                        XML 
                                        // :
                                        // IStorageTransmission
{
    public 
        T 
                                        DeserializeUnmarshall<T>
                                        (
                                            string text
                                        )
                                        where T 
                                        :
                                        global::StackXML.IXmlSerializable,
                                        new()
    {
        return global::StackXML.XmlReadBuffer.ReadStatic<T>(text);
    }

    public async 
        Task<T> 
                                        DeserializeUnmarshallAsync<T>
                                        (
                                            string text
                                        )
                                        where T 
                                        :
                                        global::StackXML.IXmlSerializable,
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
                                        where T : global::StackXML.IXmlSerializable
    {
        string xml = default(string);

        using (global::StackXML.XmlWriteBuffer buffer = new ())
        {
            xml = global::StackXML.XmlWriteBuffer.SerializeStatic(t);
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
