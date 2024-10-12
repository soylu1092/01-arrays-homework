namespace soru5;

class Program
{
    static void Main(string[] args)
    {
        int[] sayilar=new int[100];
        Random random =new Random();
        int counter=0;
        System.Console.WriteLine("lütfen bir sayi giriniz.");
        string sayi1=Console.ReadLine();
        int sayi2=Convert.ToInt32(sayi1);
        for (int i = 0; i < sayilar.Length; i++)
        {
            sayilar[i]=random.Next(1,101);
            counter++;
            
            if(sayilar[i]==sayi2){
                System.Console.WriteLine($"{counter}. sayi:{sayilar[i]}==girdiğiniz sayi:{sayi2}");
            }
        }
    }
}
