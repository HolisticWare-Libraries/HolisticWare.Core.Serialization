using System;
using System.IO;
using System.Xml.Serialization;

namespace Maven.POM.ProjectObjectModel.System.Xml.Serialization
{
    [XmlRoot("project", Namespace = "http://maven.apache.org/POM/4.0.0")]
    public class Project
    {
        [XmlElement("modelVersion")]
        public string ModelVersion { get; set; }

        [XmlElement("groupId")]
        public string GroupId { get; set; }

        [XmlElement("artifactId")]
        public string ArtifactId { get; set; }

        [XmlElement("version")]
        public string Version { get; set; }

        [XmlElement("packaging")]
        public string Packaging { get; set; }

        [XmlArray("dependencies")]
        [XmlArrayItem("dependency")]
        public Dependency[] Dependencies { get; set; }

        [XmlElement("name")]
        public string Name { get; set; }

        [XmlArray("licenses")]
        [XmlArrayItem("license")]
        public License[] Licenses { get; set; }
    }

    public class Dependency
    {
        [XmlElement("groupId")]
        public string GroupId { get; set; }

        [XmlElement("artifactId")]
        public string ArtifactId { get; set; }

        [XmlElement("version")]
        public string Version { get; set; }

        [XmlElement("scope")]
        public string Scope { get; set; }

        [XmlElement("type")]
        public string Type { get; set; }
    }

    public class License
    {
        [XmlElement("name")]
        public string Name { get; set; }

        [XmlElement("url")]
        public string Url { get; set; }

        [XmlElement("distribution")]
        public string Distribution { get; set; }
    }

    public class XmlSerializationHelper
    {
        public static string Serialize(Project project)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Project));
            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, project);
                return writer.ToString();
            }
        }

        public static Project Deserialize(string xml)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Project));
            using (StringReader reader = new StringReader(xml))
            {
                return (Project)serializer.Deserialize(reader);
            }
        }
    }
}