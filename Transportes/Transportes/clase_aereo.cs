using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes
{
    public class clase_aereo:TRANSPORTES
    {
        public static int alas;
        public static int elices;
        public static int llantas;
        public static int altura;

        public clase_aereo()
        { }

        public clase_aereo(string NOM, int PASA, int KM, string MARCA, string VELOCIDAD)
        {
            nombre = NOM;
            pasajeros = PASA;
            km = KM;
            marca = MARCA;
            velocidad = VELOCIDAD;
        }

        public override string msj()
        {
            return "El transporte " + nombre + "\nTiene capacidad para " + pasajeros + "\nKm reccorridos: " + km + "\nMarca" + marca + "\nVelocidad" + velocidad+"\nNo. alas: "+ "\nNo. alas: "+alas+"\nNo. elices: "+elices+ "\nNo. llantas: "+llantas+ "\nAltura maxima: "+altura;

        }





    }
}
