/*
please provide code sample in C# for
   System.Runtime.Serialization.DataContractSerializer
serialization and deserialization

*/

using System;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;

[DataContract]
public class Person
{
   [DataMember]
   public int Id { get; set; }

   [DataMember]
   public string Name { get; set; }
}

public class Program
{
   public static void Main()
   {
      Person? person = new Person { Id = 1, Name = "John Doe" };
      DataContractSerializer serializer = new DataContractSerializer(typeof(Person));

      string xml;
      using (MemoryStream stream = new MemoryStream())
      {
         using (XmlDictionaryWriter writer = XmlDictionaryWriter.CreateTextWriter(stream))
         {
            serializer.WriteObject(writer, person);
         }
         // stream.Position = 0;
         using (StreamReader reader = new StreamReader(stream))
         {
            xml = reader.ReadToEnd();
            Console.WriteLine(xml);
         }
      }
      
      xml = "<Person><Id>1</Id><Name>John Doe</Name></Person>";
      serializer = new DataContractSerializer(typeof(Person));

      using (MemoryStream stream = new MemoryStream(System.Text.Encoding.UTF8.GetBytes(xml)))
      {
         using 
         (
            XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader
                                                                   (
                                                                      stream, 
                                                                      new XmlDictionaryReaderQuotas()
                                                                  )
         )
         {
            person = (Person)serializer.ReadObject(reader);
            Console.WriteLine($"Id: {person.Id}, Name: {person.Name}");
         }
      }      
      
   }
}

