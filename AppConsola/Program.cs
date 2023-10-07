using Entidades.RPP;
namespace AppConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Modelo de Primer Parcial";
            Tren t = new TrenElectrico(4, "Constitución");
            Pasajero p = new Pasajero();
            Pasajero p1 = new Pasajero("Perez");
            Pasajero p2 = new Pasajero("Quintero", "Juanfer");
            Pasajero p3 = new Pasajero("Perez", "Enzo", ERangos.Maquinista);
            Pasajero p4 = new Pasajero();
            Pasajero p5 = new Pasajero("Lopez", "Jose", ERangos.Cocinero);
            Console.WriteLine(t.IndicarDestino());
            if (t.EncenderMotor())
            {
                Console.WriteLine("El motor está encendido!!!");
            }
            else
            {
                Console.WriteLine("El motor NO está encendido!!!");
            }
            t += p;
            t += p1;
            t += p4;
            t += p2;
            t += p3;
            t += p5;
            Console.WriteLine(t.ToString());
            t = new TrenElectrico(3, "Mar del Plata");
            t += p4;
            if (p == t)
            {
                Console.WriteLine("El pasajero {0}está en el tren.", p);
            }
            else
            {
                Console.WriteLine("El pasajero {0}NO está en el tren.", p);
            }
            Console.WriteLine(t.IndicarDestino());
            Console.WriteLine(t.ToString());
            Console.ReadLine();
        }
    }
}