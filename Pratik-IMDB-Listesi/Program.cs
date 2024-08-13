using Pratik_IMDB_Listesi;
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Film listesini oluştur
        List<Film> filmListesi = new List<Film>();

        // Kullanıcıdan film bilgilerini al
        while (true)
        {
            // Film adını al
            Console.Write("Film adını girin: ");
            string filmAdi = Console.ReadLine();

            // IMDB puanını al ve geçerli bir sayı olduğundan emin ol
            Console.Write("IMDB puanını girin: ");
            double imdbPuani;
            while (!double.TryParse(Console.ReadLine(), out imdbPuani))
            {
                Console.Write("Geçersiz puan. Lütfen sayısal bir değer girin: ");
            }

            // Yeni film nesnesini oluştur ve listeye ekle
            filmListesi.Add(new Film(filmAdi, imdbPuani));

            // Kullanıcıya devam etmek isteyip istemediğini sor
            Console.Write("Başka film eklemek istiyor musunuz? (E/H): ");
            if (Console.ReadLine().Trim().ToUpper() != "E")
                break;
        }

        // 1. Bütün filmleri listele
        Console.WriteLine("\n1. Bütün filmler:");
        foreach (var film in filmListesi)
        {
            Console.WriteLine($"Film: {film.Isim}, IMDB Puanı: {film.ImdbPuani}");
        }

        // 2. IMDB puanı 4 ile 9 arasında olan filmleri listele
        Console.WriteLine("\n2. IMDB puanı 4 ile 9 arasında olan filmler:");
        var filtrelenmisListe = filmListesi.Where(f => f.ImdbPuani >= 4 && f.ImdbPuani <= 9);
        foreach (var film in filtrelenmisListe)
        {
            Console.WriteLine($"Film: {film.Isim}, IMDB Puanı: {film.ImdbPuani}");
        }

        // 3. 'A' ile başlayan filmleri listele
        Console.WriteLine("\n3. 'A' ile başlayan filmler:");
        var aIleBaslayanlar = filmListesi.Where(f => f.Isim.StartsWith("A", StringComparison.OrdinalIgnoreCase));
        foreach (var film in aIleBaslayanlar)
        {
            Console.WriteLine($"Film: {film.Isim}, IMDB Puanı: {film.ImdbPuani}");
        }
    }
}