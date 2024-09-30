/*
https://microsoft.github.io/bond/manual/bond_cs.html

https://github.com/Microsoft/bond/issues/335
*/
using System;
using Bond;
using Bond.IO.Safe;
using Bond.Protocols;

namespace Examples
{
    class Program
    {
        static void Main()
        {
            // Create an instance of the Record class
            var src = new Record
            {
                Name = "FooBar",
                Constants = { 3.14, 6.28 }
            };

            // Serialize the instance to a buffer
            var output = new OutputBuffer();
            var writer = new CompactBinaryWriter<OutputBuffer>(output);
            Serialize.To(writer, src);

            // Deserialize the instance from the buffer
            var input = new InputBuffer(output.Data);
            var reader = new CompactBinaryReader<InputBuffer>(input);
            var dst = Deserialize<Record>.From(reader);

            // Display the deserialized data
            Console.WriteLine($"Name: {dst.Name}");
            Console.WriteLine("Constants: " + string.Join(", ", dst.Constants));
        }
    }
}