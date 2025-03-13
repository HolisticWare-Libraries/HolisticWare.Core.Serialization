/*
please provide code sample in C# for
   NetJson
serialization and deserialization
*/

using System;
using NetJSON;

public class Person
{
   public string Name { get; set; }
   public int Age { get; set; }
}

public class Program
{
   public static void Main()
   {
      // Create an instance of the Person class
      Person person = new Person { Name = "John Doe", Age = 30 };

      // Serialize the person object to a JSON string
      string jsonString = NetJSON.NetJSON.Serialize(person);
      Console.WriteLine("Serialized JSON: " + jsonString);

      // Deserialize the JSON string back to a Person object
      Person deserializedPerson = NetJSON.NetJSON.Deserialize<Person>(jsonString);
      Console.WriteLine("Deserialized Person: Name = " + deserializedPerson.Name + ", Age = " + deserializedPerson.Age);
   }
}