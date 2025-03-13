/*
please provide code sample in C# for
   StackXml
serialization and deserialization

*/

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

public class Program
{
   public static void Main()
   {
      Person person = new Person { Id = 1, Name = "John Doe" };
      XmlWriteBuffer buffer = new XmlWriteBuffer();
        
      
      string xml = XmlWriteBuffer.SerializeStatic(person);
        
      Console.WriteLine(xml);
      
      xml = "<Person><Id>1</Id><Name>John Doe</Name></Person>";
        
      XmlReadBuffer.ReadStatic<Person>(xml);
      
      Console.WriteLine($"Id: {person.Id}, Name: {person.Name}");      
      
   }
}
