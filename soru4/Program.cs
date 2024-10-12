namespace soru4;

class Program
{
    static void Main(string[] args)
    {
        int[] sayilar=new int[100];
 string[] cıktı = new string[100];
 int counter = 0;
 string mesaj = "Tekrar eden indexler";
 Random random = new Random();

 for(int i = 0; i < sayilar.Length; i++)
 {
     sayilar[i] = random.Next(1, 101);
 }

 for(int i = 0;i < sayilar.Length; i++)
 {
     string indexMesajı = $"{sayilar[i]} sayısı tekrar eden indexleri: ";
     for(int j = 0; j<sayilar.Length; j++)
     {
         if (sayilar[i] == sayilar[j]) {
             indexMesajı += j + ",";
         }
     }
        cıktı[i]=indexMesajı;

 }
 foreach (var item in cıktı.Distinct())
 {
     Console.WriteLine(item);
 };
    }
}
