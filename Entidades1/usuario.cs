namespace Usuario
{
    public class usuario
    {
        internal static string Contraseña;
        internal static string nombre;

        public class Entidades
        {

            private string nombre;
            private int Contraseña;

            public Entidades(string nombre, int contraseña)
            {
                this.nombre = nombre;
                Contraseña = contraseña;
            }

            public string Nombre { get => nombre; set => nombre = value; }
            public int Contraseña1 { get => Contraseña; set => Contraseña = value; }
        }
        public override string ToString()
        {
            return "su nombre de usuario es: " + nombre + " su contraseña  es: " + Contraseña;
        }
    }
}