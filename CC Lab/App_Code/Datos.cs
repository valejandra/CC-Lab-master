using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CC_Lab.App_Code
{
    class Datos
    {
        public SqlConnection conexion;
        public string error;
        public SqlCommand comando;
        public SqlCommand cmd;
        public SqlDataAdapter adap;
        public DataSet tabla;
        public SqlDataReader dr;

        public Datos()
        {
            conexion = new SqlConnection(@"Data Source=ALEJANDRA\SQLEXPRESS;Initial Catalog=DBLAB;Integrated Security=True");
            conexion.Open();
        }

        public bool insertar_paciente(GSpaciente unPaciente)
        {
            bool IP = false;
            try
            {
                comando = new SqlCommand("insertPaciente");
                comando.Connection = conexion;
                comando.CommandType = CommandType.StoredProcedure;
                //  comando.Parameters.AddWithValue("@IDPACIENTE", unPaciente.carnePaciente);
                comando.Parameters.AddWithValue("@NOMBRES", unPaciente.nombreP);
                comando.Parameters.AddWithValue("@APELLIDOS", unPaciente.apellidoP);
                comando.Parameters.AddWithValue("@FECHA_NACIMIENTO", unPaciente.fechaNacimiento);
                comando.Parameters.AddWithValue("@TELEFONO", unPaciente.TelefonoP);
                comando.Parameters.AddWithValue("@DIRECCION", unPaciente.DirecPaciente);

                comando.ExecuteNonQuery();
                IP = true;
            }
            catch (Exception e)
            {
                error = e.Message;
            }
            return IP;
        }

        public bool insertar_resultado(GSANALISIS unRes) {
            bool ir = false;
            try {
                comando = new SqlCommand("insertarResultado");
                comando.Connection = conexion;
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@DESCRIPCION",unRes.Descripcion);
                comando.Parameters.AddWithValue("@RESULTADO",unRes.Resultado);
                comando.Parameters.AddWithValue("@IDTIPO_RESULTADO",unRes.Idtipo);

                comando.ExecuteNonQuery();
                ir = true;
            }
            catch(Exception e) {
                error = e.Message;
            }
            return ir;
        }
    }
}
