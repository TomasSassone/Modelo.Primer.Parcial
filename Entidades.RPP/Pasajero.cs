using System.Text;

namespace Entidades.RPP
{
    public class Pasajero
    {
        //atributos
        public string apellido;
        public string nombre;
        public ERangos rango;


        //constructores
        public Pasajero()
        {
            this.apellido = "SIN APELLIDO";
            this.nombre = "SIN NOMBRE";
            this.rango = ERangos.Cliente;
        }

        public Pasajero(string apellido) : this()
        {
            this.apellido = apellido;
        }

        public Pasajero(string apellido, string nombre) : this(apellido)
        {
            this.nombre = nombre;
        }

        public Pasajero(string apellido, string nombre, ERangos rango)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.rango = rango;
        }

        //operadores
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("--- DATOS DEL PASAJERO ---\n");
            sb.AppendLine($"APELLIDO: {this.apellido}");
            sb.AppendLine($"NOMBRE: {this.nombre}");
            sb.AppendLine($"RANGO: {this.rango.ToString()}");
            return sb.ToString();
        }

        public static bool operator ==(Pasajero p1, Pasajero p2)
        {
            return (p1.nombre == p2.nombre) && (p1.apellido == p2.apellido);
        }

        public static bool operator !=(Pasajero p1, Pasajero p2)
        {
            return !(p1 == p2);
        }

        public override bool Equals(object? obj)
        {
            bool retorno = false;

            if (obj is Pasajero)
            {
                retorno = this == (Pasajero) obj;
            }

            return retorno;
        }
    }
}