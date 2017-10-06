namespace CC_Lab
{
    partial class Paciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textFecha = new System.Windows.Forms.TextBox();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDPACIENTEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOMBRESDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPELLIDOSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fECHANACIMIENTODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tELEFONODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIRECCIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pACIENTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBLABDataSet = new CC_Lab.DBLABDataSet();
            this.bttnEliminar = new System.Windows.Forms.Button();
            this.bttnBuscar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pACIENTETableAdapter = new CC_Lab.DBLABDataSetTableAdapters.PACIENTETableAdapter();
            this.labelmsj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACIENTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLABDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(94, 26);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(233, 20);
            this.textNombre.TabIndex = 1;
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(386, 26);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(234, 20);
            this.textApellido.TabIndex = 2;
            // 
            // textFecha
            // 
            this.textFecha.Location = new System.Drawing.Point(156, 58);
            this.textFecha.Name = "textFecha";
            this.textFecha.Size = new System.Drawing.Size(96, 20);
            this.textFecha.TabIndex = 3;
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(684, 26);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(100, 20);
            this.textTelefono.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(333, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha de nacimiento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Dirección:";
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(319, 58);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(271, 20);
            this.textDireccion.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(626, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Telefono:";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(129, 114);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 83;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 85;
            this.label7.Text = "Carne paciente:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPACIENTEDataGridViewTextBoxColumn,
            this.nOMBRESDataGridViewTextBoxColumn,
            this.aPELLIDOSDataGridViewTextBoxColumn,
            this.fECHANACIMIENTODataGridViewTextBoxColumn,
            this.tELEFONODataGridViewTextBoxColumn,
            this.dIRECCIONDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pACIENTEBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(83, 179);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 158);
            this.dataGridView1.TabIndex = 86;
            // 
            // iDPACIENTEDataGridViewTextBoxColumn
            // 
            this.iDPACIENTEDataGridViewTextBoxColumn.DataPropertyName = "IDPACIENTE";
            this.iDPACIENTEDataGridViewTextBoxColumn.HeaderText = "IDPACIENTE";
            this.iDPACIENTEDataGridViewTextBoxColumn.Name = "iDPACIENTEDataGridViewTextBoxColumn";
            this.iDPACIENTEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nOMBRESDataGridViewTextBoxColumn
            // 
            this.nOMBRESDataGridViewTextBoxColumn.DataPropertyName = "NOMBRES";
            this.nOMBRESDataGridViewTextBoxColumn.HeaderText = "NOMBRES";
            this.nOMBRESDataGridViewTextBoxColumn.Name = "nOMBRESDataGridViewTextBoxColumn";
            // 
            // aPELLIDOSDataGridViewTextBoxColumn
            // 
            this.aPELLIDOSDataGridViewTextBoxColumn.DataPropertyName = "APELLIDOS";
            this.aPELLIDOSDataGridViewTextBoxColumn.HeaderText = "APELLIDOS";
            this.aPELLIDOSDataGridViewTextBoxColumn.Name = "aPELLIDOSDataGridViewTextBoxColumn";
            // 
            // fECHANACIMIENTODataGridViewTextBoxColumn
            // 
            this.fECHANACIMIENTODataGridViewTextBoxColumn.DataPropertyName = "FECHA_NACIMIENTO";
            this.fECHANACIMIENTODataGridViewTextBoxColumn.HeaderText = "FECHA_NACIMIENTO";
            this.fECHANACIMIENTODataGridViewTextBoxColumn.Name = "fECHANACIMIENTODataGridViewTextBoxColumn";
            // 
            // tELEFONODataGridViewTextBoxColumn
            // 
            this.tELEFONODataGridViewTextBoxColumn.DataPropertyName = "TELEFONO";
            this.tELEFONODataGridViewTextBoxColumn.HeaderText = "TELEFONO";
            this.tELEFONODataGridViewTextBoxColumn.Name = "tELEFONODataGridViewTextBoxColumn";
            // 
            // dIRECCIONDataGridViewTextBoxColumn
            // 
            this.dIRECCIONDataGridViewTextBoxColumn.DataPropertyName = "DIRECCION";
            this.dIRECCIONDataGridViewTextBoxColumn.HeaderText = "DIRECCION";
            this.dIRECCIONDataGridViewTextBoxColumn.Name = "dIRECCIONDataGridViewTextBoxColumn";
            // 
            // pACIENTEBindingSource
            // 
            this.pACIENTEBindingSource.DataMember = "PACIENTE";
            this.pACIENTEBindingSource.DataSource = this.dBLABDataSet;
            // 
            // dBLABDataSet
            // 
            this.dBLABDataSet.DataSetName = "DBLABDataSet";
            this.dBLABDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bttnEliminar
            // 
            this.bttnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bttnEliminar.Image = global::CC_Lab.Properties.Resources.if_trash_mail_44948;
            this.bttnEliminar.Location = new System.Drawing.Point(283, 107);
            this.bttnEliminar.Name = "bttnEliminar";
            this.bttnEliminar.Size = new System.Drawing.Size(32, 33);
            this.bttnEliminar.TabIndex = 84;
            this.bttnEliminar.UseVisualStyleBackColor = false;
            this.bttnEliminar.Click += new System.EventHandler(this.bttnEliminar_Click);
            // 
            // bttnBuscar
            // 
            this.bttnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bttnBuscar.Image = global::CC_Lab.Properties.Resources.if_Zoom_SH_131520__1_;
            this.bttnBuscar.Location = new System.Drawing.Point(245, 107);
            this.bttnBuscar.Name = "bttnBuscar";
            this.bttnBuscar.Size = new System.Drawing.Size(32, 33);
            this.bttnBuscar.TabIndex = 82;
            this.bttnBuscar.UseVisualStyleBackColor = false;
            this.bttnBuscar.Click += new System.EventHandler(this.bttnBuscar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Red;
            this.btnAgregar.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Image = global::CC_Lab.Properties.Resources.if_list_add_118777;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.Location = new System.Drawing.Point(617, 58);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(79, 30);
            this.btnAgregar.TabIndex = 81;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pACIENTETableAdapter
            // 
            this.pACIENTETableAdapter.ClearBeforeFill = true;
            // 
            // labelmsj
            // 
            this.labelmsj.AutoSize = true;
            this.labelmsj.Location = new System.Drawing.Point(44, 141);
            this.labelmsj.Name = "labelmsj";
            this.labelmsj.Size = new System.Drawing.Size(0, 13);
            this.labelmsj.TabIndex = 87;
            // 
            // Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(819, 449);
            this.Controls.Add(this.labelmsj);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bttnEliminar);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.bttnBuscar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textTelefono);
            this.Controls.Add(this.textFecha);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNombre);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Paciente";
            this.Text = "Paciente";
            this.Load += new System.EventHandler(this.Paciente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACIENTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLABDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textFecha;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button bttnBuscar;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button bttnEliminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DBLABDataSet dBLABDataSet;
        private System.Windows.Forms.BindingSource pACIENTEBindingSource;
        private DBLABDataSetTableAdapters.PACIENTETableAdapter pACIENTETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPACIENTEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOMBRESDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPELLIDOSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fECHANACIMIENTODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tELEFONODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIRECCIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelmsj;
    }
}