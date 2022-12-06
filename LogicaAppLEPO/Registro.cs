using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaAppLEPO
{
    public class Registro
    {

        private string coDescar;
        private string subestacion;
        private string deltat;
        private string numRegistro;

        private string tpico;
        private string mpico;
        private string t10;
        private string m10;
        private string t90;
        private string m90;
        private string t50;
        private string m50;
        private string tasaAscenso;

        private string cadenacomando;


        //Encapsulado mediante propiedades
        public string CodDescarga
        {

            get => coDescar;
            set => coDescar = value;
        }

        
        public string Subestacion
        {

            get => subestacion;
            set => subestacion = value;
        }

        public string DeltaT
        {

            get => deltat;
            set => deltat = value;
        }

        public string NumRegistro
        {

            get => numRegistro;
            set => numRegistro = value;
        }

        public string TPico
        {

            get => tpico;
            set => tpico = value;
        }

        public string MPico
        {

            get => mpico;
            set => mpico = value;
        }

        public string T10
        {

            get => t10;
            set => t10 = value;
        }

        public string M10
        {

            get => m10;
            set => m10 = value;
        }

        public string T90
        {

            get => t90;
            set => t90 = value;
        }

        public string M90
        {

            get => m90;
            set => m90 = value;
        }

        public string T50
        {

            get => t50;
            set => t50 = value;
        }

        public string M50
        {

            get => m50;
            set => m50 = value;
        }

        public string TasaAscenso
        {

            get => tasaAscenso;
            set => tasaAscenso = value;
        }

        public void crearRegistro()
        {

            string insertarcadenaDescarga;
            insertarcadenaDescarga = "INSERT INTO Registro(NumRegistro,Subestacion,Dt,CodDescarga) VALUES ('" + this.numRegistro + "','" + this.subestacion + "','" + this.deltat + "','" + this.CodDescarga + "')" +
                "INSERT INTO Sobretension(MaPico,TPico,TasaAscenso,T10,T90,T50,V10,V90,V50,NumRegistro) VALUES ('" + this.mpico + "','" + this.tpico + "','" + this.tasaAscenso + "','" + this.t10 + "','" + this.t90 + "','" + this.t50 + "','" + this.m10 + "','" + this.m90 + "','" + this.m50 + "','" + this.numRegistro + "')";

            cadenacomando = insertarcadenaDescarga;
        }

        public string ConsultarTodosLosRegistros()
        {

            return @"SELECT * FROM	Registro AS R INNER JOIN Sobretension AS S ON (R.NumRegistro = S.NumRegistro)";

        }

        public string BorrarRegistro()
        {

            return @"DELETE  FROM Registro JOIN Sobretension ON (Registro.NumRegistro = Sobretension.NumRegistro) WHERE (NumRegistro LIKE'" + this.numRegistro + "')";

        }

        public string LeerCadenaComado()
        {
            return this.cadenacomando;
        }

    }
}
