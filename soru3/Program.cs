namespace soru3;

class Program
{
    static void Main(string[] args)
    {
        Array.ForEach(pozitifSayilar,i=>Console.Write(i+","));
int[] sayilar=new int[10];
        int negatifSayiAdeti=0;
        int pozitifSayiAdeti=0;
        Random random = new Random();
       for(int i=0;i<sayilar.Length;i++){
        sayilar[i]=random.Next(-5,6);
        if(sayilar[i]<0)
        negatifSayiAdeti++;
        if(sayilar[i]>=0)
        pozitifSayiAdeti++;

       }
       int[] pozitifSayilar = new int[pozitifSayiAdeti];
       int[] negatifSayilar= new int[negatifSayiAdeti];
       negatifSayiAdeti=0;
       pozitifSayiAdeti=0;
       for(int j=0;j<sayilar.Length;j++)
       {

        if(sayilar[j]<0){
        negatifSayilar[negatifSayiAdeti]=sayilar[j];
        negatifSayiAdeti++;
        }else{
            pozitifSayilar[pozitifSayiAdeti]=sayilar[j];
            pozitifSayiAdeti++;
        }

       }

        Console.Write("Tüm Sayılar");

        foreach (int i in sayilar){
        Console.Write(i+",");
       }
        Console.WriteLine();
        Console.Write("Negatif Sayılar");

        foreach (int i in negatifSayilar){
        Console.Write(i+",");
       }
        Console.WriteLine();
        Console.Write("Pozitif Sayılar");

        Array.ForEach(pozitifSayilar,i=>Console.Write(i+","));
        Console.WriteLine();
    }
}
