namespace soru16;

class Program
{
    static void Main(string[] args)
    {
        
        System.Console.WriteLine("lüften bir sayi girin");
        int counter=0;
        int toplam=0;
        string sayi1=Console.ReadLine();
        int sayi2=Convert.ToInt32(sayi1);
        System.Console.WriteLine("lüften bir sayi girin");
        string sayi3=Console.ReadLine();
        int sayi4=Convert.ToInt32(sayi3);
        System.Console.WriteLine("lüften bir sayi girin");
        string sayi5=Console.ReadLine();
        int sayi6=Convert.ToInt32(sayi5);
        System.Console.WriteLine("lüften bir sayi girin");
        string sayi7=Console.ReadLine();
        int sayi8=Convert.ToInt32(sayi7);
        System.Console.WriteLine("lüften bir sayi girin");
        string sayi9=Console.ReadLine();
        int sayi10=Convert.ToInt32(sayi9);
        System.Console.WriteLine("lüften bir sayi girin");
        int[] sayilar=new int[5]{sayi2,sayi4,sayi6,sayi8,sayi10};
        for(int i=0;i<sayilar.Length;i++){
            counter++;
           if(sayilar[i]!=0){
            toplam+=sayilar[i];
            
           }else if(sayilar[i]==0){
            toplam+=sayilar[i];
           }
        }System.Console.WriteLine(toplam/5);


        // cok sağlıklı bir sonuç aldığımı düşünmüyorum hocam buna dailyde bakabilir miyiz
        
        
        
    }
}
