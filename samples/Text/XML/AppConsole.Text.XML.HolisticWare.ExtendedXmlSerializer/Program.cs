/*
please provide code sample in C# for
   ExtendedXmlSerializer
serialization and deserialization

*/

using ExtendedXmlSerializer;
using ExtendedXmlSerializer.Configuration;
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
      var person = new Person { Id = 1, Name = "John Doe" };
      var serializer = new ConfigurationContainer().Create();

      string xml;
      using (var stream = new MemoryStream())
      {
         serializer.Serialize(stream, person);
         stream.Position = 0;
         using (var reader = new StreamReader(stream))
         {
            xml = reader.ReadToEnd();
            Console.WriteLine(xml);
         }
      }
      
      xml = "<Person><Id>1</Id><Name>John Doe</Name></Person>";
      serializer = new ConfigurationContainer().Create();

      using (var stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(xml)))
      {
         person = serializer.Deserialize<Person>(stream);
         Console.WriteLine($"Id: {person.Id}, Name: {person.Name}");
      }      
   }
}
