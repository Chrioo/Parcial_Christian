using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Entidades1;
using Tienda.Negocio;

namespace Tienda
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre = Console.ReadLine();
            Double contra = Convert.ToDouble(Console.ReadLine());
            Clsusuario clsUsuario = new Clsusuario();

            Console.WriteLine("digite el nombre de usuario");

            Usuario Cons = new Usuario(nombre, contra);
            Cons.Nombre = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Escriba su clave de accesos");
            Cons.Contra = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(clsUsuario.Acceso(Cons));

            if (clsUsuario.Y== 1)
            {
                int x = 1;
                while (x == 1)
                {
                    Console.WriteLine("ingrese el identificador del producto");
                    double identificador_producto = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("ingrese el nombre del producto");
                    string nombre_producto = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("ingrese la descripcion del producto");
                    string descripcion = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("ingrese el precio del producto");
                    double precio = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("ingrese la cantidad del producto");
                    int cantidad = Convert.ToInt32(Console.ReadLine());

                    Clsventas cls = new Clsventas();

                    ventas ventas = new ventas(identificador_producto, nombre_producto, descripcion, precio, cantidad);
                    Console.WriteLine(cls.Cobro(ventas));
                    Console.WriteLine(Usuario.toString());
                    Console.WriteLine(ventas.ToString());
                    Console.ReadLine();
                }
            }

        }
    }

    internal class Usuario
    {
        internal double Contra;
        internal string Nombre;
        private string nombre;
        private double contra;

        public Usuario(string nombre, double contra)
        {
            this.nombre = nombre;
            this.contra = contra;
        }

        public static string Contraseña { get; internal set; }

        internal static bool toString()
        {
            throw new NotImplementedException();
        }

        public class usuario
        {
        }
    }
}

