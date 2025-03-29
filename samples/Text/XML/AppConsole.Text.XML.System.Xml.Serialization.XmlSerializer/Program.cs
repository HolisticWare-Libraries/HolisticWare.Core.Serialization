/*
please provide code sample in C# for
   System.Xml.Serialization.XmlSerializer
serialization and deserialization

*/

using Maven.POM.ProjectObjectModel;

class Program
{
   static void Main()
   {
      // Example usage
      Project project = new Project
      {
         ModelVersion = "4.0.0",
         GroupId = "com.google.android.libraries.identity.googleid",
         ArtifactId = "googleid",
         Version = "1.1.1",
         Packaging = "aar",
         Dependencies = new Dependency[]
         {
            new Dependency
            {
               GroupId = "androidx.credentials",
               ArtifactId = "credentials",
               Version = "1.3.0-beta01",
               Scope = "compile",
               Type = "aar"
            },
            new Dependency
            {
               GroupId = "org.jetbrains.kotlin",
               ArtifactId = "kotlin-stdlib",
               Version = "1.8.0",
               Scope = "compile",
               Type = "jar"
            },
            new Dependency
            {
               GroupId = "org.jetbrains.kotlin",
               ArtifactId = "kotlin-stdlib-jdk8",
               Version = "1.8.0",
               Scope = "compile",
               Type = "jar"
            }
         },
         Name = "googleid",
         Licenses = new License[]
         {
            new License
            {
               Name = "Android Software Development Kit License",
               Url = "https://developer.android.com/studio/terms.html",
               Distribution = "repo"
            }
         }
      };

      string xml = XmlSerializationHelper.Serialize(project);
      Console.WriteLine("Serialized XML:");
      Console.WriteLine(xml);

      Project deserializedProject = XmlSerializationHelper.Deserialize(xml);
      Console.WriteLine("Deserialized Project Name:");
      Console.WriteLine(deserializedProject.Name);
   }
}