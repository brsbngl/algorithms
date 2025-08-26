// Girilen dört basamaklı sayılardan ilk iki basamağı ile son iki basamağının toplamının karesi, sayının kendine eşit olan sayılara orijinal sayı denir.
//

/* Pseudo Code
 1.Basla
 2.kullanicidan 4 basamakli bir sayi al
 3.Sayinin ilk iki basamağını tutan ve son iki basamağını tutan değiskenler oluştur
 4.İki sayiyi hesapla
 4.1 son iki  basamağı sayinin 100 ile modunu alarak bul
 4.2 ilk iki basamağı bulmak için sayiyi 100 e böl
 5.Bu iki değeri topla
 6.Toplamın karesini al
 7.Sonuc sayiya eşitse orjinal sayidir
 7.1 sonuc sayiya eşit değilse orjinal sayi degildir.
 8.Bitir
*/

int n = int.Parse(Console.ReadLine());

bool hasFourDigits(int number)
{
    return number >= 1000 && number < 10000;
}

if (!hasFourDigits(n))
{
    Console.WriteLine("Please enter 4 digits number");
    return;
}

int firstTwo = n / 100;
int lastTwo = n % 100;
int total = firstTwo + lastTwo;
if (Math.Pow(total, 2) == n)
{
    Console.WriteLine("Number is Original");
}
else
{
    Console.WriteLine("Number is not Original");
}
