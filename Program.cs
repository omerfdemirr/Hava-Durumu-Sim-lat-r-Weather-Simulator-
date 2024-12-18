namespace Hava_Durumu_Simülatörü_Weather_Simulator_
{
    using System;

    namespace HavaDurumuSimulasyonu
    {
        class Program
        {
            static void Main()
            {
                Console.Clear();
                Console.WriteLine("=== Hava Durumu Simülatörü ===");
                Console.Write("Hava durumu tahmini almak istediğiniz şehir: ");
                string sehir = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(sehir))
                {
                    Console.WriteLine("Lütfen geçerli bir şehir adı girin.");
                    return;
                }

                Console.WriteLine("\nTahmin oluşturuluyor...\n");
                var havaDurumu = HavaDurumuUret();

                Console.WriteLine($"--- {sehir.ToUpper()} için Hava Durumu Tahmini ---");
                Console.WriteLine($"🌡️  Sıcaklık: {havaDurumu.Sicaklik} °C");
                Console.WriteLine($"💨  Rüzgar Hızı: {havaDurumu.RuzgarHizi} km/sa");
                Console.WriteLine($"☔  Yağış İhtimali: {havaDurumu.YagisIhtimali}%");
                Console.WriteLine($"🌥️  Genel Durum: {havaDurumu.GenelDurum}");
                Console.WriteLine($"📅 Tarih: {DateTime.Now.ToShortDateString()}");
                Console.WriteLine("\nKeyifli bir gün geçirmeniz dileğiyle! 🌈");
            }

            static HavaDurumu HavaDurumuUret()
            {
                Random rastgele = new Random();

                // Sıcaklık -10°C ile 40°C arasında rastgele oluşturuluyor
                int sicaklik = rastgele.Next(-10, 41);

                // Rüzgar hızı 0 ile 100 km/sa arasında rastgele oluşturuluyor
                int ruzgarHizi = rastgele.Next(0, 101);

                // Yağış ihtimali 0 ile 100% arasında rastgele oluşturuluyor
                int yagisIhtimali = rastgele.Next(0, 101);

                // Genel durum seçimi
                string[] durumlar = { "Güneşli", "Bulutlu", "Yağmurlu", "Karlı", "Fırtınalı" };
                string genelDurum = durumlar[rastgele.Next(durumlar.Length)];

                return new HavaDurumu
                {
                    Sicaklik = sicaklik,
                    RuzgarHizi = ruzgarHizi,
                    YagisIhtimali = yagisIhtimali,
                    GenelDurum = genelDurum
                };
            }

            class HavaDurumu
            {
                public int Sicaklik { get; set; }
                public int RuzgarHizi { get; set; }
                public int YagisIhtimali { get; set; }
                public string GenelDurum { get; set; }
            }
        }
    }

}
