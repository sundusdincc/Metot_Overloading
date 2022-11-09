internal class Program
{
    
    private static void Main(string[] args)
    {
        //out parametreler
        //example 1
        Area(out int length, out int width, out int Rarea);

        // Display the value length, width, and Rarea
        System.Console.WriteLine("Length of the rectangle is: " + length);
        System.Console.WriteLine("Width of the rectangle is: " + width);
        System.Console.WriteLine("Area of the rectangle is: " + Rarea);

        //example 2
        string sayi = "999";
        String a= "54";
        int outSayi;

        //example 3
        //int.TryParse:sayiyi int veri tipine çevrilip çevrilmediğini kontrol et eğer çevrildiyse sayiyi outSayi olarak geri döndür(method boole değer döndürür)
        bool sonuc = int.TryParse(sayi, out outSayi);//outSayi=999 
        if (sonuc)
        {
            Console.WriteLine("Başarılı!");
            Console.WriteLine(outSayi);
        }
        else
        {
            Console.WriteLine("Başarısız!");
        }
         
        Console.WriteLine(sayi.GetType()+"/ "+outSayi.GetType()+"/ "+outSayi);
        Console.WriteLine(int.TryParse(a, out outSayi));

        //example 4
        metotlar ins=new metotlar();
        ins.Topla(90,80,out int OrtalamaSonucu);
        Console.WriteLine(OrtalamaSonucu);


        //metot aşırı yükleme-overloading
        //By changing the Number of Parameters 
        Program inst= new Program();
        int sum1 = inst.Add(1, 2);
        Console.WriteLine("sum of the two "
                          + "integer value : " + sum1);
 
        int sum2 = inst.Add(1, 2, 3);
        Console.WriteLine("sum of the three "
                          + "integer value : " + sum2);
        
        //By changing the Data types of the parameters
        double sum3 = inst.Add(1.0, 2.0, 3.0);
        Console.WriteLine("sum of the three "
                          + "double value : " + sum3);

        //By changing the Order of the parameters
        inst.Identity("Akku", 1);
        inst.Identity(2, "Abby");



    }

    public static void Area(out int p, out int q, out int Rarea)
    {
        p = 30;
        q = 40;
        Rarea = p * q;
    }

    // adding two integer values.
    public int Add(int a, int b)
    {
        int sum = a + b;
        return sum;
    }
 
    // adding three integer values.
    public int Add(int a, int b, int c)
    {
        int sum = a + b + c;
        return sum;
    }
 
    // adding three double values.
    public double Add(double a,
                      double b, double c)
    {
        double sum = a + b + c;
        return sum;
    }

    public void Identity(String name, int id)
    {
 
        Console.WriteLine("Name1 : " + name + ", "
                        + "Id1 : " + id);
    }
     
    public void Identity(int id, String name)
    {
 
        Console.WriteLine("Name2 : " + name + ", "
                        + "Id2 : " + id);
    }
}

class metotlar
{
    public void Topla(int a, int b, out int OrtalamaSonucu)
    {
        OrtalamaSonucu=(a+b)/2;
    }
}