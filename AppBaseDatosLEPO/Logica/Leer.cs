using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBaseDatosLEPO.Logica
{
    public class Leer
    {
        private string fo;
        private string m;
        private string impCan;
        private string pImp;
        private string impLin;
        private string lonLin;
        private string linImp;
        private string codDes;
        private string resultado;

        DataTable tablaDescarga;

        //Encapsulado mediante propiedades
        public string FO
        {

            get => fo;
            set => fo = value;
        }

        public string Mag
        {

            get => m;
            set => m = value;
        }
        public string ImpCan
        {

            get => impCan;
            set => impCan = value;
        }
        public string PImp
        {

            get => pImp;
            set => pImp = value;
        }
        public string ImpLin
        {

            get => impLin;
            set => impLin = value;
        }
        public string LonLin
        {

            get => lonLin;
            set => lonLin = value;
        }
        public string LinImp
        {

            get => linImp;
            set => linImp = value;
        }

        public string CodDes
        {

            get => codDes;
            set => codDes = value;
        }

        public string Resultado
        {

            get => resultado;
            set => resultado = value;
        }

        public DataTable TablaDescarga
        {

            get => tablaDescarga;
            set => tablaDescarga = value;
        }

        public void LecturaDatos() {


            try
            {

                LogicaAppLEPO.Conexion objConexion;
                objConexion = new LogicaAppLEPO.Conexion();
                string SenSQL1;
                string SenSQL2;
                LogicaAppLEPO.Descarga objDescarga;
                objDescarga = new LogicaAppLEPO.Descarga();

                SenSQL1 = objDescarga.ConsultarTodosLasDescargas();
                objConexion.SetSentencia1(SenSQL1);
                

                System.Data.DataSet miDS;
                miDS = new System.Data.DataSet();
                miDS = objConexion.Consultar();

                int seleccionados;
                seleccionados = miDS.Tables["Tabla"].Rows.Count;

                resultado = "Se muestran todas las descargas registradas";

                if (seleccionados == 0)
                {

                    codDes = "No se encuentra Datos";
                    fo = " ";
                    impCan = " ";
                    impLin = " ";
                    linImp = " ";
                    lonLin = " ";
                    m = " ";
                    pImp = " ";
                }
                else
                {
                    
                    tablaDescarga = miDS.Tables["Tabla"];
                }
            }

            catch (Exception es)
            {

                 resultado = "Tenemos un problemita " + es.Message;
            }
        }
    }
}
