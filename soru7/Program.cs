namespace soru7;

class Program
{
    static void Main(string[] args)
    {
        int[] sayilar=new int[50];
        int[] sayilar1=new int[50];
        int toplamcift=0;
        Random random=new Random();
        for(int i=0;i<sayilar.Length;i++){
            sayilar[i]=random.Next(1,51);
            
            if(sayilar[i]%2==0){
                
                toplamcift+=sayilar[i];
                
                
                
            }
        }System.Console.WriteLine(toplamcift);
    }
}
