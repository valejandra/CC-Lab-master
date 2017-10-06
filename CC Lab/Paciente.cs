using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CC_Lab.App_Code;

namespace CC_Lab
{

    public partial class Paciente : Form
    {
        public SqlConnection conexion;
        public SqlCommand cmd;
        public SqlDataReader rd;
        public SqlDataAdapter adp;
        public DataTable tab;
        public string sql;

        Datos obj = new Datos();

        public Paciente()
        {
            InitializeComponent();
         
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            GSpaciente addp = new GSpaciente();
            addp.nombreP = textNombre.Text;
            addp.apellidoP = textApellido.Text;
            addp.fechaNacimiento = Convert.ToDateTime(textFecha.Text);
            addp.DirecPaciente = textDireccion.Text;
            addp.TelefonoP = Convert.ToInt32(textTelefono.Text);

            bool addpc = obj.insertar_paciente(addp);
            if (addpc)
            {
                labelmsj.Text = "Datos ingresados con exito";
                limpiar();
                rstfrm();
            }
            else
            {
                labelmsj.Text = obj.error;
            }
        }

        private void Paciente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dBLABDataSet.PACIENTE' Puede moverla o quitarla según sea necesario.
            this.pACIENTETableAdapter.Fill(this.dBLABDataSet.PACIENTE);

        }

        public void limpiar()
        {
            textNombre.Text = "";
            textApellido.Text = "";
            textFecha.Text = "";
            textDireccion.Text = "";
            textTelefono.Text = "";
        }

        private void bttnBuscar_Click(object sender, EventArgs e)
        {
            conexion = new SqlConnection(@"Data source = ALEJANDRA\SQLEXPRESS;Initial catalog = DBLAB; User id = sa;Password = 12345");
            conexion.Open();
            adp = new SqlDataAdapter("select * from PACIENTE where IDPACIENTE="+textBox7.Text+"", conexion);
            tab = new DataTable();
            adp.Fill(tab);
            this.dataGridView1.DataSource = tab;
            labelmsj.Text = "Exito";
            limpiar();
            conexion.Close();
        }

        private void bttnEliminar_Click(object sender, EventArgs e)
        {
            conexion = new SqlConnection(@"Data source = ALEJANDRA\SQLEXPRESS;Initial catalog = DBLAB; User id = sa;Password = 12345");
            conexion.Open();
            cmd = new SqlCommand("delete from PACIENTE where IDPACIENTE = " + textBox7.Text + ";");
            cmd.Connection = conexion;

            cmd.ExecuteNonQuery();
            labelmsj.Text = "Exito";
            limpiar();
            rstfrm();
            conexion.Close();
        }

        public void rstfrm() {
            conexion = new SqlConnection(@"Data source = ALEJANDRA\SQLEXPRESS;Initial catalog = DBLAB; User id = sa;Password = 12345");
            conexion.Open();
            adp = new SqlDataAdapter("select * from PACIENTE ", conexion);
            tab = new DataTable();
            adp.Fill(tab);
            this.dataGridView1.DataSource = tab;
        }
    }
}
