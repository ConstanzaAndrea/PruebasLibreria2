using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    /// <summary>
    /// Clase que permite almacenar una instancia de un producto
    /// </summary>
    public class Producto
    {
        private int idProducto;
        private string nombre;
        private Categoria cat; 
        private int precio;
        private int stock;
        private bool estado;

        /// <summary>
        /// constructor sin parámetros
        /// </summary>
        public Producto()
        {
        }

        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        /// <param name="idProducto">El id del producto</param>
        /// <param name="nombre">El nombre del producto</param>
        /// <param name="cat">El objeto categoría que representa la categoría del producto</param>
        /// <param name="precio">El precio del producto</param>
        /// <param name="stock">El stock del producto</param>
        /// <param name="estado">El estado del producto</param>
        public Producto(int idProducto, string nombre, Categoria cat, int precio, int stock, bool estado)
        {
            this.IdProducto = idProducto;
            this.Nombre = nombre;
            this.Cat = cat;
            this.Precio = precio;
            this.Stock = stock;
            this.Estado = estado;
        }

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public Categoria Cat { get => cat; set => cat = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Stock { get => stock; set => stock = value; }
        public bool Estado { get => estado; set => estado = value; }
    }
}
