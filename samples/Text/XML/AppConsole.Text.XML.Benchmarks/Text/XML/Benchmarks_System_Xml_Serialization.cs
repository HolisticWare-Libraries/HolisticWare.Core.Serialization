using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace AppConsole.Text.XML.Benchmarks;

public partial class 
                                        Benchmarks_XML
{
    [Benchmark]
    public 
        Person
                                        System_Xml_Serialization_DeserializeUnmarshall
                                        (
                                        )
    {
        Core.Serialization.Text.XML.System.Xml.Serialization.XML serializer = new();

        Person p = serializer.DeserializeUnmarshall<Person>(xml);
        
        return p;
    }

    [Benchmark]
    public 
        string
                                        System_Xml_Serialization__SerializeMarshall
                                        (
                                        )
    {
        Core.Serialization.Text.XML.System.Xml.Serialization.XML serializer = new();

        string data = serializer.SerializeMarshall<Person>(person);
        
        return data;
    }
}