using System.Xml.Serialization;

namespace XmlSerialization
{
    public class Adres
    {
        [XmlAttribute ("Isim")]
        public string Baslik { get; set; }

        [XmlElement("KapiNo")]
        public string KapiNumarasi { get; set; }
        public string Satir1 { get; set; }
        public string Sehir { get; set; }

    }
}
