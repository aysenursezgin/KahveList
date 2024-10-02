// Kahve isimlerini tutacak bir liste oluşturma

        List<string> kahveListesi = new List<string>();

// Kullanıcıdan 5 kahve ismi alma

Console.WriteLine("Lütfen 5 kahve ismi girin:");

for (int i = 0; i < 5; i++)
{
    Console.Write($"Kahve {i + 1}: ");
    string kahve = Console.ReadLine();
    kahveListesi.Add(kahve);      // Listeye kahve ismini ekle
}


// Kahve isimlerini yazdırma

Console.WriteLine("\n Kahve Listesi:");
foreach (var kahve in kahveListesi)
{
    Console.WriteLine(kahve);
}