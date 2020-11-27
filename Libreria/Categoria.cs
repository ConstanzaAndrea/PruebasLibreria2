using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    /// <summary>
    /// Clase para almacenar una instancia de una categoría
    /// </summary>
    public class Categoria
    {
        private int idcategoria;
        private string nombre;
        private string descripcion;

        /// <summary>
        /// Construtor sin parámetros de la categoría
        /// </summary>
        public Categoria()
        {

        }

        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        /// <param name="idcategoria"> El id de la categoría</param>
        /// <param name="nombre"> El nombre de la categoría</param>
        /// <param name="descripcion"> La descripción de la categoría</param>
        public Categoria(int idcategoria, string nombre, string descripcion)
        {
            this.Idcategoria = idcategoria;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
        }

        public int Idcategoria { get => idcategoria; set => idcategoria = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
