using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CC_Lab.App_Code
{
    class GSANALISIS
    {
        private int idresultado;
        private string descripcion;
        private string resultado;
        private int idtiporesultado;

        public GSANALISIS(int idresultado, string descripcion, string resultado, int idtiporesultado)
        {
            this.idresultado = idresultado;
            this.descripcion = descripcion;
            this.resultado = resultado;
            this.idtiporesultado = idtiporesultado;
        }

        public GSANALISIS()
        {
        }

        public int IDresultado {
            get { return idresultado; }
            set { idresultado = value; }

        }

        public string Descripcion {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string Resultado {
            get { return resultado; }
            set { resultado = value; }
        }

        public int Idtipo {
            get { return idtiporesultado; }
            set { idtiporesultado = value; }
        }
    }


}
