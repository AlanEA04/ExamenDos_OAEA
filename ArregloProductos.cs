using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenDos_OAEA
{
    public class ArregloProductos
    {

        private string[,] productos;

        public ArregloProductos()
        {
            productos = new string[10, 2];
        }

        public void IngresarDatos()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese el nombre del producto: ");
                string nombreProducto = Console.ReadLine();

                Console.Write("Ingrese el precio del producto: ");
                double precioProducto;
                while (!double.TryParse(Console.ReadLine(), out precioProducto))
                {
                    Console.WriteLine("Ingrese un valor válido para el precio.");
                }
                productos[i, 0] = nombreProducto;
                productos[i, 1] = precioProducto.ToString();
            }
        }

        public void MostrarDatos()
        {
            Console.WriteLine("\nDatos ingresados:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Producto: {productos[i, 0]}, Precio: {productos[i, 1]}");
            }
        }

        public void BuscarPorPrecio()
        {
            Console.Write("\nIngrese el precio para buscar productos: ");
            double precioBusqueda;
            while (!double.TryParse(Console.ReadLine(), out precioBusqueda))
            {
                Console.WriteLine("Ingrese un valor válido para el precio.");
            }

            bool productosEncontrados = false;
            Console.WriteLine("\nProductos encontrados:");
            for (int i = 0; i < 10; i++)
            {
                if (Convert.ToDouble(productos[i, 1]) == precioBusqueda)
                {
                    Console.WriteLine($"Producto: {productos[i, 0]}, Precio: {productos[i, 1]}");
                    productosEncontrados = true;
                }
            }

            if (!productosEncontrados)
            {
                Console.WriteLine($"No se encontraron productos con el precio {precioBusqueda}.");
            }
        }


        public void Ordenamiento()
        {

            Console.WriteLine("Datos ordenados por precio (de mayor a menor):");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Producto: {productos[i, 0]}, Precio: {productos[i, 1]}");
            }


        }





    }
}
