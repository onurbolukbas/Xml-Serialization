using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace XmlSerialization
{
    [XmlRoot("Siparisim")]
    public class Siparis
    {
        public Adres Adres { get; set; }

        [XmlArray("Urunler")]
        public List<Urun> Urunler { get; set; }
        public Odeme Odeme { get; set; }

        [XmlElement(ElementName = "Tarih")]
        public string SiparisTarih{ get; set; }
        public int AraToplam{ get; set; }
        public int EkUcret { get; set; }
        public int ToplamFiyat { get; set; }

        public void Hesapla()
        {
            ToplamFiyat = AraToplam + EkUcret;
        }
    }
}
