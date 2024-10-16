using System;

namespace Multiplicador
{
    public class Program
    {
        public static void Main(String[]args)
        {
            const string Msg = "Introduce un número";

            int userNum1 = 0;
            int userNum2 = 0;
            int resultado = 0;

            Console.WriteLine(Msg);
            userNum1 = Convert.ToInt32(Console.ReadLine());
            userNum2 = Convert.ToInt32(Console.ReadLine());

            resultado = userNum1 * userNum2;
            Console.WriteLine("Su respuesta es {0}", resultado);
        }
    }
}