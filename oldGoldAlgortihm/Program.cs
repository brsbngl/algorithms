/*
 In the dusty valleys of Elderglen, there lived an old gold miner named Grizzlebeard. 
For more than half a century, with nothing but a rusty pickaxe, a squeaky cart, and an extraordinary knack for sensing gold,
he worked the land. Grizzlebeard wasn’t wealthy, but he was wise — and persistent. Every day, from sunrise to sunset, 
he entered the mines and returned with a mixture of shimmering gold and worthless rocks.

The Old Gold Miner spent all day digging for gold and rocks. He wanted to take the gold home and leave the rocks behind. 
To organize his finds, he placed the rocks into ordered piles. However, by mistake, 
he also placed the gold into the piles along with the rocks. Now, the miner has to collect all the gold from these piles,
but due to his old age, he can’t remember which pile he placed each piece of gold in. 
He only remembers the order in which he found the gold. Help the miner by telling him which pile contains each piece of gold.

Input Format

The first line contains a single integer n, the number of piles.

The second line contains n integers a₁, a₂, …, aₙ, where aᵢ is the number of pieces (gold + rock) in the i-th pile.

The third line contains a single integer m, the number of gold pieces the miner is interested in.

The fourth line contains m integers q₁, q₂, …, qₘ, which are the labels of the gold pieces.

Constraints

1 ≤ n ≤ 10⁵

1 ≤ aᵢ ≤ 10³, a₁ + a₂ + … + aₙ ≤ 10⁶

1 ≤ m ≤ 10⁵

1 ≤ qᵢ ≤ a₁ + a₂ + … + aₙ

Output Format

For each gold piece label qᵢ, print a single line containing the 1-based index of the pile that contains that gold piece.
 */

/* SÖZDE KOD
 
 1- Başla
 2- Kullanıcıdan yığın sayısı al
 3- Her yığında kaç parça olduğunu al
 4- Kullanıcıdan altın sayısını al
 5- Altınların bulunduğu sırayı al
 6- Altınların yığınlarını yazdır
 7- Bitir
 
 */

Console.WriteLine("Yığın sayısı giriniz: ");
int pilesCount = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Yığınlardaki parça sayısını giriniz: ");
int[] piles = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

Console.WriteLine("Toplam altın sayısını giriniz: ");
int goldCount = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Altınların bulunduğu sırayı giriniz: ");
int[] goldOrders = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

int[] pilesTotal = new int[pilesCount];
// 3, 7, 2, 9, 4, 6 yığınlarda bulunan parça sayısı (taş altın karışık)
// ALTIN SIRASI = 1,11,28,31 (AŞAĞIDA PARANTEZ İÇİNE ALINANLAR ALTINI TEMSİL EDİYOR)
// [(1),2,3] - [4,5,6,7,8,9,10] - [(11),12] [13,14,15...21] - [22,23,24,25] - [26,27,(28),29,30,(31)]
pilesTotal[0] = piles[0];

for (int i = 1; i < pilesCount; i++)
{
    pilesTotal[i] = pilesTotal[i - 1] + piles[i];
}
foreach (int gold in goldOrders)
{
    for (int i = 0; i < pilesCount; i++)
    {
        if ( gold <= pilesTotal[i])
        {
            //Console.WriteLine("Altınların bulunduğu yığınlar: ");
            Console.Write(i+1+" ");
            break;
        }
    }
}