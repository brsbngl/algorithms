//Girdiğimiz iki kelimenin anagram olup olmadığını anlayan algoritma.

/* SÖZDE KOD

 1- Başla
 2- Kullanıcıdan ard ard iki kelime al.
 3- Eğer iki kelimenin uzunluğu eşit değilse, anagram değildir yaz ve bitir.
 4- Her iki kelimeyi karakter dizisine ata.
 5- Her iki karakter dizisini sırala.
 6- Dizinin uzunluğu kadar döngü dön.
 6.1- Kelimelerin aynı indexlerini karşılaştır.
 6.2- Eğer herhangi bir index eşleşmiyorsa anagram değildir yaz ve bitir. 
 6.3- Tüm karakterler eşleşiyorsa anagramdır yazdır.
 7- Bitir
 */

Console.WriteLine("İlk kelimeyi giriniz: ");
string ilkKelime = Console.ReadLine();

Console.WriteLine("İkinci kelimeyi giriniz: ");
string ikinciKelime = Console.ReadLine();

if (ilkKelime.Length != ikinciKelime.Length)
{
    Console.WriteLine("Girdiğiniz kelimeler anagram değildir");
    return;
}

char[] diziBir = ilkKelime.ToCharArray();

char[] diziİki = ikinciKelime.ToCharArray();

Array.Sort(diziBir);
Array.Sort(diziİki);

for (int i = 0; i < diziBir.Length; i++)
{
    if (diziBir[i] != diziİki[i])
    {
        Console.WriteLine("Girdiğiniz kelimeler anagram değildir");
        return;
    }
}

Console.WriteLine("Girdiğiniz kelimeler anagramdır.");



