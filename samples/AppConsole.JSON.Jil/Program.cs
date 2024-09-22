/*
please provide code sample in C# for
   jil
serialization and deserialization
*/

using System;
using System.Collections.Generic;
using System.IO;
using Jil;

namespace SerializationExample
{
   public class Employee
   {
      public int Id { get; set; }
      public string Name { get; set; }
      public string Email { get; set; }
      public string Dept { get; set; }
   }

   class Program
   {
      static void Main(string[] args)
      {
         List<Employee> employees = new List<Employee>
         {
            new Employee { Id = 1, Name = "Alice", Email = "alice@example.com", Dept = "HR" },
            new Employee { Id = 2, Name = "Bob", Email = "bob@example.com", Dept = "IT" }
         };

         // Serialize
         string jsonData = SerializeEmployees(employees);
         Console.WriteLine("Serialized JSON:");
         Console.WriteLine(jsonData);

         // Deserialize
         List<Employee> deserializedEmployees = DeserializeEmployees(jsonData);
         Console.WriteLine("\nDeserialized Objects:");
         foreach (var emp in deserializedEmployees)
         {
            Console.WriteLine($"Id: {emp.Id}, Name: {emp.Name}, Email: {emp.Email}, Dept: {emp.Dept}");
         }
      }

      private static string SerializeEmployees(List<Employee> employees)
      {
         using (var output = new StringWriter())
         {
            JSON.Serialize(employees, output);
            return output.ToString();
         }
      }

      private static List<Employee> DeserializeEmployees(string jsonData)
      {
         using (var input = new StringReader(jsonData))
         {
            return JSON.Deserialize<List<Employee>>(input);
         }
      }
   }
}
