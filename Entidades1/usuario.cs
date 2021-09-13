using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Tienda.Endidades
{
    class Clspersona
    {
        public class Entidades
      {
            private String nombre = "Cristian";
            private int Contraseña = 123;

            public Entidades(string nombre, int contraseña)
            {
                this.nombre = nombre;
                Contraseña = contraseña;
            }

            public string Nombre { get => nombre; set => nombre = value; }
            public int Contraseña1 { get => Contraseña; set => Contraseña = value; }
        }
  }
}




