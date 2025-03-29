/*
please provide code sample in C# for
   StackXml
serialization and deserialization

*/

using AppConsole.Text.XML.Benchmarks;
using BenchmarkDotNet.Reports;
using BenchmarkDotNet.Running;

public class Program
{
   public static void Main(string[] args)
   {
      Summary summary_XML = BenchmarkRunner.Run<Benchmarks_XML>();
   }
}