/*
please provide code sample in C# for
       protobuf
serialization and deserialization

please provide code sample in C# for
          protobuf
serialization and deserialization without attibutes
*/

using AppConsole.Protobuf;

public class Program
{
       public static void Main()
       {
              // Create a new person object
              Person person = new Person
              {
                     Id = 1,
                     Name = "John Doe",
                     Email = "john.doe@example.com"
              };

              // Serialize the person object to a byte array
              byte[] serializedData;
              using (MemoryStream stream = new MemoryStream())
              {
                     ProtoBuf.Serializer.Serialize(stream, person);
                     serializedData = stream.ToArray();
              }

              // Deserialize the byte array back to a person object
              Person deserializedPerson;
              using (MemoryStream stream = new MemoryStream(serializedData))
              {
                     deserializedPerson = ProtoBuf.Serializer.Deserialize<Person>(stream);
              }

              // Display the deserialized person object
              Console.WriteLine($"Id: {deserializedPerson.Id}, Name: {deserializedPerson.Name}, Email: {deserializedPerson.Email}");
       }
}
