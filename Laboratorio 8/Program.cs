using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Bienvenido a la calculadora");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Multiplicación");
                Console.WriteLine("3. Raíz Cuadrada");
                Console.WriteLine("4. Porcentaje");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":

                        int num1, num2, num3, suma;

                        Console.Write("Ingrese el primer número: ");
                        num1 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Ingrese el segundo número: ");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Ingrese el tercer número: ");
                        num3 = Convert.ToInt32(Console.ReadLine());

                        suma = num1 + num2 + num3;
                        Console.WriteLine("La suma de los tres números es: " + suma);

                        Console.ReadKey();
                        break;

                    case "2":
                        Console.WriteLine("Ingrese el primer número:");
                        double numero1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Ingrese el segundo número:");
                        double numero2 = Convert.ToDouble(Console.ReadLine());

                        double resultado = numero1 * numero2;

                        Console.WriteLine("El resultado de la multiplicación es: " + resultado);
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.Write("Ingresa un número: ");
                        double num = double.Parse(Console.ReadLine());
                        double result = Math.Sqrt(num);
                        Console.WriteLine($"La raíz cuadrada de {num} es {result}");
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.Write("Ingresa un número: ");
                        double numero4 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingresa el porcentaje que quieres calcular: ");
                        double porcentaje = Convert.ToDouble(Console.ReadLine());
                        double resultado4 = numero4 * porcentaje / 100;
                        Console.WriteLine("El " + porcentaje + "% de " + numero4 + " es: " + resultado4);
                        Console.ReadLine();
                        break;

                    case "5":
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }

                if (continuar)
                {
                    Console.Write("Presione una tecla para continuar...");
                    Console.ReadKey();
                }
            } while (continuar);
        } 
    }
}
