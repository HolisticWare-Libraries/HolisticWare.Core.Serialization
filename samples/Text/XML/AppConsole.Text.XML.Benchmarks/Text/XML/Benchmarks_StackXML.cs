/*
using StackXML;

public class Person : IXmlSerializable
{
   [field: XmlField("Id")]
   public int Id { get; set; }

   [field: XmlField("Name")]
   public string Name { get; set; }

   public override ReadOnlySpan<char> GetNodeName()
   {
      throw new NotImplementedException();
   }
}
*/

using BenchmarkDotNet.Attributes;
using StackXML;

namespace AppConsole.Text.XML.Benchmarks;

public class StackXML_Person : IXmlSerializable
{
   [field: XmlField("Id")]
   public int Id { get; set; }

   [field: XmlField("Name")]
   public string Name { get; set; }

   public override ReadOnlySpan<char> GetNodeName()
   {
      throw new NotImplementedException();
   }
}

public partial class 
   Benchmarks_XML
{
   private StackXML_Person person_stackxml;
   
   [Benchmark]
   public 
      StackXML_Person
                                       StackXML_DeserializeUnmarshall
                                       (
                                       )
   {
      Core.Serialization.Text.XML.StackXML.XML serializer = new();

      StackXML_Person p = serializer.DeserializeUnmarshall<StackXML_Person>(xml);
        
      return p;
   }
   
   [Benchmark]
   public 
      string
                                       StackXML_SerializeMarshall
                                       (
                                       )
   {
      Core.Serialization.Text.XML.StackXML.XML serializer = new();

      string data = serializer.SerializeMarshall<StackXML_Person>(person_stackxml);
        
      return data;
   }
}