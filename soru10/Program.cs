namespace soru10;

class Program
{
    static void Main(string[] args)
    {
        int[] sayilar={1,2,3,4,5,6,7,8,9,10};
        int[] sayilar1=sayilar;
        Array.Copy(sayilar,sayilar1,10);
        for(int i=0;i<sayilar.Length;i++){
            System.Console.WriteLine(sayilar[i]);
        }
        System.Console.WriteLine("-------------------------------------------");
        Array.Reverse(sayilar1);
        for(int i=0;i<sayilar1.Length;i++){
            System.Console.WriteLine(sayilar1[i]);
            
        }
            
            
        
    }
}
