# IMDB Film Listesi Uygulaması

Bu C# konsol uygulaması, kullanıcıların film bilgilerini girmelerine ve bu bilgileri çeşitli şekillerde listelemelerine olanak tanır.

## Özellikler

- Kullanıcıdan sınırsız sayıda film adı ve IMDB puanı girişi alabilme
- Girilen tüm filmleri listeleme
- IMDB puanı 4 ile 9 arasında olan filmleri filtreleme ve listeleme
- İsmi 'A' harfi ile başlayan filmleri filtreleme ve listeleme

## Nasıl Kullanılır

1. Uygulamayı çalıştırın.
2. İstendiğinde film adını girin.
3. Film için IMDB puanını girin (ondalık sayı olarak, örneğin 7,5).
4. Yeni bir film eklemek isteyip istemediğinizi belirtin (E/H).
5. Film eklemeyi bitirdiğinizde, uygulama otomatik olarak üç farklı liste gösterecektir:
   - Tüm filmler
   - IMDB puanı 4 ile 9 arasında olan filmler
   - İsmi 'A' ile başlayan filmler

## Proje Yapısı

Proje iki ana dosyadan oluşur:

1. `Film.cs`: Film sınıfının tanımlandığı dosya.
2. `Program.cs`: Ana program mantığının bulunduğu dosya.
