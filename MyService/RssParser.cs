using System;
using System.Xml.Serialization;
using System.IO;

namespace MyService
{
    [Serializable()]
    [System.Xml.Serialization.XmlRoot("rss")]
    public class NewsCollection
    {
        [XmlArray("channel")]
        [XmlArrayItem("item", typeof(New))]
        public New[] New { get; set; }
    }

    public static class NewsSerializer
    {
        public static NewsCollection Deserialize()
        {
            NewsCollection news = null;
            string path = "C:/Users/Arest/Dropbox/Projects/MyService/MyService/rss.xml";

            XmlSerializer serializer = new XmlSerializer(typeof(NewsCollection));

            StreamReader reader = new StreamReader(path);
            news = (NewsCollection)serializer.Deserialize(reader);
            reader.Close();
            return news;
        }
    }
}