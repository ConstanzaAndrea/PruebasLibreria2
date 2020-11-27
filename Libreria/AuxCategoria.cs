using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class AuxCategoria
    {
        private List<Categoria> DatosCategorias = new List<Categoria>(); 

        /// <summary>
        /// Agrega una nueva categoría siempre que esta no exista
        /// </summary>
        /// <param name="Nueva">La nueva categoría a agregar</param>
        /// <returns>1 si la agrega sino 0</returns>
        public int Agregar(Categoria Nueva)
        {
            int res = 0;
            if (Buscar(Nueva.Idcategoria) == null)
            {
                DatosCategorias.Add(Nueva);
                res = 1;
            }
            return res;
        }

        /// <summary>
        /// Agrega una nueva categoría al listado de categorías
        /// siempre que ya no exista
        /// </summary>
        /// <param name="idcat">id de la categoría</param>
        /// <param name="nom">el nombre de la categoría</param>
        /// <param name="desc">la descripción de la categoría</param>
        /// <returns>1 si la agrega 0 si no </returns>
        public int Agregar(int idcat, string nom, string desc)
        {
            int res = 0;
            Categoria nueva = new Categoria(idcat, nom, desc);

            if (Buscar(nueva.Idcategoria) == null)
            {
                DatosCategorias.Add(nueva);
                res = 1;
            }
            return res;
        }

        /// <summary>
        /// Elimina una categoría basado en su ID
        /// </summary>
        /// <param name="idCat">El id de la categoría a buscar</param>
        /// <returns>1 si lo elimina y 0 si no</returns>
        public int Eliminar(int idCat)
        {
            int res = 0;
            Categoria b = null;
            b = Buscar(idCat);

            if(b!=null)
            {
                DatosCategorias.Remove(b);
                res = 1;
            }
            return res;
        }

        /// <summary>
        /// Modifica una categoría basada en los datos de una categoría ya existente
        /// </summary>
        /// <param name="CatModificada">La categoría modificada</param>
        /// <returns>1 si la modificó sino 0</returns>
        public int Modificar(Categoria CatModificada)
        {
            int res = 0;

            if(Buscar(CatModificada.Idcategoria)!=null)
            {
                int pos = Posicion(CatModificada.Idcategoria);
                if(pos>=0)
                {
                    DatosCategorias[pos+1].Idcategoria = CatModificada.Idcategoria;
                    DatosCategorias[pos+1].Nombre = CatModificada.Nombre;
                    DatosCategorias[pos+1].Descripcion = CatModificada.Descripcion;
                    res = 1;
                }
            }

            return res;
        }

        /// <summary>
        /// Modifica una categoría
        /// </summary>
        /// <param name="idCategoria">Id de la categoría a buscar y modificar</param>
        /// <param name="nuevoNombre">Nuevo nombre de la categoría</param>
        /// <param name="nuevaDescripcion">Nueva descripción de la categoría</param>
        /// <returns>1 si modifica la categoría 0 si no lo puede hacer</returns>
        public int Modificar(int idCategoria, string nuevoNombre, string nuevaDescripcion)
        {
            int res = 0;

            int pos = Posicion(idCategoria);

            if(pos>=0)
            {
                DatosCategorias[pos].Nombre = nuevoNombre;
                DatosCategorias[pos].Descripcion = nuevaDescripcion;
                res = 1;
            }
            
            return res;
        }

        /// <summary>
        /// Busca una categoría usando como parámetro el ID
        /// </summary>
        /// <param name="idcat">id de la categoría</param>
        /// <returns>null si no la encuentra o el objeto categoría completo si la encuentra</returns>
        private Categoria Buscar(int idcat)
        {
            Categoria cat = null;

            foreach (Categoria categoria in DatosCategorias)
            {
                if (categoria.Idcategoria == idcat)
                {
                    cat = categoria;
                    break;
                }
            }

            return cat;
        }

        /// <summary>
        /// Devuelve la posicion de una categoría buscándola por su ID
        /// </summary>
        /// <param name="idCat">El id de la categoría</param>
        /// <returns>La posición de la categoría encontrada o -1 si no la encuentra</returns>
        private int Posicion(int idCat)
        {
            int res = -1;
            int p = -1;
            foreach(Categoria c in DatosCategorias)
            {
                p = p++;
                if(c.Idcategoria==idCat)
                {
                    res = p;
                    break;
                }
            }
            return res;
        }
    }
}
