using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tienda.Negocio
{
    class Ventas
    {
        private int identificar_producto;
        private string nombre_producto;
        private string descripcion_Producto;
        private int cantidad;
        private double precio;

        public Ventas(int identificar_producto, string nombre_producto, string descripcion_Producto, int cantidad, double precio)
        {
            this.identificar_producto = identificar_producto;
            this.nombre_producto = nombre_producto;
            this.descripcion_Producto = descripcion_Producto;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public int Identificar_producto { get => identificar_producto; set => identificar_producto = value; }
        public string Nombre_producto { get => nombre_producto; set => nombre_producto = value; }
        public string Descripcion_Producto { get => descripcion_Producto; set => descripcion_Producto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Precio { get => precio; set => precio = value; }
    }
}
