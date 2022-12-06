using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAppLEPO
{
    public class Conexion
    {
        private string sentenciaSQL1;
        private string sentenciaSQL2;
        System.Data.OleDb.OleDbConnection conn;
        System.Data.OleDb.OleDbTransaction miTran;

        private string mensaje;

        public string GetMensaje
        {

            get { return mensaje; }
        }

        public Conexion()
        {
            //System.Data.OleDb.OleDbConnection conn;
            conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=SQLNCLI11;Data Source=LAPTOP-44I47S4V;User ID=soporte;Password=soporte;Initial Catalog=Sobretension;Persist Security Info=False;";

        }

        //public void Conexion2()
        //{
        //    //System.Data.OleDb.OleDbConnection conn;
        //    conn = new System.Data.OleDb.OleDbConnection();
        //    conn.ConnectionString = @"Provider=SQLNCLI11;Data Source=LAPTOP-44I47S4V;User ID=soporte;Password=soporte;Initial Catalog=Sobretension;Persist Security Info=False;";

        //}

        public void SetSentencia1(string s1)
        {

            sentenciaSQL1 = s1;
        }

        public void SetSentencia2(string s2)
        {

            sentenciaSQL2 = s2;
        }


        public String EjecutarSQL2()
        {
            try
            {

                System.Data.OleDb.OleDbCommand miComando = new System.Data.OleDb.OleDbCommand();
                miComando.Connection = conn;
                conn.Open();
                miTran = conn.BeginTransaction(); //ok Prueba con Bloqueos
                miComando.Connection = conn; // Se pasa el nombre de la conexion al Objeto Comando
                miComando.Transaction = miTran; // SE pasa el nombre de la transaccion al objeto Comando
                miComando.CommandText = sentenciaSQL1;
                miComando.ExecuteNonQuery();
                miComando.CommandText = sentenciaSQL2;
                miComando.ExecuteNonQuery();
                miTran.Commit(); // Dejamos en firme
                return "Todo OK";

            }
            catch (Exception e)
            {

                miTran.Rollback();
                return "Se presento el siguiente error " + e.Message;
            }
        }

        public System.Data.DataSet Consultar()
        {
            try
            {
                conn.Open();
                System.Data.OleDb.OleDbDataAdapter objRes;
                objRes = new System.Data.OleDb.OleDbDataAdapter(sentenciaSQL1, conn);
                System.Data.DataSet datos;
                datos = new System.Data.DataSet();
                objRes.Fill(datos, "Tabla");
                mensaje = "Todo OK";
                return datos;

            }
            catch (Exception MiExc)
            {
                System.Data.DataSet datos2;
                datos2 = new System.Data.DataSet();
                mensaje = "Se presento el siguiente error " + MiExc.Message;
                return datos2;

            }
            finally
            {

                conn.Close();
            }
        }


        public String EjecutarSQL1()
        {
            try
            {

                System.Data.OleDb.OleDbCommand miComando = new System.Data.OleDb.OleDbCommand();
                miComando.Connection = conn;
                conn.Open();

                miTran = conn.BeginTransaction();
                miComando.Connection = conn;
                miComando.Transaction = miTran;
                miComando.CommandText = sentenciaSQL1;
                miComando.ExecuteNonQuery();
                miTran.Commit();
                return "Todo OK";

            }

            catch (Exception e)
            {

                miTran.Rollback();
                return "Se presento el siguiente error " + e.Message;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
