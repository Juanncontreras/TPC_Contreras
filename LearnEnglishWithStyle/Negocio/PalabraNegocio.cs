using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using AccesoDatos;


namespace Negocio
{
    public class PalabraNegocio
    {

        public List<Palabra> ListarIrregulares()
        {

            List<Palabra> listado = new List<Palabra>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Palabra nuevo;

            try
            {
                accesoDatos.setearConsulta("select English,Spanish from IrregularVerbs order by English asc");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    nuevo = new Palabra();
                    nuevo.English = accesoDatos.Lector.GetString(0);
                    nuevo.Spanish = accesoDatos.Lector.GetString(1);

                    listado.Add(nuevo);
                }

                return listado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }

        }

        public List<Palabra> ListarRegulares()
        {

            List<Palabra> listado = new List<Palabra>();
            AccesoDatosManager accesoDatos = new AccesoDatosManager();
            Palabra nuevo;

            try
            {
                accesoDatos.setearConsulta("select English,Spanish from RegularVerbs order by English asc");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarConsulta();

                while (accesoDatos.Lector.Read())
                {
                    nuevo = new Palabra();
                    nuevo.English = accesoDatos.Lector.GetString(0);
                    nuevo.Spanish = accesoDatos.Lector.GetString(1);

                    listado.Add(nuevo);
                }

                return listado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }

        }
    }

}
