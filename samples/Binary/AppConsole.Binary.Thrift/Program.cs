/*
 please provide code sample in C# for
       thrift
   serialization and deserialization

https://thrift.apache.org/
https://github.com/apache/thrift

thrift --gen csharp Person.thrift

https://codealoc.wordpress.com/2012/05/09/thrift-msbuild-task/
https://github.com/marksl/thrift-msbuild-task
https://github.com/marksl/thrift-msbuild-task/blob/master/ThriftMSBuildTask/ThriftBuild.cs


https://github.com/adamconnelly/Thrift.Net
http://www.alternatestack.com/uncategorized/apache-thrift-and-its-usage-in-c/
https://www.markhneedham.com/blog/2008/08/29/c-thrift-examples/
https://headsigned.com/posts/csharp-apache-thrift-demo/

*/

using System;
using System.IO;
using Thrift.Protocol;
using Thrift.Transport;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Person object
            Person person = new Person
            {
                Name = "John Doe",
                Age = 30
            };

            // Serialize the Person object to a byte array
            byte[] serializedPerson;
            using (var memoryStream = new MemoryStream())
            {
                TTransport transport = new TStreamTransport(null, memoryStream);
                TProtocol protocol = new TBinaryProtocol(transport);
                person.Write(protocol);
                serializedPerson = memoryStream.ToArray();
            }

            Console.WriteLine("Serialized Person: " + BitConverter.ToString(serializedPerson));

            // Deserialize the byte array back to a Person object
            Person deserializedPerson;
            using (var memoryStream = new MemoryStream(serializedPerson))
            {
                TTransport transport = new TStreamTransport(memoryStream, null);
                TProtocol protocol = new TBinaryProtocol(transport);
                deserializedPerson = new Person();
                deserializedPerson.Read(protocol);
            }

            Console.WriteLine("Deserialized Person: Name = " + deserializedPerson.Name + ", Age = " + deserializedPerson.Age);
        }
    }
}
