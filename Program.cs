using System.Collections;


class Program 
{
    static void Main(string[] args)
    {
        //System.Collections namespace

        ArrayList Liste= new ArrayList();
        Liste.Add("Hakkı");
        Liste.Add(2);
        Liste.Add(true);
        Liste.Add('A');

        //Liste içerisindeki verilere erişim
        System.Console.WriteLine(Liste[1]);

        foreach (var item in Liste)
        {
            System.Console.WriteLine(item);            
        }

        //ARRAY LiST METOTLARI

        //AddRange

        System.Console.WriteLine("******** Add Range ********");
        string[] renkler = {"Kırmızı","Sarı","Siyah"};
        List<int> sayilar = new List<int>() {1,5,7,89,0};
        
        Liste.AddRange(renkler);
        Liste.AddRange(sayilar);

        foreach (var item in Liste)
        {
            System.Console.WriteLine(item);            
        }

        //Sort
        System.Console.WriteLine("******** Sort ********");
        Liste.Sort();// sıralarken dikkat etmemiz gerek listelerde farklı değerler tuttuğumuz için burada hata alırız.
        //Sıralayabilmesi için tiplerin aynı olması gerekli.


        //Binary Search
        System.Console.WriteLine("******** Binary Search ********");
        //Kullanmak için önce diziyi yada listeyi sıralamalı sonra bu metodu çalıştırmalıyız.

        Console.WriteLine(Liste.BinarySearch(7));

        //Reverse

        System.Console.WriteLine("******** Reverse ********");
        Liste.Reverse();
        foreach (var item in Liste)
        {
            System.Console.WriteLine(item);
        }

        //Clear
        System.Console.WriteLine("******** Clear ********");
        Liste.Clear();

        foreach (var item in Liste)
        {
            System.Console.WriteLine(item);
        }
    }
}