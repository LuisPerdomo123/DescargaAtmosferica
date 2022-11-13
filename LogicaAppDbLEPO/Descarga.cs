using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAppDbLEPO
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

        private string cadenacomando;

        //Encapsulado mediante propiedades
        public string FormaOnda {

            get => formaOnda;
            set => formaOnda = value;
        }

        public string Magnitud { 
        
            get => magnitud;
            set => magnitud = value;
        }


        public string ImpCanal { 
            get => impCanal;
            set => impCanal = value;
        }

        public string PorcImp { 
        
            get => porcImp; 
            set => porcImp = value;

        }

        public string ImpXl { 
        
            get => impXl;
            set => impXl = value;
        }

        public string LongLinea { 
        
            get => longLinea; 
            set => longLinea = value;
        }

        public string LineaImpactada { 
        
            get => lineaImpactada;
            set => lineaImpactada = value;
        }


        public void crearDescarga() {

            string insertarcadenaDescarga;
            insertarcadenaDescarga = "INSERT INTO Descarga (IPicoRayo,FormaOnda,ImpedanciaCanal,ImpactoLinea,Impedancia,LongitudLinea,LineaImpactada) VALUES ('"+this.magnitud+"','"+this.formaOnda+"','"+this.ImpCanal+"','"+this.porcImp+"','"+this.ImpXl+"','"+this.longLinea+"','"+this.lineaImpactada+"')";
            cadenacomando = insertarcadenaDescarga;
        }

        public void modificarDescarga() {

            string modificarcadenaDescarga;
            modificarcadenaDescarga = @"UPDATE Descarga SET IPicoRayo='"+this.magnitud+"',FormaOnda='"+this.formaOnda+ "',ImpedanciaCanal='"+this.ImpCanal+"',ImpactoLinea='"+this.porcImp+"',Impedancia='"+this.impXl+"',LongitudLinea='"+this.longLinea+"',LineaImpactada='"+this.lineaImpactada+"'";
            cadenacomando = modificarcadenaDescarga;
        }

        public void seleccionarDescarga()
        {
            string selecDescarga;
            selecDescarga = "SELECT * FROM Descarga WHERE LineaImpactada='" + this.lineaImpactada + "'";
            cadenacomando = selecDescarga;

        }

        public string ConsultarDescarga()
        {

            return @"SELECT * FROM Descarga WHERE (LineaImpactada LIKE'" + this.lineaImpactada + "')";

        }
        public string BorrarDescarga()
        {

            return @"DELETE  FROM Descarga WHERE (LienaImpactada LIKE'" + this.lineaImpactada + "')";

        }

        public string ConsultarTodosLasDescargas()
        {

            return @"SELECT * FROM Desscarga";

        }

        public void borrarDescarga()
        {
            string borrarDescarga;
            borrarDescarga = "DELETE FROM Descarga WHERE LineaImpactada='" + this.lineaImpactada + "'";
            cadenacomando = borrarDescarga;
        }

        public string LeerCadenaComado()
        {
            return this.cadenacomando;
        }


    }
}
