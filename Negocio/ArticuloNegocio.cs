using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    using Dominio;
    using System.Collections.Generic;
    using System.Net.Http;

    public class ArticuloNegocio
    {
        
      
        public List<Articulo> Listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta(
                    "SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.Precio, " +
                    "M.Id AS IdMarca, M.Descripcion AS Marca, " +
                    "C.Id AS IdCategoria, C.Descripcion AS Categoria " +
                    "FROM ARTICULOS A " +
                    "LEFT JOIN MARCAS M ON A.IdMarca = M.Id " +
                    "LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id"
                );

                datos.EjecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();

                    aux.id = (int)datos.Lector["Id"];
                    aux.codigo = (string)datos.Lector["Codigo"];
                    aux.nombre = (string)datos.Lector["Nombre"];
                    aux.descripcion = (string)datos.Lector["Descripcion"];
                    aux.precio = (decimal)datos.Lector["Precio"];

                    aux.marca = new Marca();
                    aux.marca.id = (int)datos.Lector["IdMarca"];
                    aux.marca.descripcion = (string)datos.Lector["Marca"];

                    aux.categoria = new Categoria();
                    aux.categoria.id = (int)datos.Lector["IdCategoria"];
                    aux.categoria.descripcion = (string)datos.Lector["Categoria"];

                    lista.Add(aux);
                }

                return lista;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }
        public void Agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearConsulta(
                    "INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio) " +
                    "VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Precio)"
                );

                datos.SetearParametros("@Codigo", nuevo.codigo);
                datos.SetearParametros("@Nombre", nuevo.nombre);
                datos.SetearParametros("@Descripcion", nuevo.descripcion);
                datos.SetearParametros("@IdMarca", nuevo.marca.id);
                datos.SetearParametros("@IdCategoria", nuevo.categoria.id);
                datos.SetearParametros("@Precio", nuevo.precio);

                datos.EjecutarConsulta();
            }
            finally
            {
                datos.CerrarConexion();
            }
        }


        public void Eliminar(int id)
        {
            AccesoDatos datosImagenes = new AccesoDatos();

            try
            {
                datosImagenes.SetearConsulta("DELETE FROM IMAGENES WHERE IdArticulo = @Id");
                datosImagenes.SetearParametros("@Id", id);
                datosImagenes.EjecutarConsulta();
            }
            finally
            {
                datosImagenes.CerrarConexion();
            }

            AccesoDatos datosArticulo = new AccesoDatos();

            try
            {
                datosArticulo.SetearConsulta("DELETE FROM ARTICULOS WHERE Id = @Id");
                datosArticulo.SetearParametros("@Id", id);
                datosArticulo.EjecutarConsulta();
            }
            finally
            {
                datosArticulo.CerrarConexion();
            }
        }

        public  void Modificar(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearConsulta(
            "UPDATE ARTICULOS SET " +
            "Codigo = @Codigo, " +
            "Nombre = @Nombre, " +
            "Descripcion = @Descripcion, " +
            "IdMarca = @IdMarca, " +
            "IdCategoria = @IdCategoria, " +
            "Precio = @Precio " +
            "WHERE Id = @Id");
                datos.SetearParametros("@Codigo", articulo.codigo);
                datos.SetearParametros("@Nombre", articulo.nombre);
                datos.SetearParametros("@Descripcion", articulo.descripcion);
                datos.SetearParametros("@IdMarca", articulo.marca.id);
                datos.SetearParametros("@IdCategoria", articulo.categoria.id);
                datos.SetearParametros("@Precio", articulo.precio);
                datos.SetearParametros("@Id", articulo.id);

                datos.EjecutarConsulta();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

    }
}
