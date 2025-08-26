
    /*
    1)Başla
    2)Kullanıcıdan bir sayı al
    3)Sayıyı geçici bir değişkene ata
    4)Toplamı 0 olarak başlat
    5)Geçici değişken sıfırdan büyük olduğu sürece:
        a)Geçici değişkenin son basamağını al
        b)Bu basamağın faktöriyelini hesapla
        c)Faktöriyeli toplama ekle
        d)Geçici değişkeni 10'a böl (son basamağı at)
    6)Eğer toplam, orijinal sayıya eşitse:
        a)Sayı güçlü sayıdır    
    7)Değilse:
        a)Sayı güçlü sayı değildir
    8)Bitir
    */

        Console.WriteLine("Bir sayı giriniz:");
        int number = int.Parse(Console.ReadLine());

        int temp = number;
        int sum = 0;

        while (temp > 0)
        {
            int digit = temp % 10;

            int faktorial = 1;
            for (int i = 1; i <= digit; i++)
            {
                faktorial *= i;
            }
            sum += faktorial;
            temp /= 10;
        }

        if (sum == number)
        {
            Console.WriteLine($"{number} sayısı bir güçlü sayıdır.");
        }
        else
        {
            Console.WriteLine($"{number} sayısı bir güçlü sayı değildir.");
        }
    
