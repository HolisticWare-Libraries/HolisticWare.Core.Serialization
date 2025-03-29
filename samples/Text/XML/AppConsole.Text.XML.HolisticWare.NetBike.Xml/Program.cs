/*
please provide code sample in C# for
   NetBike.Xml
serialization and deserialization

*/

using NetBike.Xml;
using System;
using System.IO;

public class Person
{
   public int Id { get; set; }
   public string Name { get; set; }
}

public class Program
{
   public static void Main()
   {
      Person? person = new Person { Id = 1, Name = "John Doe" };
      XmlSerializer serializer = new XmlSerializer();

      string xml;
      using (var writer = new StringWriter())
      {
         serializer.Serialize(writer, person);
         xml = writer.ToString();
         Console.WriteLine(xml);
      }
      
      
      xml = "<Person><Id>1</Id><Name>John Doe</Name></Person>";
      serializer = new XmlSerializer();

      using (var reader = new StringReader(xml))
      {
         person = serializer.Deserialize<Person>(reader);
         Console.WriteLine($"Id: {person.Id}, Name: {person.Name}");
      }      
   }
}
