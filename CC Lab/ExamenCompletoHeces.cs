using CC_Lab.App_Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CC_Lab
{
    public partial class ExamenCompletoHeces : Form
    {
        public ExamenCompletoHeces()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            GSANALISIS addr = new GSANALISIS();
            addr.Resultado = textColor.Text;
            addr.Resultado = textRestos.Text;
            addr.Resultado = textAspecto.Text;
            addr.Resultado = textMoco.Text;
            addr.Resultado = textPH.Text;
            addr.Resultado = textSangre.Text;
            addr.Resultado = textSangreO.Text;
            addr.Resultado = textCV.Text;
            addr.Resultado = textGrasas.Text;
            addr.Resultado = textLeucositos.Text;
            addr.Resultado = textBacterias.Text;
            addr.Resultado = textAlmidones.Text;
            addr.Resultado = textJabones.Text;
            addr.Resultado = textEritrocitos.Text;
            addr.Resultado = textLevaduras.Text;
            addr.Resultado = textTrofo.Text;
            addr.Resultado = textQuistes.Text;
            addr.Resultado = textHuevos.Text;
            addr.Resultado = textLarvas.Text;
            addr.Resultado = textOtros.Text;

        }
    }
}
