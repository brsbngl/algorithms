/*
 SÖZDE KOD

 1- Başla
 2- 10 elemanlı bir masa dizisi oluştur.
 3- Kullanıcıdan olay sayısı al
 4- Kullanıcıdan olayları al
 5- Olayları oku
 5.1- Eğer karakter "L" ise soldan başlayarak ilk boş(0) yer bul ve doldur(1).
 5.2- Eğer karakter "R" ise sağdan başlayarak ilk boş(0) yer bul ve doldur(1).
 5.3- Eğer karakter bir rakam ise dizinin o indexini boş(0) yap.
 6- Dizinin son halini yazdır.
 7- Bitir
 */

int[] tables = new int[10];

Console.WriteLine("Olay sayısını giriniz: ");
int eventCount = int.Parse(Console.ReadLine());

Console.WriteLine("Olayları giriniz: ");
string events = Console.ReadLine();

//LLRR5LR819
/*
 0, 0, 0, 0, 0, 0, 0, 0, 0, 0

 1  0  1        0     1   0  0
 */
foreach (char e in events)
{
    if (e == 'L')
    {
        for (int i = 0; i < tables.Length; i++)
        {
            if (tables[i] == 0)
            {
                tables[i] = 1;
                break;
            }

        }

    }
    else if (e == 'R')
    {
        for (int i = 9; i >= 0; i--)
        {
            if (tables[i] == 0)
            {
                tables[i] = 1;
                break;
            }
        }
    }
    else if (char.IsDigit(e))
    {
        int tableIndex = e - '0';
        tables[tableIndex] = 0;
    }

}

foreach (int tableState in tables)
{
    Console.Write(tableState);
}
