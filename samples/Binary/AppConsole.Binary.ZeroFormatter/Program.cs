using HolisticWare.MessagePack;

using HolisticWare.Ph4ct3x;

Person person = new Person
{
    FirstName = "John",
    LastName = "Doe",
    Age = 30
};

// Serialize to MessagePack binary format
byte[] binaryData = CustomMessagePackSerializer.Serialize(person);
Console.WriteLine("Serialized to binary: " + BitConverter.ToString(binaryData));

// Deserialize from MessagePack binary format
Person? deserializedPerson = CustomMessagePackSerializer.Deserialize<Person>(binaryData);
Console.WriteLine($"Deserialized from binary: {deserializedPerson.FirstName} {deserializedPerson.LastName}, Age: {deserializedPerson.Age}");

return;