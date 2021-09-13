using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Entidades1;
using Usuario;
using Tienda.Negocio;
namespace Tienda.Negocio
{
    class Clsusuario
    {
        public int Y { get; internal set; }

        public string Acceso(Usuario.usuario)
        {
            if (usuario.nombre == "")
            {
                return "Ingresa su nombre: ";
            }
            else if (Usuario.Contraseña == "")
            {
                return "Ingresa su contraseña: ";
            }
            else
            {
                return "Inicio de sesion correcto puede continuar con el proceso ";


            }
        }

        internal string Acceso(Usuario cons)
        {
            throw new NotImplementedException();
        }
    }
}