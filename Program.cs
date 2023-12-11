namespace ExamenDos_OAEA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArregloProductos K = new ArregloProductos();


            K.IngresarDatos();

            K.MostrarDatos();


            K.BuscarPorPrecio();
            K.Ordenamiento();

        }
    }
}