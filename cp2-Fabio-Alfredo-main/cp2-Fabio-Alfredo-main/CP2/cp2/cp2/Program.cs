
using System;
using cp2.Properties;

namespace cp2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*Escribe tu programa, pero antes debes analizar el diagrama de clases en la guia
             * https://meaguilar.github.io/POO/Evaluaciones/cp2/#0
             * 
             * Resultado esperado imprimir en pantalla los datos del empleado,
             * su deducción salarial, y su salario aplicada las deducciones y  si es apto para el retiro según su edad y género. 
             */

            Console.WriteLine("Empleado 1");
            Empleado unEmpleado = new Empleado("Alfredo", "Planilla", 300.50, true, 2003);
            Console.WriteLine("Nombre: " + unEmpleado.Nombre);
            Console.WriteLine("Modalidad: " + unEmpleado.Modalidad);
            Console.WriteLine("Salario: " + unEmpleado.Salario);
            unEmpleado.mosGene();
            Console.WriteLine("Año nacimiento: " + unEmpleado.AnioNaci);
            Console.WriteLine("Su descuento de renta es: " + unEmpleado.Renta);
            Console.WriteLine("Su descuento de renta es: " + unEmpleado.Afp);
            Console.WriteLine("Su descuento de renta es: " + unEmpleado.Isss);
            //Console.WriteLine("Su salario final es: "+unEmpleado.SalarioFin);
            unEmpleado.descuentos();

            Console.WriteLine("\n\nEmpleado 2");
            Empleado nuevoEmpleado = new Empleado("Sofia", "servicio social", 340, false, 1990);
            Console.WriteLine("Nombre: " + nuevoEmpleado.Nombre);
            Console.WriteLine("Modalidad: " + nuevoEmpleado.Modalidad);
            Console.WriteLine("Salario: " + nuevoEmpleado.Salario);
            nuevoEmpleado.mosGene();
            Console.WriteLine("Año nacimiento: " + nuevoEmpleado.AnioNaci);
            Console.WriteLine("Su descuento de renta es: " + nuevoEmpleado.Renta);
            Console.WriteLine("Su descuento de renta es: " + nuevoEmpleado.Afp);
            Console.WriteLine("Su descuento de renta es: " + nuevoEmpleado.Isss);
            //Console.WriteLine("Su salario final es: "+nuevoEmpleado.SalarioFin);
            nuevoEmpleado.descuentos();

        }
    }
}