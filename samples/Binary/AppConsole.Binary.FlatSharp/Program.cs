/*
please provide code sample in C# for
   FlatBuffers
serialization and deserialization

https://github.com/jamescourtney/FlatSharp
*/

using System;
using Google.FlatBuffers;
using MyGame.Sample;

class Program
{
   static void Main()
   {
      Person person = new Person(...);
      int maxBytesNeeded = Person.Serializer.GetMaxSize(person);
      byte[] buffer = new byte[maxBytesNeeded];
      int bytesWritten = Person.Serializer.Serialize(buffer, person);
   
      Person p = Person.Serializer.Parse(data);      
   }
}

return;