using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportes
{
    public class Clase_terrestre_automovil:clase_terrestre
    {
        public static string tipo;

        public Clase_terrestre_automovil()
        {
        }

        public Clase_terrestre_automovil(string NOM, int PASA, int KM, string MARCA, string VELOCIDAD)
        {
            nombre = NOM;
            pasajeros = PASA;
            km = KM;
            marca = MARCA;
            velocidad = VELOCIDAD;
        }

        public override string msj()
        {
            return "El transporte " + nombre + "\nTiene capacidad para " + pasajeros + "\nKm reccorridos: " + km + "\nMarca" + marca + "\nVelocidad" + velocidad + "\nNo. llantas" + llantas + "\nNo. Placa" + placas + "\nTransmision" + transmision+"\nTipo de carro: "+tipo;
        }


    }
}
