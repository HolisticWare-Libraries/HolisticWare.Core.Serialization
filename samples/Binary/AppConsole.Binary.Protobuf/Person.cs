using ProtoBuf;
using System;
using System.IO;

namespace AppConsole.Protobuf;

[ProtoContract]
public class Person
{
    [ProtoMember(1)]
    public int Id { get; set; }

    [ProtoMember(2)]
    public string Name { get; set; }

    [ProtoMember(3)]
    public string Email { get; set; }
}
