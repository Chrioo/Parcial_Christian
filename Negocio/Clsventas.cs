using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Entidades1;
using Tienda.Negocio;
namespace Tienda.Negocio
{
    class Clsventas
    {
        private readonly int Precio;
        private int Cantidad;

        public string Paga(Clsventas ventas)
        {
            {
                double total = ventas.Precio * ventas.Cantidad;

                if (ventas.Precio > 50)
                {
                    double descuento = total - (total * 0.20);
                    Console.WriteLine("aplica al 20% de descuento su total es de " + descuento);
                }
                else
                {
                    Console.WriteLine("no aplica descuento su total es" + total);
                }

                return "";
            }
        }

        internal bool Cobro(ventas vent)
        {
            throw new NotImplementedException();
        }
    }
}
//hecho por Critian y maria jose