using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados_nuevos
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre, puesto, lvl, dias, hrs;
            Empleado empleado1 = new Empleado();
            Console.WriteLine("Bienvenido, porfavor ingrese el nombre del nuevo empleado");
            nombre = Console.ReadLine();
            Console.WriteLine("Porfavor ingrese el puesto del nuevo empleado");
            puesto = Console.ReadLine();
            Console.WriteLine("Porfavor ingrese el nivel de ingles del nuevo empleado");
            lvl = Console.ReadLine();
            Console.WriteLine("Porfavor ingrese los dias los cuales el nuevo empleado esta disponible");
            dias = Console.ReadLine();
            Console.WriteLine("Porfavor ingrese las horas donde el nuevo empleado esta disponible");
            hrs = Console.ReadLine();
            empleado1.Nombre = nombre;
            empleado1.Puesto = puesto;
            empleado1.Lvl = lvl;
            empleado1.Dias = dias;
            empleado1.Hrs = hrs;
            Console.Clear();
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.WriteLine($"Nombre: {empleado1.Nombre}");
            Console.WriteLine($"Puesto: {empleado1.Puesto}");
            Console.WriteLine($"Nivel de ingles: {empleado1.Lvl}");
            Console.WriteLine($"Dias disponible: {empleado1.Dias}");
            Console.WriteLine($"Horas disponible: {empleado1.Hrs}");
            Console.WriteLine("------------------------------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}
