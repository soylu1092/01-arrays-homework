using System.Reflection.Emit;

namespace soru17;

class Program
{
    static void Main(string[] args)
    {
        int[] sayilar={400,23,32,54,62,34,78,97,68,150};
        int enb=sayilar[0];
        int enbb=sayilar[0];
        
        for(int i=0;i<sayilar.Length;i++){
            
           if(sayilar[i]>enb){
            enb=sayilar[i];
            
           }
           
            
        }System.Console.WriteLine(enb);
        Array.Clear(sayilar,0,1);
        int[] sayilar1=sayilar;
        for(int j=0;j<sayilar1.Length;j++){
            System.Console.WriteLine(sayilar1[j]);
            if(sayilar1[j]>enbb){
                enbb=sayilar1[j];
            }
        }System.Console.WriteLine(enbb);
        
        
        }
    }

