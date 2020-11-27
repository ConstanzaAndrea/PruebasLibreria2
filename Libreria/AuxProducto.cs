using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class AuxProducto
    {
        private List<Producto> DatosProductos;

        /// <summary>
        /// Agrega un nuevo rpoducto siempre y cuando no esté repetido
        /// </summary>
        /// <param name="nuevo">El nuevo objeto producto a agregar</param>
        /// <returns>1 si lo agrega, sino 0</returns>
        public int AgregarProducto(Producto nuevo)
        {
            int res = 0;
            if (Buscar(nuevo.IdProducto) == null)
            {
                DatosProductos.Add(nuevo);
                res = 1;
            }

            return res;
        }

        /// <summary>
        /// Agrega un nuevo producto a partir de los valores de los parámetros 
        /// siempre y cuando no esté repetido
        /// </summary>
        /// <param name="idProd">El id del nuevo producto</param>
        /// <param name="nombre">El nombre del nuevo producto</param>
        /// <param name="cat">La categoría del nuevo producto</param>
        /// <param name="precio">El precio del nuevo producto</param>
        /// <param name="stock">El stock del nuevo producto</param>
        /// <returns>1 si lo agrega 0 si no lo hace</returns>
        public int AgregarProducto(int idProd, string nombre, Categoria cat, int precio, int stock)
        {
            int res = 0;
            Producto nuevo = null;
            if (Buscar(nuevo.IdProducto) == null)
            {
                DatosProductos.Add(nuevo);
                res = 1;
            }
            return res;
        }

        /// <summary>
        /// Busca un producto y cambia su estado a falso
        /// </summary>
        /// <param name="idProducto">El id del producto a dar de baja</param>
        /// <returns>1 si lo da de bajo sino 0</returns>
        public int DardeBaja(int idProducto)
        {
            int res = 0;

            Producto p = Buscar(idProducto);

            if(p!=null)
            {
                p.Estado = false;
            }

            return res;
        }

        /// <summary>
        /// Actualiza el Stock del producto
        /// </summary>
        /// <param name="idProducto">El id del producto a actualizar</param>
        /// <param name="cantidadAgregar">La nueva cantidad a agregar</param>
        /// <returns></returns>
        public int ActualizarStock(int idProducto, int cantidadAgregar)
        {
            int cantidadActual = -1;

            Producto p = null;
            p = Buscar(idProducto);

            if(p!=null)
            {
                p.Stock = p.Stock + cantidadAgregar;
                cantidadActual = p.Stock;
            }

            return cantidadActual;
        }

        /// <summary>
        /// Método que permite Modificar los datos de un Producto
        /// </summary>
        /// <param name="idProd">El id del producto a buscar</param>
        /// <param name="nuevoNombre">El nuevo nombre del producto</param>
        /// <param name="nuevaCategoria">La nueva categoría del producto</param>
        /// <param name="nuevoPrecio">El nuevo precio del producto</param>
        /// <param name="nuevoStock">El nuevo stock del producto</param>
        /// <returns></returns>
        public int Modificar(int idProd, string nuevoNombre, Categoria nuevaCategoria, int nuevoPrecio, int nuevoStock)
        {
            int res = 0;

            Producto prod = null;
            prod = Buscar(idProd);

            if(prod!=null)
            {
                prod.Nombre = nuevoNombre;
                prod.Cat = nuevaCategoria;
                prod.Precio = nuevoPrecio;
                prod.Stock = nuevoStock;
            }

            return res;
        }

        /// <summary>
        /// Busca un Producto por su ID
        /// </summary>
        /// <param name="idProducto">El id del producto a buscar</param>
        /// <returns>El producto si lo encuentra, sino null</returns>
        private Producto Buscar(int idProducto)
        {
            Producto encontrado = null;

            foreach(Producto p in DatosProductos)
            {
                if(p.IdProducto==idProducto)
                {
                    encontrado = p;
                    break;
                }
            }
            
            return encontrado;
        }
    }
}
