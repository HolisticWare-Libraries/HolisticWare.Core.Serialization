using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace AppConsole.Text.XML.Benchmarks;

public partial class 
                                        Benchmarks_XML
{
    [Benchmark]
    public 
        Person
                                        System_Runtime_Serialization_DeserializeUnmarshall
                                        (
                                        )
    {
        Core.Serialization.Text.XML.System.Runtime.Serialization.XML serializer = new();

        Person p = serializer.DeserializeUnmarshall<Person>(xml);
        
        return p;
    }

    [Benchmark]
    public 
        string
                                        System_Runtime_Serialization_SerializeMarshall
                                        (
                                        )
    {
        Core.Serialization.Text.XML.System.Runtime.Serialization.XML serializer = new();

        string data = serializer.SerializeMarshall<Person>(person);
        
        return data;
    }
}