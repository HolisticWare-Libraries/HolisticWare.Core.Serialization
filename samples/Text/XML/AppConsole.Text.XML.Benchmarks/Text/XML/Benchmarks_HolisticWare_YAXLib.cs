using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace AppConsole.Text.XML.Benchmarks;

public partial class 
                                        Benchmarks_XML
{
    [Benchmark]
    public 
        Person
                                        HolisticWare_YAXLib_DeserializeUnmarshall
                                        (
                                        )
    {
        Core.Serialization.Text.XML.HolisticWare.YAXLib.XML serializer = new();

        Person p = serializer.DeserializeUnmarshall<Person>(xml);
        
        return p;
    }

    [Benchmark]
    public 
        string
                                        HolisticWare_YAXLib_SerializeMarshall
                                        (
                                        )
    {
        Core.Serialization.Text.XML.HolisticWare.YAXLib.XML serializer = new();

        string data = serializer.SerializeMarshall<Person>(person);
        
        return data;
    }
}