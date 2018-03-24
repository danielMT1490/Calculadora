using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        public enum Opcion { Suma=1,Resta,Multiplicacion,Division};
        static void Main(string[] args)
        {
            Calculadora cal = new Calculadora();
            Console.WriteLine("Bienvenido a la calculadora");
            //Opcion opciones = new Opcion();
            int opcion = 1;
            int resultado = 0;
            do
            {
                Console.WriteLine("Escoja la oprecion a relaizar:");
                Console.WriteLine("1.Suma." + "\n" + "2.Resta" + "1.Suma." + "\n" + "3.Multiplicacion." + "\n" + "4.Division"+"\n"+"0.Salir");
                opcion = Convert.ToInt32(Console.ReadLine());
                if (opcion == 0) break;
                Console.WriteLine("Introduzca el primer numero: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduzca el segundo numero: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                //casetamos el int con el enum y asi obtenemos un switch fuertemente tipado
                switch ((Opcion)opcion)
                {
                    case Opcion.Suma:
                        resultado = cal.Suma(num1, num2);
                        Console.WriteLine("El resultado es " + resultado);
                        break;
                    case Opcion.Resta:
                        resultado = cal.Resta(num1, num2);
                        Console.WriteLine("El resultado es " + resultado);
                        break;
                    case Opcion.Multiplicacion:
                        resultado = cal.Multiplicacion(num1, num2);
                        Console.WriteLine("El resultado es " + resultado);
                        break;
                    case Opcion.Division:
                        resultado = cal.Division(num1, num2);
                        Console.WriteLine("El resultado es " + resultado);
                        break;
                    default:
                        Console.WriteLine("Escribe un valor correcto");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (opcion!=0);
         

        }
    }
}
