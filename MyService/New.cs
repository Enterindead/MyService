﻿using System.Runtime.Serialization;
using System;

namespace MyService
{
    [Serializable()]
    [DataContract]
    public class New
    {
        public int NewId { get; set; }
        
        [System.Xml.Serialization.XmlElement("title")]
        [DataMember]
        public string Title { get; set; }

        [System.Xml.Serialization.XmlElement("link")]
        [DataMember]
        public string Link { get; set; }

        [System.Xml.Serialization.XmlElement("description")]
        [DataMember]
        public string Description { get; set; }

        [System.Xml.Serialization.XmlElement("pubDate")]
        [DataMember]
        public String PubDate { get; set; }       

        [System.Xml.Serialization.XmlElement("enclosure")]
        [DataMember]
        public Enclosure Enclosure { get; set; }

        [System.Xml.Serialization.XmlElement("category")]
        [DataMember]
        public string Category { get; set; }
    }

    public class Enclosure
    {
        [System.Xml.Serialization.XmlAttribute("url")]
        public string Url { get; set; }

        [System.Xml.Serialization.XmlAttribute("length")]
        public int Length { get; set; }

        [System.Xml.Serialization.XmlAttribute("type")]
        public string Type { get; set; }
    }
}