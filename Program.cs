namespace Array_sinifi_ve_methodlari;

class Program
{
    static void Main(string[] args)
    {
        // sort  yani sıralma işlemi
        int[] sayidizisi = {23, 12, 4, 86, 72, 3, 11, 17};   // 7 elemanlı maximum 8. indexi olan dizi tanımladım
        Console.WriteLine("***************SIRASIZ LİSTE**********************");
        foreach (var sayi in sayidizisi)
        Console.WriteLine(sayi);              // konsola sayidizisi adındaki diziden sayi konsola yazdıracağım. sayız dizisindeki sıra nasılsa öyle çıktı verecek. herhangi bir sıralama yapmayacak.
        
        Console.WriteLine("***************SIRALI LİSTE***********************");
        Array.Sort(sayidizisi);
        foreach (var sayi in sayidizisi)
        Console.WriteLine(sayi);           // çıktı= küçükten büyüğe sıralı şelikde çıktı verdi 3,4,11,12,17,23,72,86

        //CLEAR   (verdiğiniz eleman sayısı kadar değeri sıfırlıyor. direkt gidip dizinin o elemanına 0 atıyor)
        Console.WriteLine("***************ARRAY CLEAR***********************");
        Array.Clear(sayidizisi,2,2);   // burada yazdığımız dizinin 2. indexten başlayarak, 2 adet elemanı clear et dedk.
        foreach (var sayi in sayidizisi)
        Console.WriteLine(sayi);    // çıktı=3,4,0,0,17,23,72,86
        //REVERSE   tersine çevirme işlemi.  aynalama yapar gibi ilk elemanı son eleman yapıyor. son elemanı ilk eleman yapıyor.
        Console.WriteLine("***************ARRAY REVERSE***********************");
        Array.Reverse(sayidizisi);
        foreach (var sayi in sayidizisi)
        Console.WriteLine(sayi);   // ÇIKTI= 86,72,23,17,12,11,4,3 verdi,  eski hali: 3,4,11,12,17,23,72,86

        //indexof   verdiğniz dizi üzerinden verdiğiniz elemanın eğer varsa indexini döner

        Console.WriteLine("*************** ARRAY İNDEXOF***********************");
        Array.IndexOf(sayidizisi,23);   //sayı dizisi içinde 23 sayısı kaçıncı indexte diye sorduk
        Console.WriteLine(Array.IndexOf(sayidizisi,23));  //ÇIKTI= 2   23 sayısı 2. indexte

        //RESİZE  Yeniden boyutlandırma
        Console.WriteLine("***************ARRAY RESİZE***********************");
        Array.Resize<int>(ref sayidizisi, 9); // <bunun çine yazdığım şey array'in tipini veriyorum>  .ref referans olarak sayidizisini aldım. integer tipindeki sayi dizisinin boyutunu  git 9 yap. normalde bizimki 8 elamanlı
        sayidizisi[8] = 99;   // sayidizisinin 8 . elemanını 99 yap
        foreach (var sayi in sayidizisi)
        Console.WriteLine(sayi);
        
    }
}
