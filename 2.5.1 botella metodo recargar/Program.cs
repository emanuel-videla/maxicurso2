using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5._1_botella_metodo_recargar
{
    internal class Program
    {
        static void Main(string[] args)

        {

            Botella b1 = new Botella("Rojo","Vidrio");
            //b1.Capacidad = 150; no se puede asignar xq nace con una cap max 100 en clase botella

            Console.WriteLine("La capacidad de la botella es" + b1.Capacidad);
            Console.WriteLine("y el contenido actual es: " + b1.CantidadActual);

            //aplicamos metodo.. comportamiento.. recargamos..

            string ingreso;

            Console.WriteLine("Ingrese 1 si desea llenar la botella, de lo contrario presione cualquier tecla");
            ingreso = Console.ReadLine();

            if (ingreso == "1"){
                b1.recargar();
                Console.WriteLine("Luego de la recarga el contenido actual es: " + b1.CantidadActual);
                Console.WriteLine("El monto de la recarga es: " + b1.Monto);
            }else{
                Console.WriteLine("No se recargo la botella");
            }



            Console.ReadKey();

        }
    }
}
