using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBaseDatosLEPO.Logica
{
    public class Eliminar
    {
        private string codDes;
        private string resultado;

        DataTable dataTable;


        public string Resultado
        {

            get => resultado;
            set => resultado = value;
        }
        public string CodDes
        {

            get => codDes;
            set => codDes = value;
        }

        public DataTable TablaDescarga
        {

            get => dataTable;
            set => dataTable = value;
        }

        public void EliminarRegistro() {


            try
            {

                LogicaAppLEPO.Conexion objConexion;
                objConexion = new LogicaAppLEPO.Conexion();
                string SenSQL1;
                string SenSQL2;
                LogicaAppLEPO.Descarga objDescarga;
                objDescarga = new LogicaAppLEPO.Descarga();
                objDescarga.CodDescarga = codDes; 

                SenSQL1 = objDescarga.BorrarDescarga();

                objConexion.SetSentencia1(SenSQL1);
                objConexion.EjecutarSQL1();
                resultado = "Se borró la descarga " + objConexion.EjecutarSQL1();
            }
            catch (Exception es)
            {

                resultado = "Tenemos un problemita " + es.Message;
            }
        }
    }
}
