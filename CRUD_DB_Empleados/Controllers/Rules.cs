using CRUD_DB_Empleados.Data;
using CRUD_DB_Empleados.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_DB_Empleados.Controllers
{
    internal class Rules
    {
        //con esta funcion guardaremos los datos en la DB
        public static bool SaveEmpleado(Empleados empleados)
        {
            try
            {
                //creamos una instancia para utilizar los metodos en esta clase
                SQLServers connection = new SQLServers();

                //en este string se guarda el pedido para guardar Datos en esta tabla
                string sql = "INSERT INTO dbo.empleados_Table VALUES('" + empleados.Document + "', '" + empleados.Names + "', '" + empleados.Surname + "'," + empleados.Age + ", '" + empleados.Direction + "', '" + empleados.Dateofbirth + "')";

                //esta instancia permite enviar una sentancia
                SqlCommand comando = new SqlCommand(sql, connection.GetConnection());

                //controlaremos que solo se efectuo el cambio en fila indicada
                int quantity = comando.ExecuteNonQuery();




                if(quantity == 1)
                {
                    return true;
                }
                else return false;

                connection.Disconnect();

            }
            catch(Exception e)
            {

                throw new Exception("the sentence could not be executed" + e);

            }
        }

        //con esta funcion traremos esos datos de la DB 
        public static DataTable EmpleadosConsult()
        {
            try
            {
                //creamos una instancia para utilizar los metodos en esta clase
                SQLServers connection = new SQLServers();

                //en este string se guarda la consulta para traer datos de la DB
                string sql = "SELECT * FROM Empleado.dbo.empleados_Table";

                //esta instancia permite enviar una sentancia
                SqlCommand comando = new SqlCommand(sql, connection.GetConnection());

                //con esto corroboramos que se haga la lectura 
                SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);

                //creamos una nueva instancia de la tabla
                DataTable dataTable = new DataTable();
                dataTable.Load(dr);

                connection.Disconnect();

                return dataTable;


            }
            catch(Exception ex)
            {

                throw new Exception("the sentence could not be executed" + ex);
                return null;
            }
        }

        //Este metodo sirve para Consultar los datos de la BD y traerlos al formulario
        public static Empleados ConsultarEmpleado(string documento)
        {
            try
            {
                //creamos una instancia para utilizar los metodos en esta clase
                SQLServers connection = new SQLServers();

                //en este string se guarda la consulta para traer datos de la DB
                string sql = "SELECT * FROM Empleado.dbo.empleados_Table WHERE document = '" + documento + "'";

                //esta instancia permite enviar una sentancia
                SqlCommand comando = new SqlCommand(sql, connection.GetConnection());

                //con esto corroboramos que se haga la lectura 
                SqlDataReader dr = comando.ExecuteReader();

                Empleados em = new Empleados();
                //Corrobaremos si se efectuo la lectura
                if(dr.Read())
                {
                    em.Document = dr["document"].ToString();
                    em.Names = dr["names"].ToString();
                    em.Surname = dr["surname"].ToString();
                    em.Age = Convert.ToInt32(dr["age"].ToString());
                    em.Direction = dr["direction"].ToString();
                    em.Dateofbirth = dr["dateofbirth"].ToString();
                    connection.Disconnect();
                    return em;
                }
                else
                {
                    connection.Disconnect();
                    return null;
                }


            }
            catch(Exception ex)
            {

                throw new Exception("the sentence could not be executed" + ex);
                return null;
            }
        }

        //Con este metodo haremos el UPDATE
        public static bool UpdateEmpleado(Empleados empleados)
        {
            try
            {
                //creamos una instancia para utilizar los metodos en esta clase
                SQLServers connection = new SQLServers();

                //en este string se guarda el pedido para guardar Datos en esta tabla
                string sql = " UPDATE Empleado.dbo.empleados_Table SET document='" + empleados.Document + "', names='" + empleados.Names + "', surname='" + empleados.Surname + "', age=" + empleados.Age + ", direction='" + empleados.Direction + "', dateofbirth='" + empleados.Dateofbirth + "' WHERE document='" + empleados.Document + "'";
                //esta instancia permite enviar una sentancia
                SqlCommand comando = new SqlCommand(sql, connection.GetConnection());

                //controlaremos que solo se efectuo el cambio en fila indicada
                int quantity = comando.ExecuteNonQuery();




                if(quantity == 1)
                {
                    connection.Disconnect();
                    return true;
                }
                else
                {
                    connection.Disconnect();
                    return false;
                }



            }
            catch(Exception e)
            {

                throw new Exception("the sentence could not be executed" + e);

            }
        }

        //Con este metodo vamos a Eliminar Datos de la tabla
        public static bool DeleteEmpleado(string documento)
        {
            try
            {
                //creamos una instancia para utilizar los metodos en esta clase
                SQLServers connection = new SQLServers();

                //en este string se guarda el pedido para eliminar datos de la tabla
                string sql = "DELETE FROM Empleado.dbo.empleados_Table WHERE document='"+documento+"'";
                
                //esta instancia permite enviar una sentancia
                SqlCommand comando = new SqlCommand(sql, connection.GetConnection());

                //controlaremos que solo se efectuo el cambio en fila indicada
                int quantity = comando.ExecuteNonQuery();


                if(quantity == 1)
                {
                    connection.Disconnect();
                    return true;
                }
                else
                {
                    connection.Disconnect();
                    return false;
                }



            }
            catch(Exception e)
            {

                throw new Exception("the sentence could not be executed" + e);

            }
        }
    }

}
