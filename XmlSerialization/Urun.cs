using System.Xml.Serialization;

namespace XmlSerialization
{
    public class Urun
    {
        [XmlElement(ElementName = "Isim")]
        public string UrunIsmi { get; set; }
        public string Aciklama { get; set; }
        public int Adet{ get; set; }
        public int BirimFiyat { get; set; }

        [XmlIgnore]
        public int AraToplam { get; set; }

        public void Hesapla()
        {
            AraToplam = BirimFiyat * Adet;
        }
    }
}
