using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.RPP
{
    public class TrenElectrico : Tren
    {
        //atributos/propiedades
        protected List<Pasajero> pasajeros;

        //constructor
        public TrenElectrico(int cantMaxPasajeros, string destino) : base(cantMaxPasajeros, destino)
        {
            this.pasajeros = new List<Pasajero>();
        }

        public override List<Pasajero> Pasajeros
        {
            get
            {
                return pasajeros;
            }
        }

        public override string IndicarDestino()
        {
            return $"El tren eléctrico tiene destino a {base.destino}";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            foreach(Pasajero pasajero in this.pasajeros)
            {
                sb.AppendLine(pasajero.ToString());
            }
            return sb.ToString();
        }
    }
}
