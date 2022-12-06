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
            
            

                AppBaseDatosLEPO.Logica.Grabar grabar = new AppBaseDatosLEPO.Logica.Grabar();

                grabar.FO = txtFO.Text;
                grabar.Mag = txtM.Text;
                grabar.ImpCan = txtImpCan.Text;
                grabar.PImp = txtPImp.Text;
                grabar.ImpLin = txtImpLin.Text;
                grabar.LonLin = txtLonLin.Text;
                grabar.LinImp = txtLinImp.Text;
                grabar.CodDes = txtCodDes.Text;

                grabar.grabar();
                lblResultado.Text = grabar.Resultado;




            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {

                LogicaAppLEPO.Conexion objConexion;
                objConexion = new LogicaAppLEPO.Conexion();
                string SenSQL1;
                string SqnSQL2;
                LogicaAppLEPO.Descarga objDescarga;
                objDescarga = new LogicaAppLEPO.Descarga();
                objDescarga.CodDescarga=txtCodDes.Text;

                SenSQL1 = objDescarga.ConsultarDescarga();
                objConexion.SetSentencia1(SenSQL1);

                lblResultado.Text = "Se muestran resultados de la consulta para Código de Descarga "+ txtCodDes.Text;

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


            AppBaseDatosLEPO.Logica.Leer lecturaDescarga;
            lecturaDescarga = new AppBaseDatosLEPO.Logica.Leer();

            lecturaDescarga.LecturaDatos();
            dataGridView1.DataSource = lecturaDescarga.TablaDescarga;
            lblResultado.Text = lecturaDescarga.Resultado;

        }

        private void btnBor_Click(object sender, EventArgs e)
        {

            //DateTime inicio = DateTime.Now;

            //double tiempo = DateTime.Now.Subtract(inicio).Milliseconds;

            //Console.WriteLine(tiempo);

            AppBaseDatosLEPO.Logica.Eliminar eliminarDato;
            eliminarDato = new AppBaseDatosLEPO.Logica.Eliminar();

            eliminarDato.CodDes = dataGridView1.CurrentCell.Value.ToString(); 
            eliminarDato.EliminarRegistro();
            lblResultado.Text = eliminarDato.Resultado;


        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            try {

                LogicaAppLEPO.Conexion objConexion;
                objConexion = new LogicaAppLEPO.Conexion();
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


                lblResultado.Text = " Se ha modificado el registro " + objConexion.EjecutarSQL1();

                
            } 
            catch (Exception es) {

                lblResultado.Text = "Tenemos el siguiente problemita: " + es.Message;
            }

        }

        private void lblImpCan_Click(object sender, EventArgs e)
        {

        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            
            AppBaseDatosLEPO.Form2 objForm2;
            objForm2 = new AppBaseDatosLEPO.Form2();
            string CodDescarga = txtCodDes.Text;
            objForm2.Cod_Descarga = CodDescarga;
            objForm2.Show();
            objForm2.codDescarga();

            //this.Close();

            
        }
    }
}
