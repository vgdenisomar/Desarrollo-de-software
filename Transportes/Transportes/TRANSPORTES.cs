using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes
{
    public class TRANSPORTES
    {
        protected string nombre;
        protected int pasajeros;
        protected int km;
        protected string marca;
        protected string velocidad;
        public static int carro;

        public TRANSPORTES()
        { }

        public TRANSPORTES(string NOM,int PASA, int KM, string MARCA, string VELOCIDAD)
        {
            nombre = NOM;
            pasajeros = PASA;
            km = KM;
            marca = MARCA;
            velocidad = VELOCIDAD;
        }

        public virtual string msj()
        {
            return "El transporte " + nombre + "\nTiene capacidad para "+pasajeros+"\nKm reccorridos: "+km+"\nMarca"+marca+"\nVelocidad"+velocidad;
        }
    }
}
