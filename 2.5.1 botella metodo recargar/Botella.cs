using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._5._1_botella_metodo_recargar
{
    internal class Botella
    {

        // agregar metodo o comportamiento "recarga" a botella capacidad maxima 100bcantidad actual..
        // inicia en cero metodo recarga que carga al 100 y devuelve costo que sera 50 cada 100

        public Botella(string color, string material) // crea clase con parametros definidos
        {
            this.color = color;         //recibe
            this.material = material;   //recibe
            capacidad = 100;            //creacion defecto- cap max
            cantidadActual = 0;         //comienza en 0

        }

        private string color, material;
        private int capacidad, cantidadActual;
        float monto;

        public int Capacidad
        {
            get { return capacidad; }
        }

        public int CantidadActual
        {
            get { return cantidadActual; }
        }
        public float Monto
        {
            get { return monto; }
        }

        //metodo recargar

        public float recargar()
        {
            cantidadActual = 100;
            monto = 50;
            return monto;
        }


    }
}
