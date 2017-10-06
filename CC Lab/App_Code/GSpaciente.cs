using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CC_Lab
{
    class GSpaciente
    {

        private int carne;
        private string nombre;
        private string apellido;
        private string direccion;
        private int telefono;
        private DateTime fecha;

        public GSpaciente()
        {

        }

        public GSpaciente(int carne, string nombre, string apellido, DateTime fecha, string direccion, int telefono)
        {
            this.carne = carne;
            this.nombre = nombre;
            this.apellido = apellido;
            this.fecha = fecha;
            this.direccion = direccion;
            this.telefono = telefono;

        }

        public int carnePaciente
        {
            get { return carne; }
            set { carne = value; }
        }

        public string nombreP
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string apellidoP
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public DateTime fechaNacimiento {
            get { return fecha; }
            set { fecha = value; }
        }

        public string DirecPaciente
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public int TelefonoP
        {
            get { return telefono; }
            set { telefono = value; }
        }
    }

 
}
