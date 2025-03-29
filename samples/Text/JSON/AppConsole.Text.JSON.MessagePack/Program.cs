/*
please provide code sample in C# for
   MessagePack
serialization and deserialization
*/

using HolisticWare.MessagePack;

using HolisticWare.Ph4ct3x;

Person person = new()
                {
                    FirstName = "John",
                    LastName = "Doe",
                    Age = 30
                };

// Serialize to JSON format
string jsonData = CustomMessagePackSerializer.SerializeToJson(person);
Console.WriteLine("Serialized to JSON: " + jsonData);

// Deserialize from JSON format
Person? deserializedFromJsonPerson = CustomMessagePackSerializer.DeserializeFromJson<Person>(jsonData);
Console.WriteLine($"Deserialized from JSON: {deserializedFromJsonPerson.FirstName} {deserializedFromJsonPerson.LastName}, Age: {deserializedFromJsonPerson.Age}");

return;