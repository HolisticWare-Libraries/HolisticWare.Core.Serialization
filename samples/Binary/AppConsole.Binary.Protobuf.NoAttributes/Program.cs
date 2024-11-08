/*
 
 */
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    public static void Main()
    {
        // Define the message structure using a dictionary
        var message = new Dictionary<int, object>
        {
            { 1, "John Doe" },
            { 2, 30 },
            { 3, 123456789L }
        };

        // Serialize the message
        byte[] serializedMessage = Serialize(message);

        // Deserialize the message
        var deserializedMessage = Deserialize(serializedMessage);

        // Display the deserialized message
        foreach (var kvp in deserializedMessage)
        {
            Console.WriteLine($"Tag: {kvp.Key}, Value: {kvp.Value}");
        }
    }

    public static byte[] Serialize(Dictionary<int, object> message)
    {
        using (var stream = new MemoryStream())
        {
            var output = new CodedOutputStream(stream);

            foreach (var kvp in message)
            {
                switch (kvp.Value)
                {
                    case string str:
                        output.WriteTag(kvp.Key, WireFormat.WireType.LengthDelimited);
                        output.WriteString(str);
                        break;
                    case int intValue:
                        output.WriteTag(kvp.Key, WireFormat.WireType.Varint);
                        output.WriteInt32(intValue);
                        break;
                    case long longValue:
                        output.WriteTag(kvp.Key, WireFormat.WireType.Varint);
                        output.WriteInt64(longValue);
                        break;
                }
            }

            output.Flush();
            return stream.ToArray();
        }
    }

    public static Dictionary<int, object> Deserialize(byte[] data)
    {
        var message = new Dictionary<int, object>();
        var input = new CodedInputStream(data);

        while (!input.IsAtEnd)
        {
            uint tag = input.ReadTag();
            int fieldNumber = WireFormat.GetTagFieldNumber(tag);
            WireFormat.WireType wireType = WireFormat.GetTagWireType(tag);

            switch (wireType)
            {
                case WireFormat.WireType.LengthDelimited:
                    message[fieldNumber] = input.ReadString();
                    break;
                case WireFormat.WireType.Varint:
                    message[fieldNumber] = input.ReadInt64();
                    break;
            }
        }

        return message;
    }
}

