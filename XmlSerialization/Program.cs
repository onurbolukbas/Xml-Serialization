using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace XmlSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Siparis siparis = new Siparis();
            Adres adres = new Adres();
            Odeme odeme = new Odeme();
            List<Urun> urunler = new List<Urun>();
            int ToplamUrunFiyat = 0;

            urunler.Add(new Urun
            {
                UrunIsmi = "Pizza",
                Aciklama = "Orta Boy",
                Adet = 2,
                BirimFiyat = 15
            });

            urunler.Add(new Urun
            {
                UrunIsmi = "Hamburger",
                Aciklama = "Buyuk Boy Patates",
                Adet = 3,
                BirimFiyat = 6
            });
            foreach (var urun in urunler)
            {
                urun.Hesapla();
                ToplamUrunFiyat += urun.AraToplam;
            }

            adres.Baslik = "Ev Adresim";
            adres.Satir1 = "Kodla Sokak, Objeler Caddesi";
            adres.Sehir = "Istanbul";
            adres.KapiNumarasi = "10";

            odeme.OdemeTuru = "Nakit";
            odeme.OdemeYeri = "Kapida";

            siparis.Adres = adres;
            siparis.Odeme = odeme;
            siparis.Urunler = urunler;
            siparis.SiparisTarih = DateTime.Now.ToString("MMMM dd, yyyy");

            siparis.AraToplam = ToplamUrunFiyat;
            siparis.EkUcret = 5;
            siparis.Hesapla();

            XmlSerializer xmlBodySerializer = new XmlSerializer(typeof(Siparis));
            var stringWriter = new StringWriter();
            xmlBodySerializer.Serialize(stringWriter, siparis);
            string xmlBodyContent = stringWriter.ToString();
            Console.WriteLine(xmlBodyContent);
        }
    }
}
