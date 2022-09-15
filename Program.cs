using System;

public class Osztaly
{
    public static int valami = 0;
    public Osztaly()
    {
        valami++;
        Console.WriteLine("Az objektumok száma: {0}",valami);
    }
    ~Osztaly()
    {
        valami--;
        Console.WriteLine("Az objektumok száma: {0}", valami);
    }
   
}
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Osztaly Obj = new Osztaly();
        }
    }
}
