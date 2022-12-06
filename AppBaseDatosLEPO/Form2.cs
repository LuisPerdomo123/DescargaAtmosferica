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
    public partial class Form2 : Form
    {

        private string cod_Descarga;

        public string Cod_Descarga {

            get => cod_Descarga;
            set => cod_Descarga = value;
        }

        public Form2()
        {
            
            InitializeComponent();
            
        }

        public void codDescarga() {

            lblCodDes.Text = cod_Descarga;
        }
        


        private void button1_Click(object sender, EventArgs e)
        {
            AppBaseDatosLEPO.Form1 objForm1;
            objForm1 = new AppBaseDatosLEPO.Form1();
            objForm1.Show();
            

            this.Close();
        }

        private void Crear2_Click(object sender, EventArgs e)
        {
            try
            {

                LogicaAppLEPO.Conexion objConexion;
                objConexion = new LogicaAppLEPO.Conexion();
                string SenSQL1;
                string SenSQL2;
                LogicaAppLEPO.Registro objRegistro;
                objRegistro = new LogicaAppLEPO.Registro();
                objRegistro.NumRegistro = txtNoRegis.Text;
                objRegistro.Subestacion = listSubes.Text;
                objRegistro.DeltaT = txtdeltat.Text;
                objRegistro.CodDescarga = lblCodDes.Text;
                objRegistro.MPico = txtMagPico.Text;
                objRegistro.TPico = txtTPico.Text;
                objRegistro.TasaAscenso = txtTasaAsc.Text;
                objRegistro.T10 = txtTiem10.Text;
                objRegistro.T90 = txtTiem90.Text;
                objRegistro.T50 = txtTiem50.Text;
                objRegistro.M10 = txtMag10.Text;
                objRegistro.M90 = txtMag90.Text;
                objRegistro.M50 = txtMag50.Text;
                

                objRegistro.crearRegistro();
                SenSQL1 = objRegistro.LeerCadenaComado();
                objConexion.SetSentencia1(SenSQL1);


                lblResul2.Text = " Se creo nuevo registro " + objConexion.EjecutarSQL1();


            }
            catch (Exception es)
            {

                lblResul2.Text = "Tenemos el siguiente problemita: " + es.Message;
            }
        }

        private void buscar2_Click(object sender, EventArgs e)
        {
            try
            {

                LogicaAppLEPO.Conexion objConexion;
                objConexion = new LogicaAppLEPO.Conexion();
                string SenSQL1;
                string SenSQL2;
                LogicaAppLEPO.Registro objRegistro;
                objRegistro = new LogicaAppLEPO.Registro();

                SenSQL1 = objRegistro.ConsultarTodosLosRegistros();
                objConexion.SetSentencia1(SenSQL1);
                lblResul2.Text = "Se muestran todos los registros de desargas eléctricas atmosféricas";

                System.Data.DataSet miDS;
                miDS = new System.Data.DataSet();
                miDS = objConexion.Consultar();

                int seleccionados;
                seleccionados = miDS.Tables["Tabla"].Rows.Count;

                if (seleccionados == 0)
                {

                txtNoRegis.Text = "";
                listSubes.Text = "";
                txtdeltat.Text = "";
                lblCodDes.Text = "";
                txtMagPico.Text = "";
                txtTPico.Text = "";
                txtTasaAsc.Text = "";
                txtTiem10.Text = "";
                txtTiem90.Text = "";
                txtTiem50.Text = "";
                txtMag10.Text = "";
                txtMag90.Text = "";
                txtMag50.Text = "";
                }
                else
                {

                    dataGridView1.DataSource = miDS.Tables["Tabla"];
                }
            }

            catch (Exception es)
            {

                lblResul2.Text = "Tenemos un problemita " + es.Message;
            }
        }

        private void elim2_Click(object sender, EventArgs e)
        {
            try
            {

                LogicaAppLEPO.Conexion objConexion;
                objConexion = new LogicaAppLEPO.Conexion();
                string SenSQL1;
                string SenSQL2;
                LogicaAppLEPO.Registro objRegistro;
                objRegistro = new LogicaAppLEPO.Registro();
                objRegistro.NumRegistro = dataGridView1.CurrentCell.Value.ToString(); 

                SenSQL1 = objRegistro.BorrarRegistro();

                objConexion.SetSentencia1(SenSQL1);
                objConexion.EjecutarSQL1();
                lblResul2.Text = "Se borrado el registro de descarga eléctrica atmosférica " + objRegistro.NumRegistro + " " + objConexion.EjecutarSQL1();
            }
            catch (Exception es)
            {

                lblResul2.Text = "Tenemos un problemita " + es.Message;
            }
        }

        private void actual2_Click(object sender, EventArgs e)
        {

        }
    }
}
