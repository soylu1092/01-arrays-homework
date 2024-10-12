namespace soru6;

class Program
{
    static void Main(string[] args)
    {
        int[] sayilar=new int[100];
        Random random=new Random();
        int enb=0;
        int enk=0;
        for(int i=0;i<sayilar.Length;i++){
            sayilar[i]=random.Next(1,101);
            if(sayilar[i]>enb){
                enb=sayilar[i];
                
                
            }if(sayilar[i]<enk){
                sayilar[i]=enk;
            }

            
            
        }System.Console.WriteLine($"En büyük sayi:{enb}");
        System.Console.WriteLine($"En kücük sayi:{enk}");
        
        
    }
}
