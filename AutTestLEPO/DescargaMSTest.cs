using LogicaAppLEPO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutTestLEPO
{
    [TestClass]
    public class DescargaMSTest
    {
        [TestMethod]
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
            Assert.AreEqual(insertarcadenaDescargaTest,resultado);
        }
    }
}
