using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace CRUD_DB_Empleados.Data
{
    class SQLServers
    {
        SqlConnection connection;

        //con este metodo vamos a conectarnos a la base de datos
        public SqlConnection GetConnection()
        {
            try
            {
                connection = new SqlConnection("Server=DESKTOP-GJ9RV1H\\SQLEXPRESS;" +
                                           "Database=Empleado;integrated security=true");
                connection.Open();
                return connection;
            }
            catch(Exception e)
            {

                throw new Exception("Ha ocurrido un error al conectarse " + e.Message);
            }

        }



        //con este metodo vamos a desconectarnos
        public bool Disconnect()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch(Exception e)
            {
                throw new Exception("Ha ocurrido un error al desconectase " + e.Message);
                return false;
            }
        }

    }
}
