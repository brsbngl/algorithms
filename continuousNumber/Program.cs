/*
 Kullanıcıdan sürekli olarak sayı girmesini isteyin. Kullanıcı negatif bir sayı girdiğinde,
 döngüyü sonlandırın . Girilen tek sayıları atlayın ve sadece çift sayıları ekrana yazdırın
 */

/*SÖZDE KOD
 
    1- Başla
    2- Sonsuz bir döngü başlat
    3- Kullanıcıdan bir sayı girmesini iste
    3.1- Eğer sayı negatifse bitir 
    3.2- Eğer sayı tek ise continue ile turu atla
    3.3- Eğer çift ise sayıyı yazdır
    4- Bitir

*/

while (true)
{
    Console.WriteLine("Bir sayı giriniz: ");
    int sayi = int.Parse(Console.ReadLine());

    if (sayi < 0)
    {
        Console.WriteLine("Negatif bir sayı girdiniz, döngüden çıkıldı");
        break;
    }
    if (sayi % 2 != 0) continue;

    Console.WriteLine($"Çift sayı: {sayi}");
}

