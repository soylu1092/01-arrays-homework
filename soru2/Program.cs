namespace soru2;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("1. sayiyi lütfen giriniz.");
        string sayi1=Console.ReadLine();
        int sayi2=Convert.ToInt32(sayi1);
        System.Console.WriteLine("2. sayiyi lütfen giriniz.");
        string sayi3=Console.ReadLine();
        int sayi4=Convert.ToInt32(sayi3);
        System.Console.WriteLine("3. sayiyi lütfen giriniz.");
        string sayi5=Console.ReadLine();
        int sayi6=Convert.ToInt32(sayi5);
        System.Console.WriteLine("4. sayiyi lütfen giriniz.");
        string sayi7=Console.ReadLine();
        int sayi8=Convert.ToInt32(sayi7);
        System.Console.WriteLine("5. sayiyi lütfen giriniz.");
        string sayi9=Console.ReadLine();
        int sayi10=Convert.ToInt32(sayi9);
        System.Console.WriteLine("6. sayiyi lütfen giriniz.");
        string sayi11=Console.ReadLine();
        int sayi12=Convert.ToInt32(sayi11);
        System.Console.WriteLine("7. sayiyi lütfen giriniz.");
        string sayi13=Console.ReadLine();
        int sayi14=Convert.ToInt32(sayi13);
        System.Console.WriteLine("8. sayiyi lütfen giriniz.");
        string sayi15=Console.ReadLine();
        int sayi16=Convert.ToInt32(sayi15);
        System.Console.WriteLine("9. sayiyi lütfen giriniz.");
        string sayi17=Console.ReadLine();
        int sayi18=Convert.ToInt32(sayi17);
        System.Console.WriteLine("10. sayiyi lütfen giriniz.");
        string sayi19=Console.ReadLine();
        int sayi20=Convert.ToInt32(sayi19);
        

        int[] sayilar=new int[]{sayi2,sayi4,sayi6,sayi8,sayi10,sayi12,sayi14,sayi16,sayi18,sayi20};
        int[] sayilar1=new int[10];
        
        for (int i = 0; i < sayilar.Length; i++)
        {
           if(sayilar[i]%2==0){
            
            
            
            Array.Copy(sayilar,sayilar1,10);
            System.Console.WriteLine(sayilar1[i]);
            Array.Sort(sayilar1);
            
            
           }
        }
        
        
        
        

        
    }
}
