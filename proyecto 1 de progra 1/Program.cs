using System.Collections.Generic;
using System.Linq;
using System.Text;


public class PrimerosEjercicios
{
    static void Main(string[] args)
    {

        //ejercicio #1
        Console.WriteLine("<PRIMER EJERCICIO>");
        Console.WriteLine();
        byte edad;//declaracion de variables de tipo byte
        Console.WriteLine("ingrese su edad");//ingreso de datos del usuario
        edad = Convert.ToByte(Console.ReadLine());//aqui se guardan los datos ingresados
        Console.WriteLine("usted no aparenta tener " + edad + " años");
        Console.WriteLine();
        Console.WriteLine("<SEGUNDO EJERCICIO>");
        Console.WriteLine();
        //ejercicio #2
        byte num1, num2;//declaracion de variables de tipo byte
        ushort mult;//declaracion de variables de tipo ushort
        Console.WriteLine("ingrese un numero");//ingreso de datos del usuario
        num1 = Convert.ToByte(Console.ReadLine());//aqui se guardan los datos ingresados
        Console.WriteLine("ingrese el segundo numero");//ingreso de datos del usuario
        num2 = Convert.ToByte(Console.ReadLine());//aqui se guardan los datos ingresados
        mult = (ushort)(num1 * num2);//operacion de multiplicacion
        Console.WriteLine("resultado de la multiplicacion: " + mult);//resultado del proceso
        Console.WriteLine();
        Console.WriteLine("<TERCER EJERCICIO>");
        Console.WriteLine();
        //ejercicio #3
        long n1, n2, rest,sum,prod;//declaracion de variables
        Console.WriteLine("Ingrese el primer número: ");//ingreso de datos del usuario
        n1 =Convert.ToInt64(Console.ReadLine());//aqui se guardan los datos ingresados
            Console.WriteLine("Ingrese el segundo número: ");//ingreso de datos del usuario
            n2=Convert.ToInt64(Console.ReadLine());//aqui se guardan los datos ingresados

            sum = n1 + n2;// operacion de suma
            Console.WriteLine("El resultado de la suma es: " + sum);
            Console.ReadLine();
                    
            rest = n1 - n2;//operacion resta
            Console.WriteLine("El resultado de la resta es: " + rest);
            Console.ReadLine();

            prod = n1 / n2;//operacion de division
            Console.WriteLine("El resultado de la division es: " + prod );//resultado de nuestra division
            Console.ReadLine();
            

    }


}