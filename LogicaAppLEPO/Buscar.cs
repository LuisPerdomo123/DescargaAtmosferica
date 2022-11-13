using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAppLEPO
{
    public class Buscar
    {

        private string mensaje;
        private string tabla;
        private string campoClave;
        private string codRetorno;
        private string nomRetorno;
        private string filtro;

        public string Filtro
        {

            get { return filtro; }
            set { filtro = value; }
        }

        private string datobusqueda;

        System.Data.OleDb.OleDbConnection conn;
        System.Data.OleDb.OleDbTransaction miTran;

        public void EscribirTabla(String pnombreTabla)
        {
            this.tabla = pnombreTabla;
        }
        public void EscribirCampoClave(String pcampoclave)
        {
            this.campoClave = pcampoclave;
        }

        public void EscribirDatoBusqueda(String pdatobusqueda)
        {
            this.datobusqueda = pdatobusqueda;
        }

        public string LeerCampClave() { 
        
            return this.campoClave;
        }

        public string LeerTabla() { 
        
            return this.tabla;
        }

        public string LeerDatBusq() {

            return this.datobusqueda;
        }

        public Buscar() {

            conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=SQLNCLI11;Data Source=LAPTOP-44I47S4V;User ID=soporte;Password=soporte;Initial Catalog=Sobretension;Persist Security Info=False;";
        }

        public System.Data.DataSet BuscarTodos()
        {
            try {

                String sentenciaSQL1;
                sentenciaSQL1 = "SELECT * FROM " + this.tabla;
                conn.Open();
                System.Data.OleDb.OleDbDataAdapter objRes;
                objRes = new System.Data.OleDb.OleDbDataAdapter(sentenciaSQL1, conn);
                System.Data.DataSet datos;
                datos = new System.Data.DataSet();
                objRes.Fill(datos, "Tabla");
                mensaje = "Sedevolvio DataSet. Todo OK";
                return datos;
            }
            catch (Exception MiExc) {

                System.Data.DataSet datos2;
                datos2 = new System.Data.DataSet();
                mensaje = "Se presentó un problemita " + MiExc.Message;
                return datos2;
            }
            finally { 
            
                conn.Close();
            }

        }

        public System.Data.DataSet BuscarxCodDes()
        {
            try
            {

                String sentenciaSQL1;
                String sentenciaSQL = "SELECT * FROM " + this.tabla + "WHERE CodDescarga LIKE '%";
                conn.Open();
                System.Data.OleDb.OleDbDataAdapter objRes;
                objRes = new System.Data.OleDb.OleDbDataAdapter(sentenciaSQL, conn);
                System.Data.DataSet datos;
                datos = new System.Data.DataSet();
                objRes.Fill(datos, "Tabla");
                mensaje = "Se devolvio DataSet. Todo OK";
                return datos;
            }
            catch (Exception MiExc)
            {

                System.Data.DataSet Datos2;
                Datos2 = new System.Data.DataSet();
                mensaje = "Se presentó un problemita " + MiExc.Message;
                return Datos2;
            }
            finally {

                conn.Close();
            }
        }

        public System.Data.DataSet BuscarCD()
        {
            try { 
            
                String sentenciaSQL1;
                sentenciaSQL1 = "SELECT * FROM "+this.tabla + "WHERE("+this.campoClave+")";
                conn.Open();
                System.Data.OleDb.OleDbDataAdapter objRes;
                objRes = new System.Data.OleDb.OleDbDataAdapter(sentenciaSQL1,conn);
                System.Data.DataSet datos;
                datos = new System.Data.DataSet();
                objRes.Fill(datos,"Tabla");
                mensaje = "Se devolvio DataSet. Todo OK";
                return datos;
            }
            catch (Exception MiExc) { 
            
                System.Data.DataSet Data2;
                Data2 = new System.Data.DataSet();
                mensaje = "Se presentó un problemita "+MiExc.Message;
                return Data2;
            }
            finally {

                conn.Close();
            }
        }

        public System.Data.DataSet BuscarPorCampoClave()
        {
            try {

                String sentenciaSQL1;
                sentenciaSQL1 = "SELECT * FROM " +this.tabla +"WHERE "+ this.campoClave + "=" + this.datobusqueda+"'";
                conn.Open();
                System.Data.OleDb.OleDbDataAdapter objRes;
                objRes = new System.Data.OleDb.OleDbDataAdapter(sentenciaSQL1,conn);
                System.Data.DataSet datos;
                datos = new System.Data.DataSet();
                objRes.Fill(datos,"Tabla");
                mensaje = "Se devolvio DataSet. Todo OK";
                return datos;
            } 
            catch (Exception MiExc) {

                System.Data.DataSet datos2;
                datos2 = new System.Data.DataSet();
                mensaje = "Se presentó un problemita " + MiExc.Message;
                return datos2;
            } 
            finally {

                conn.Close();
            }
        }

    }
}
