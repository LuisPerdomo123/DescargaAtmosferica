using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBaseDatosLEPO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try {

                LogicaAppLEPO.conexion objConexion;
                objConexion = new LogicaAppLEPO.conexion();
                string SenSQL1;
                string SenSQL2;
                LogicaAppLEPO.Descarga objDescarga;
                objDescarga = new LogicaAppLEPO.Descarga();
                objDescarga.FormaOnda = txtFO.Text;
                objDescarga.Magnitud = txtM.Text;
                objDescarga.ImpCanal = txtImpCan.Text;
                objDescarga.PorcImp = txtPImp.Text;
                objDescarga.ImpXl = txtImpLin.Text;
                objDescarga.LongLinea = txtLonLin.Text;
                objDescarga.LineaImpactada = txtLinImp.Text;
                objDescarga.CodDescarga = txtCodDes.Text;

                objDescarga.crearDescarga();
                SenSQL1 = objDescarga.LeerCadenaComado();
                objConexion.SetSentencia1(SenSQL1);


                lblResultado.Text = " Se creo nuevo registro " + objConexion.EjecutarSQL1();

                txtCodDes.Enabled = false;
                btnGrabar.Enabled = false;

            } 
            catch (Exception es) {
            
                lblResultado.Text = "Tenemos el siguiente problemita: "+es.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {

                LogicaAppLEPO.conexion objConexion;
                objConexion = new LogicaAppLEPO.conexion();
                string SenSQL1;
                string SqnSQL2;
                LogicaAppLEPO.Descarga objDescarga;
                objDescarga = new LogicaAppLEPO.Descarga();
                objDescarga.CodDescarga=txtCodDes.Text;

                SenSQL1 = objDescarga.ConsultarDescarga();
                objConexion.SetSentencia1(SenSQL1);

                lblResultado.Text = "Se muestran resultados de la consulta para cédula "+ txtCodDes.Text;

                System.Data.DataSet miDS;
                miDS = new System.Data.DataSet();
                miDS = objConexion.Consultar();

                int seleccionados;
                seleccionados = miDS.Tables["Tabla"].Rows.Count;

                if (seleccionados==0) {

                    txtCodDes.Text = "No se encuentra Datos";
                    txtFO.Text = "";
                    txtImpCan.Text = "";
                    txtImpLin.Text = "";
                    txtLinImp.Text = "";
                    txtLonLin.Text = "";
                    txtM.Text = "";
                    txtPImp.Text = "";
                }
                else {

                    txtCodDes.Text = miDS.Tables["Tabla"].Rows[0]["CodDescarga"].ToString();
                    txtFO.Text = miDS.Tables["Tabla"].Rows[0]["FormaOnda"].ToString();
                    txtImpCan.Text = miDS.Tables["Tabla"].Rows[0]["ImpedanciaCanal"].ToString();
                    txtImpLin.Text = miDS.Tables["Tabla"].Rows[0]["Impedancia"].ToString();
                    txtLinImp.Text = miDS.Tables["Tabla"].Rows[0]["LineaImpactada"].ToString();
                    txtLonLin.Text = miDS.Tables["Tabla"].Rows[0]["LongitudLinea"].ToString();
                    txtM.Text = miDS.Tables["Tabla"].Rows[0]["IPicoRayo"].ToString();
                    txtPImp.Text = miDS.Tables["Tabla"].Rows[0]["ImpactoLinea"].ToString();
                }

            }
            catch(Exception es){

                lblResultado.Text = "Hubo un problemita " + es.Message;
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            try {

                LogicaAppLEPO.conexion objConexion;
                objConexion = new LogicaAppLEPO.conexion();
                string SenSQL1;
                string SenSQL2;
                LogicaAppLEPO.Descarga objDescarga;
                objDescarga = new LogicaAppLEPO.Descarga();

                SenSQL1 = objDescarga.ConsultarTodosLasDescargas();
                objConexion.SetSentencia1(SenSQL1);
                lblResultado.Text = "Se muestran todos los clientes";

                System.Data.DataSet miDS;
                miDS = new System.Data.DataSet();
                miDS = objConexion.Consultar();

                int seleccionados;
                seleccionados = miDS.Tables["Tabla"].Rows.Count;

                if (seleccionados == 0)
                {

                    lbCodDes.Text = "No se encuentra Datos";
                    lblForOn.Text = " ";
                    lblImpCan.Text = " ";
                    lblImpLin.Text = " ";
                    lblLinImp.Text = " ";
                    lblLonLin.Text = " ";
                    lblMag.Text = " ";
                    lblPorImp.Text = " ";
                }
                else
                {

                    dataGridView1.DataSource = miDS.Tables["Tabla"];
                }
            } 
            
            catch (Exception es) {

                lblResultado.Text = "Tenemos un problemita "+es.Message;
            }

        }

        private void btnBor_Click(object sender, EventArgs e)
        {
            try
            {

                LogicaAppLEPO.conexion objConexion;
                objConexion = new LogicaAppLEPO.conexion();
                string SenSQL1;
                string SenSQL2;
                LogicaAppLEPO.Descarga objDescarga;
                objDescarga = new LogicaAppLEPO.Descarga();
                objDescarga.CodDescarga = dataGridView1.CurrentCell.Value.ToString(); // txtCodDes.Text; ;

                SenSQL1 = objDescarga.BorrarDescarga();

                objConexion.SetSentencia1(SenSQL1);
                objConexion.EjecutarSQL1();
                lblResultado.Text = "Se borró la descarga "+txtCodDes.Text+" "+objConexion.EjecutarSQL1();
            } 
            catch (Exception es) {

                lblResultado.Text = "Tenemos un problemita "+es.Message;
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            try {

                LogicaAppLEPO.conexion objConexion;
                objConexion = new LogicaAppLEPO.conexion();
                string SenSQL1;
                string SenSQL2;
                LogicaAppLEPO.Descarga objDescarga;
                objDescarga = new LogicaAppLEPO.Descarga();
                objDescarga.FormaOnda = dataGridView1.CurrentRow.Cells[2].Value.ToString(); //txtFO.Text;
                objDescarga.Magnitud = dataGridView1.CurrentRow.Cells[1].Value.ToString(); //txtM.Text;
                objDescarga.ImpCanal = dataGridView1.CurrentRow.Cells[3].Value.ToString(); //txtImpCan.Text;
                objDescarga.PorcImp = dataGridView1.CurrentRow.Cells[4].Value.ToString(); //txtPImp.Text;
                objDescarga.ImpXl = dataGridView1.CurrentRow.Cells[5].Value.ToString(); //txtImpLin.Text;
                objDescarga.LongLinea = dataGridView1.CurrentRow.Cells[6].Value.ToString(); //txtLonLin.Text;
                objDescarga.LineaImpactada = dataGridView1.CurrentRow.Cells[7].Value.ToString(); //txtLinImp.Text;
                objDescarga.CodDescarga = dataGridView1.CurrentRow.Cells[0].Value.ToString(); //txtCodDes.Text;

                objDescarga.modificarDescarga();

                SenSQL1 = objDescarga.LeerCadenaComado();
                objConexion.SetSentencia1(SenSQL1);


                lblResultado.Text = " Se creo nuevo registro " + objConexion.EjecutarSQL1();

                txtCodDes.Enabled = false;
                btnGrabar.Enabled = false;
            } 
            catch (Exception es) {

                lblResultado.Text = "Tenemos el siguiente problemita: " + es.Message;
            }

        }
    }
}
