using System.Collections.Generic;
using System.Linq;
using System.Text;


public class aprendiendo
{
    static void Main(string[] args)
    {


        byte edad;
        Console.WriteLine("ingrese su edad");
        edad = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("usted no aparenta " + edad + "años");
        Console.WriteLine();

        byte num1, num2;
        ushort mult;
        Console.WriteLine("ingrese un numero");
        num1 = Convert.ToByte(Console.ReadLine());
        Console.WriteLine("ingrese un numero");
        num2 = Convert.ToByte(Console.ReadLine());
        mult = (ushort)(num1 * num2);
        Console.WriteLine("resultado de la multiplicacion: " + mult);
        Console.WriteLine();

    }


}