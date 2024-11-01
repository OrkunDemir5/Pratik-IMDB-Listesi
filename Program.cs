
using Pratik_IMDB_Listesi;

List<Film> filmler = new List<Film>();

while (true)
{
    // Kullanıcıdan film ismi ve imdb puanı alınıyor
    Console.Write("Film ismi giriniz: ");
    string filmIsmi = Console.ReadLine();

    Console.Write("Imdb puanını giriniz: ");
    double imdbPuani;
    while (!double.TryParse(Console.ReadLine(), out imdbPuani))
    {
        Console.WriteLine("Geçerli bir imdb puanı giriniz.");
    }

    // Alınan bilgilerle film nesnesi oluşturulup listeye ekleniyor
    filmler.Add(new Film(imdbPuani, filmIsmi));

    // Yeni film eklemek isteyip istemediğini soruyoruz
    Console.Write("Yeni bir film eklemek istiyor musunuz? (evet/hayir): ");
    string cevap = Console.ReadLine().ToLower();
    if (cevap != "evet")
        break;
}

Console.WriteLine("--- Tüm Filmler --- ");

// Tüm filmleri listeliyoruz
foreach (var film in filmler)
{
    Console.WriteLine($"Film Adı: {film.Isim}, Imdb Puanı: {film.ImdbPuani}");
}

Console.WriteLine("\n--- Imdb Puanı 4 ile 9 Arasında Olan Filmler ---");
// Imdb puanı 4 ile 9 arasında olan filmleri listeleme
foreach (var film in filmler)
{
    if (film.ImdbPuani >= 4 && film.ImdbPuani <= 9)
    {
        Console.WriteLine($"Film Adı: {film.Isim}, Imdb Puanı: {film.ImdbPuani}");
    }
}

Console.WriteLine("--- 'A' Harfi ile Başlayan Filmler: ---");
// İsmi 'A' ile başlayan filmleri listeleme
foreach (var film in filmler)
{
    if (film.Isim.StartsWith("A", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine($"Film Adı: {film.Isim}, Imdb Puanı: {film.ImdbPuani}");
    }
}

Console.WriteLine("Program sona erdi. Çıkmak için bir tuşa basın...");
Console.ReadKey();