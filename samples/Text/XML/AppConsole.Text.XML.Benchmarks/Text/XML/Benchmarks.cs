using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

namespace AppConsole.Text.XML.Benchmarks;

public class Person
{
    public int Id { get; set; }

    public string Name { get; set; }
}

[SimpleJob(RuntimeMoniker.Net80)]
[SimpleJob(RuntimeMoniker.Net90)]
[SimpleJob(RuntimeMoniker.NativeAot80)]
[SimpleJob(RuntimeMoniker.NativeAot90)]
// [SimpleJob(RuntimeMoniker.Mono)]
[RPlotExporter]
[MemoryDiagnoser(true)]
[ThreadingDiagnoser]
[ExceptionDiagnoser]
/*
[InliningDiagnoser]
[TailCallDiagnoser]
[EtwProfiler]
[ConcurrencyVisualizerProfiler]
[NativeMemoryProfiler]
*/
public partial class 
                                        Benchmarks_XML
{
    Person person;
    string xml;
    
    [GlobalSetup]
    public void Setup()
    {
        person = new Person { Id = 1, Name = "John Doe" };
        person_stackxml = new StackXML_Person() { Id = 1, Name = "John Doe" };
        xml  = "<Person><Id>1</Id><Name>John Doe</Name></Person>";
    }

}