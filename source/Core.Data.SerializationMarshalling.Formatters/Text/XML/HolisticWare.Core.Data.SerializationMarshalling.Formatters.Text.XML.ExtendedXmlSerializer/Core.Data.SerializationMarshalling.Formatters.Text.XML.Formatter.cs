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
    private static readonly 
        global::Microsoft.IO.RecyclableMemoryStreamManager
                                        manager = new ();

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
        return this.DeserializeUnmarshall_MemoryStream<T>(text);
    }

    protected 
        T 
                                        DeserializeUnmarshall_MemoryStream<T>
                                        (
                                            string text
                                        )
                                        where T 
                                        :
                                        new()
    {
        T result = default(T);
        
        IExtendedXmlSerializer serializer = new ConfigurationContainer().Create();

        using (System.IO.MemoryStream stream = new (System.Text.Encoding.UTF8.GetBytes(text)))
        {
            result = serializer.Deserialize<T>(stream);
        }      

        return result;
    }
    
    protected 
        T 
                                        DeserializeUnmarshall_RecyclableMemoryStream<T>
                                        (
                                            string text
                                        )
                                        where T 
                                        :
                                        new()
    {
        T result = default(T);
        
        IExtendedXmlSerializer serializer = new ConfigurationContainer().Create();
        
        using (Microsoft.IO.RecyclableMemoryStream stream = manager.GetStream())
        {
            stream.Write(System.Text.Encoding.UTF8.GetBytes(text));
            stream.Position = 0;
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
                                    return this.DeserializeUnmarshall<T>(text);
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
        using (System.IO.MemoryStream stream = new ())
        {
            serializer.Serialize(stream, t);
            stream.Position = 0;
            using (System.IO.StreamReader reader = new (stream))
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
                                    return this.SerializeMarshallAsync<T>(t);
                                }
                            );
    }
}
