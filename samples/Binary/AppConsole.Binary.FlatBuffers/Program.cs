/*
please provide code sample in C# for
   FlatBuffers
serialization and deserialization

*/

using System;
using Google.FlatBuffers;
using MyGame.Sample;

class Program
{
   static void Main()
   {
      /*
      // Create a FlatBufferBuilder
      var builder = new FlatBufferBuilder(1024);

      // Create some weapons for our Monster ('Sword' and 'Axe')
      var weapon1Name = builder.CreateString("Sword");
      var weapon2Name = builder.CreateString("Axe");
      var sword = Weapon.CreateWeapon(builder, weapon1Name, 3);
      var axe = Weapon.CreateWeapon(builder, weapon2Name, 5);

      // Serialize the FlatBuffer data
      var name = builder.CreateString("Orc");
      var inventory = Monster.CreateInventoryVector(builder, new byte[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 });
      var weapons = Monster.CreateWeaponsVector(builder, new Offset<Weapon>[] { sword, axe });
      var pos = Vec3.CreateVec3(builder, 1.0f, 2.0f, 3.0f);

      Monster.StartMonster(builder);
      Monster.AddPos(builder, pos);
      Monster.AddHp(builder, 300);
      Monster.AddName(builder, name);
      Monster.AddInventory(builder, inventory);
      Monster.AddColor(builder, Color.Red);
      Monster.AddWeapons(builder, weapons);
      var orc = Monster.EndMonster(builder);

      builder.Finish(orc.Value); // You could also call `Monster.FinishMonsterBuffer(builder, orc);`

      // Get the byte array from the builder
      var data = builder.SizedByteArray();

      // Deserialize the data
      var bb = new ByteBuffer(data);
      var monster = Monster.GetRootAsMonster(bb);

      // Access the data
      Console.WriteLine($"Monster Name: {monster.Name}");
      Console.WriteLine($"Monster HP: {monster.Hp}");
      Console.WriteLine($"Monster Color: {monster.Color}");
      */
   }
}

return;