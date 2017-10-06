using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CC_Lab
{
    public partial class Analisis : Form
    {

        SqlConnection conexion = new SqlConnection(@"Data source = ALEJANDRA\SQLEXPRESS;Initial catalog = DBLAB; User id = sa;Password = 12345");
        public SqlCommand cmd;
        public SqlDataReader rd;
        public SqlDataAdapter adap;
        public string sql;


        public Analisis()
        {
            InitializeComponent();
        }

        public void cmb()
        {
            conexion.Open();
            cmd = new SqlCommand("select IDMUESTRA, DESCRIPCION from muestra", conexion);
            adap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            conexion.Close();

            DataRow fila = dt.NewRow();
            fila["DESCRIPCION"] = "Seleccione una muestra";
            dt.Rows.InsertAt(fila, 0);
            comboBox1.ValueMember = "IDMUESTRA";
            comboBox1.DisplayMember = "DESCRIPCION";
            comboBox1.DataSource = dt;
        }

        public void cmb2(string MUESTRA)
        {
            conexion = new SqlConnection(@"Data source = ALEJANDRA\SQLEXPRESS;Initial catalog = DBLAB; User id = sa;Password = 12345");
            conexion.Open();
            cmd = new SqlCommand("select DESCRIPCION from TIPO_ANALISIS where IDMUESTRA=@IDMUESTRA", conexion);
            cmd.Parameters.AddWithValue("IDMUESTRA", MUESTRA);
            adap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            conexion.Close();

            DataRow dtr = dt.NewRow();
            dtr["DESCRIPCION"] = "Seleccion un analisis";
            dt.Rows.InsertAt(dtr, 0);
            comboBox2.ValueMember = "IDTIPOANALISIS";
            comboBox2.DisplayMember = "DESCRIPCION";
            comboBox2.DataSource = dt;
        }

        public void cmb3(string IDTIPOANALISIS)
        {
            conexion = new SqlConnection(@"Data source = ALEJANDRA\SQLEXPRESS;Initial catalog = DBLAB; User id = sa;Password = 12345");
            conexion.Open();
            cmd = new SqlCommand("select IDTIPO_RESULTADO, DESCRIPCION from tipo_resultado where IDTIPOANALISIS=@IDTIPOANALISIS", conexion);
            cmd.Parameters.AddWithValue("IDTIPOANALISIS", IDTIPOANALISIS);
            adap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            conexion.Close();

            DataRow dtr = dt.NewRow();
            dtr["DESCRIPCION"] = "Seleccion Tipo Analisis";
            dt.Rows.InsertAt(dtr, 0);
            comboBox3.ValueMember = "IDTIPO_RESULTADO";
            comboBox3.DisplayMember = "DESCRIPCION";
            comboBox3.DataSource = dt;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.ToString() != null)
            {
                string idmuestra = comboBox1.SelectedValue.ToString();
                cmb2(idmuestra);
            }
        }

        private void Analisis_Load(object sender, EventArgs e)
        {
            cmb();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue.ToString() != null)
            {
                string tipo = comboBox2.SelectedValue.ToString();
               // cmb3(tipo);
            }
        }
    }
}

