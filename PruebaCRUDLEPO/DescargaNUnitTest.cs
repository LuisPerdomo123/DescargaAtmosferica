using LogicaAppLEPO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBaseDatosLEPO
{
    [TestFixture]
    public class DescargaNUnitTest
    {
        [Test]
        public void CrearDescarga_GetCadenaCorracta()
        {
            //Arrange
            //Inicializar las variables de la consulta SQL
            Descarga des = new();
            string magnitud = "20";
            string formaOnda = "8/20";
            string impCanal = "300";
            string porcImp = "50";
            string impXL = "15";
            string longlinea = "7";
            string lineaImpactada = "LA03";
            string codDescarga = "145";

            des.Magnitud = magnitud;
            des.FormaOnda = formaOnda;
            des.ImpCanal = impCanal;
            des.PorcImp = porcImp;
            des.ImpXl = impXL;
            des.LongLinea = longlinea;
            des.LineaImpactada = lineaImpactada;
            des.CodDescarga = codDescarga;


            string insertarcadenaDescargaTest = "INSERT INTO Descarga (IPicoRayo,FormaOnda,ImpedanciaCanal,ImpactoLinea,Impedancia,LongitudLinea,LineaImpactada,CodDescarga) VALUES ('" + magnitud + "','" + formaOnda + "','" + impCanal + "','" + porcImp + "','" + impXL + "','" + longlinea + "','" + lineaImpactada + "', '" + codDescarga + "')";

            //Act
            des.crearDescarga();
            string resultado = des.LeerCadenaComado();

            //assert comparación de resultados
            Assert.AreEqual(insertarcadenaDescargaTest, resultado);
        }

        [Test]

        public void grabar_GrabarDescarga() {

            int i;
            for (i = 0; i < 1000; i++)
            {
                AppBaseDatosLEPO.Logica.Grabar grabar = new AppBaseDatosLEPO.Logica.Grabar();

                grabar.FO = "70/20";
                grabar.Mag = "50";
                grabar.ImpCan = "300";
                grabar.PImp = "15";
                grabar.ImpLin = "7";
                grabar.LonLin = "50";
                grabar.LinImp = "LA38";
                grabar.CodDes = i.ToString();

                grabar.grabar();
          
                String Resultado = grabar.Resultado;

                Assert.AreEqual(" Se creo nuevo registro Todo OK", Resultado);
            }
        }

        [Test]

        public void LecturaDatas_LeerDescargas()
        {

            AppBaseDatosLEPO.Logica.Leer lecturaDescarga;
            lecturaDescarga = new AppBaseDatosLEPO.Logica.Leer();

            lecturaDescarga.LecturaDatos();
            DataTable tablaDatos = lecturaDescarga.TablaDescarga;
            String resultado = lecturaDescarga.Resultado;
            Assert.AreEqual("Se muestran todas las descargas registradas", resultado);
        }


        [Test]
        public void EliminarRegistro() {

            AppBaseDatosLEPO.Logica.Eliminar eliminarDato;
            eliminarDato = new AppBaseDatosLEPO.Logica.Eliminar();

            eliminarDato.CodDes = "30";
            eliminarDato.EliminarRegistro();
            string resultado = eliminarDato.Resultado;
            Assert.AreEqual("Se borró la descarga Todo OK", resultado);
        }

    }
}
