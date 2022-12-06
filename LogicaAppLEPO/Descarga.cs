using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAppLEPO
{
    public class Descarga
    {
        private string formaOnda;
        private string magnitud;
        private string impCanal;
        private string porcImp;
        private string impXl;
        private string longLinea;
        private string lineaImpactada;
        private string codDescarga;

        private string cadenacomando;

        //Encapsulado mediante propiedades
        public string FormaOnda
        {

            get => formaOnda;
            set => formaOnda = value;
        }

        public string Magnitud
        {

            get => magnitud;
            set => magnitud = value;
        }


        public string ImpCanal
        {
            get => impCanal;
            set => impCanal = value;
        }

        public string PorcImp
        {

            get => porcImp;
            set => porcImp = value;

        }

        public string ImpXl
        {

            get => impXl;
            set => impXl = value;
        }

        public string LongLinea
        {

            get => longLinea;
            set => longLinea = value;
        }

        public string LineaImpactada
        {

            get => lineaImpactada;
            set => lineaImpactada = value;
        }

        public string CodDescarga { 
        
            get => codDescarga;
            set => codDescarga = value;
        }


        public void crearDescarga()
        {

            string insertarcadenaDescarga;
            insertarcadenaDescarga = "INSERT INTO Descarga (IPicoRayo,FormaOnda,ImpedanciaCanal,ImpactoLinea,Impedancia,LongitudLinea,LineaImpactada,CodDescarga) VALUES ('" + this.magnitud + "','" + this.formaOnda + "','" + this.impCanal + "','" + this.porcImp + "','" + this.impXl + "','" + this.longLinea + "','" + this.lineaImpactada + "', '"+this.codDescarga+"')";
            cadenacomando = insertarcadenaDescarga;
        }

        public void modificarDescarga()
        {

            string modificarcadenaDescarga;
            modificarcadenaDescarga = @"UPDATE Descarga SET IPicoRayo='" + this.magnitud + "',FormaOnda='" + this.formaOnda + "',ImpedanciaCanal='" + this.ImpCanal + "',ImpactoLinea='" + this.porcImp + "',Impedancia='" + this.impXl + "',LongitudLinea='" + this.longLinea + "',LineaImpactada='" + this.lineaImpactada + "',CodDescarga='"+this.codDescarga+"'";
            cadenacomando = modificarcadenaDescarga;
        }

        public void seleccionarDescarga()
        {
            string selecDescarga;
            selecDescarga = "SELECT * FROM Descarga WHERE CodDescarga='" + this.CodDescarga + "'";
            cadenacomando = selecDescarga;

        }

        public string ConsultarDescarga()
        {

            Console.WriteLine("HolaDescarga/n");
            return @"SELECT * FROM Descarga WHERE (CodDescarga LIKE'" + this.codDescarga + "')";
            Console.WriteLine("FinDescarga/n");

        }
        public string BorrarDescarga()
        {

            return @"DELETE  FROM Descarga WHERE (CodDescarga LIKE'" + this.codDescarga + "')";

        }

        public string ConsultarTodosLasDescargas()
        {

            return @"SELECT * FROM Descarga";

        }

        public void borrarDescarga()
        {
            string borrarDescarga;
            borrarDescarga = "DELETE FROM Descarga WHERE CodDescarga='" + this.codDescarga + "'";
            cadenacomando = borrarDescarga;
        }

        public string LeerCadenaComado()
        {
            return this.cadenacomando;
        }
    }
}
