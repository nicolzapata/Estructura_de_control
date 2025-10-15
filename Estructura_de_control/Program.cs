using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructura_de_control
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ejercicio1
            //Console.WriteLine("Ingrese un número: ");
            //   int numero = int.Parse(Console.ReadLine());
            //   if (numero % 2 == 0)
            //     {
            //         Console.WriteLine("El número que usted ingreso es: " + numero + " es par");
            //     }
            //     else
            //     {
            //         Console.WriteLine($"El número que usted ingreso {numero} es impar");
            // }

            //ejercicio2
            //Console.WriteLine("Ingrese su primera nota: ");
            //double nota1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Ingrese su segunda nota: ");
            //double nota2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Ingrese su tercer nota: ");
            //double nota3 = double.Parse(Console.ReadLine());

            //double definitiva = (nota1 * 0.2) + (nota2 * 0.3) + (nota3 * 0.5);

            //Console.WriteLine("La nota definitiva es: " + definitiva);

            //if (definitiva >=3)
            //{
            //    Console.WriteLine("Aprobó");
            //}

            //else
            //{
            //    Console.WriteLine("Reprobó");
            //}

            //ejercicio3
            Console.WriteLine("Ingrese el precio del producto:");
            double precio = double.Parse(Console.ReadLine());

            double precioFinal;

            if(precio >= 100000)
            {
                precioFinal = precio - (precio * 0.2); // Aplica un descuento del 10%
            }
            else
            {
                precioFinal = precio; // No hay descuento
            }
            Console.WriteLine("El precio final es: " + precioFinal);
        }
    }
}
