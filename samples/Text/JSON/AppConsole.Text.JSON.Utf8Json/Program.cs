/*
please provide code sample in C# for
   Utf8Json
serialization and deserialization

*/

using System;
using Utf8Json;

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
      var person = new Person { Name = "John Doe", Age = 30 };

      // Serialize the person object to JSON
      byte[] jsonBytes = JsonSerializer.Serialize(person);
      string jsonString = JsonSerializer.ToJsonString(person);
      Console.WriteLine("Serialized JSON (bytes): " + BitConverter.ToString(jsonBytes));
      Console.WriteLine("Serialized JSON (string): " + jsonString);

      // Deserialize the JSON back to a Person object
      var deserializedPerson = JsonSerializer.Deserialize<Person>(jsonBytes);
      Console.WriteLine("Deserialized Person: Name = " + deserializedPerson.Name + ", Age = " + deserializedPerson.Age);
   }
}
