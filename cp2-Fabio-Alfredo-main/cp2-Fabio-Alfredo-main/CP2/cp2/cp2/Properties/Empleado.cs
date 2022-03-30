using System;

namespace cp2.Properties
{
    public class Empleado
    {
        private string nombre, modalidad;
        private double salario, ISSS, AFP, renta, descuentoRentaPla, salarioFin, descuRentaSer;
        private bool genero;
        private int anioNaci, edad;

        public Empleado(string Nnombre, string Nmodalidad, double Nsalario, bool Ngenero, int anio)
        {
            nombre = Nnombre;
            modalidad = Nmodalidad;
            salario = Nsalario;
            genero = Ngenero;
            anioNaci = anio;
            ISSS = 0.03;
            AFP = 0.07;
            renta = 0.10;
            descuRentaSer = salario * (0.10);
            descuentoRentaPla = salario * ((0.10)+(0.07)+(0.03));
            salarioFin =0;
            edad = 2022 - anioNaci;
        }

        public string Nombre => nombre;

        public string Modalidad => modalidad;

        public double Salario => salario;

        public void mosGene()
        {
            if(genero == true && edad >= 60)
            {
                Console.WriteLine("Genero: Masculino");
                Console.WriteLine("Su edad es: "+edad+" Ya se puede retirar");
            }
            else if(genero == true && edad < 60)
            {
                Console.WriteLine("Genero: Masculino");
                Console.WriteLine("Su edad es: "+edad+" Aun no se npuede retirar");
            }
            else if (genero == false && edad >= 55)
            {
                Console.WriteLine("Genero femenino");
                Console.WriteLine("Su edad es: "+edad+" Ya se puede retirar");
            }
            else
            {
                Console.WriteLine("Genero: Femenino");
                Console.WriteLine("Su edad es: "+edad+" Aun no se puede retirar");
            } 
        }

        public int AnioNaci => anioNaci;

        public double Isss => ISSS;

        public double Afp => AFP;

        public double Renta => renta;

        //public double DescuentoRenta => descuentoRenta;

       // public double SalarioFin => salarioFin;


       public void descuentos()
       {
           if (modalidad == "Planilla")
           {
               Console.WriteLine("Su salario final es: "+(salario-descuentoRentaPla));
           }
           else
           {
               Console.WriteLine("Su salario es: "+(salario-descuRentaSer));
           }
       }
    }
}