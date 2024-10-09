// See https://aka.ms/new-console-template for more information

class urun
{
    public string name;
    public double price;
   public  int categorynum;

   
}


class Program
{
    static void show(urun a,urun b)
    {
        Console.WriteLine(a.price);
        Console.WriteLine(a.name);
        Console.WriteLine(a.categorynum);
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine(b.price);
        Console.WriteLine(b.name);
        Console.WriteLine(b.categorynum);

    }

    static void Main(string[] args)
    {
         
       //pc
        urun bilgisayar = new urun();
        bilgisayar.name = "PC";
        bilgisayar.price = 500;
        bilgisayar.categorynum = 0;

        //sehpa
        urun sehpa = new urun();
        sehpa.name = "sehpa";
        sehpa.price = 300;
        sehpa.categorynum = 1;


        show(sehpa,bilgisayar);
        
    }    
}

