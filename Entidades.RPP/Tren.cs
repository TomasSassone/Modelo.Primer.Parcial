using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.RPP
{
    public abstract class Tren
    {
        //atributos
        protected int cantMaxPasajeros;
        protected string destino;
        protected bool motorEncendido;

        public abstract List<Pasajero> Pasajeros { get; }

        //constructores
        public Tren(int cantMaxPasajeros, string destino)
        {
            this.cantMaxPasajeros = cantMaxPasajeros;
            this.destino = destino;
        }

        //operadores
        public static bool operator==(Pasajero p, Tren t)
        {
            return t.Pasajeros.Contains(p);
            //el contains funciona porque utiliza intermente el equals, y sobrecargamos
            //el equals para que compare el nombre y apellido del pasajero. Sino, tendríamos que haber usado un foreach de Pasajeros.
        }
        public static bool operator !=(Pasajero p, Tren t)
        {
            return !(p == t);
        }

        public static Tren operator +(Tren t, Pasajero p)
        {
            if (t.Pasajeros.Count < t.cantMaxPasajeros)
            {
                if (p != t)
                {
                    t.Pasajeros.Add(p);
                }
                else
                {
                    Console.WriteLine("El pasajero ya se encuentra en el tren.");
                }
            }
            else
            {
                Console.WriteLine("El tren está completo.");
            }
            return t;
        }
        public static Tren operator -(Tren t, Pasajero p)
        {
            if (p == t)
            {
                t.Pasajeros.Remove(p);
            }
            else
            {
                Console.WriteLine("El pasajero ingresado no está en el tren.");
            }
            return t;
        }

        //metodos
        public virtual string IndicarDestino()
        {
            return this.destino;
        }

        public bool EncenderMotor()
        {
            this.motorEncendido = true;
            return true;
        }

        public override string ToString()
        {
            return $"--- TREN ---\nMotor encendido: {this.motorEncendido}\nDestino: {this.destino}\nCantidad máxima de pasajeros: {this.cantMaxPasajeros}\nPasajeros a bordo: {Pasajeros.Count()}";
        }
    }
}
