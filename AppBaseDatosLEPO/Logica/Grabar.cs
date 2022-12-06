using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicaAppLEPO;

namespace AppBaseDatosLEPO.Logica
{
    public class Grabar
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

        private string cadenacomando;


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



        public void grabar(){

          
            

                try
                {

                    Conexion objConexion;
                    objConexion = new Conexion();
                    string SenSQL1;
                    string SenSQL2;
                    LogicaAppLEPO.Descarga objDescarga;
                    objDescarga = new LogicaAppLEPO.Descarga();


                    objDescarga.FormaOnda = fo;
                    objDescarga.Magnitud = m;
                    objDescarga.ImpCanal = impCan;
                    objDescarga.PorcImp = pImp;
                    objDescarga.ImpXl = impLin;
                    objDescarga.LongLinea = lonLin;
                    objDescarga.LineaImpactada = linImp;
                    objDescarga.CodDescarga = codDes;

                    objDescarga.crearDescarga();
                    SenSQL1 = objDescarga.LeerCadenaComado();
                    objConexion.SetSentencia1(SenSQL1);

                    resultado = " Se creo nuevo registro " + objConexion.EjecutarSQL1();



                }
                catch (Exception es)
                {

                    resultado = "Tenemos el siguiente problemita: " + es.Message;
                }
            
        }

    }
}
