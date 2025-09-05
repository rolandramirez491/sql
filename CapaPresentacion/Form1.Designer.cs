namespace CapaPresentacion
{
    partial class frmPrinciapal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbcOpciones = new System.Windows.Forms.TabControl();
            this.tbpRegistrar = new System.Windows.Forms.TabPage();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpBuscar = new System.Windows.Forms.TabPage();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkEditar = new System.Windows.Forms.CheckBox();
            this.txtGeneroA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDuracionA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbpListar = new System.Windows.Forms.TabPage();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtHoraFuncA = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCantBoletasA = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbcOpciones.SuspendLayout();
            this.tbpRegistrar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbpBuscar.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tbpListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcOpciones
            // 
            this.tbcOpciones.Controls.Add(this.tbpRegistrar);
            this.tbcOpciones.Controls.Add(this.tbpBuscar);
            this.tbcOpciones.Controls.Add(this.tbpListar);
            this.tbcOpciones.Location = new System.Drawing.Point(-6, -3);
            this.tbcOpciones.Margin = new System.Windows.Forms.Padding(2);
            this.tbcOpciones.Name = "tbcOpciones";
            this.tbcOpciones.SelectedIndex = 0;
            this.tbcOpciones.Size = new System.Drawing.Size(458, 288);
            this.tbcOpciones.TabIndex = 0;
            // 
            // tbpRegistrar
            // 
            this.tbpRegistrar.Controls.Add(this.btnRegistrar);
            this.tbpRegistrar.Controls.Add(this.btnNuevo);
            this.tbpRegistrar.Controls.Add(this.groupBox1);
            this.tbpRegistrar.Location = new System.Drawing.Point(4, 22);
            this.tbpRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.tbpRegistrar.Name = "tbpRegistrar";
            this.tbpRegistrar.Padding = new System.Windows.Forms.Padding(2);
            this.tbpRegistrar.Size = new System.Drawing.Size(450, 262);
            this.tbpRegistrar.TabIndex = 0;
            this.tbpRegistrar.Text = "Registrar Pelicula";
            this.tbpRegistrar.UseVisualStyleBackColor = true;
            this.tbpRegistrar.Click += new System.EventHandler(this.tbpRegistrar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Image = global::CapaPresentacion.Properties.Resources.guardar;
            this.btnRegistrar.Location = new System.Drawing.Point(398, 40);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(37, 37);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::CapaPresentacion.Properties.Resources.nuevo;
            this.btnNuevo.Location = new System.Drawing.Point(398, 83);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(37, 34);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtGenero);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDuracion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(368, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Pelicula";
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(91, 117);
            this.txtGenero.Margin = new System.Windows.Forms.Padding(2);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(167, 20);
            this.txtGenero.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Genero:";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(91, 87);
            this.txtDuracion.Margin = new System.Windows.Forms.Padding(2);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(83, 20);
            this.txtDuracion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Duracion:";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(91, 55);
            this.txtNom.Margin = new System.Windows.Forms.Padding(2);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(167, 20);
            this.txtNom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(91, 23);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(83, 20);
            this.txtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // tbpBuscar
            // 
            this.tbpBuscar.Controls.Add(this.btnActualizar);
            this.tbpBuscar.Controls.Add(this.btnEliminar);
            this.tbpBuscar.Controls.Add(this.groupBox2);
            this.tbpBuscar.Location = new System.Drawing.Point(4, 22);
            this.tbpBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.tbpBuscar.Name = "tbpBuscar";
            this.tbpBuscar.Padding = new System.Windows.Forms.Padding(2);
            this.tbpBuscar.Size = new System.Drawing.Size(450, 262);
            this.tbpBuscar.TabIndex = 1;
            this.tbpBuscar.Text = "Buscar Pelicula";
            this.tbpBuscar.UseVisualStyleBackColor = true;
            this.tbpBuscar.Click += new System.EventHandler(this.tbpBuscar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Image = global::CapaPresentacion.Properties.Resources.actualizar;
            this.btnActualizar.Location = new System.Drawing.Point(400, 42);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(37, 37);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::CapaPresentacion.Properties.Resources.eliminar;
            this.btnEliminar.Location = new System.Drawing.Point(400, 85);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(37, 34);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtCantBoletasA);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtHoraFuncA);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.chkEditar);
            this.groupBox2.Controls.Add(this.txtGeneroA);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtDuracionA);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtNomA);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtIdA);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(15, 17);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(368, 231);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de la Pelicula";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // chkEditar
            // 
            this.chkEditar.AutoSize = true;
            this.chkEditar.Location = new System.Drawing.Point(250, 22);
            this.chkEditar.Margin = new System.Windows.Forms.Padding(2);
            this.chkEditar.Name = "chkEditar";
            this.chkEditar.Size = new System.Drawing.Size(53, 17);
            this.chkEditar.TabIndex = 8;
            this.chkEditar.Text = "Editar";
            this.chkEditar.UseVisualStyleBackColor = true;
            this.chkEditar.CheckedChanged += new System.EventHandler(this.chkEditar_CheckedChanged);
            // 
            // txtGeneroA
            // 
            this.txtGeneroA.Enabled = false;
            this.txtGeneroA.Location = new System.Drawing.Point(133, 117);
            this.txtGeneroA.Margin = new System.Windows.Forms.Padding(2);
            this.txtGeneroA.Name = "txtGeneroA";
            this.txtGeneroA.Size = new System.Drawing.Size(167, 20);
            this.txtGeneroA.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Genero:";
            // 
            // txtDuracionA
            // 
            this.txtDuracionA.Enabled = false;
            this.txtDuracionA.Location = new System.Drawing.Point(133, 87);
            this.txtDuracionA.Margin = new System.Windows.Forms.Padding(2);
            this.txtDuracionA.Name = "txtDuracionA";
            this.txtDuracionA.Size = new System.Drawing.Size(83, 20);
            this.txtDuracionA.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Duracion:";
            // 
            // txtNomA
            // 
            this.txtNomA.Enabled = false;
            this.txtNomA.Location = new System.Drawing.Point(133, 55);
            this.txtNomA.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomA.Name = "txtNomA";
            this.txtNomA.Size = new System.Drawing.Size(167, 20);
            this.txtNomA.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nombre:";
            // 
            // txtIdA
            // 
            this.txtIdA.Location = new System.Drawing.Point(133, 23);
            this.txtIdA.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdA.Name = "txtIdA";
            this.txtIdA.Size = new System.Drawing.Size(83, 20);
            this.txtIdA.TabIndex = 1;
            this.txtIdA.TextChanged += new System.EventHandler(this.txtIdA_TextChanged);
            this.txtIdA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdA_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Cod:";
            // 
            // tbpListar
            // 
            this.tbpListar.Controls.Add(this.btnListar);
            this.tbpListar.Controls.Add(this.dgvEmpleados);
            this.tbpListar.Location = new System.Drawing.Point(4, 22);
            this.tbpListar.Margin = new System.Windows.Forms.Padding(2);
            this.tbpListar.Name = "tbpListar";
            this.tbpListar.Size = new System.Drawing.Size(450, 262);
            this.tbpListar.TabIndex = 2;
            this.tbpListar.Text = "Listar Peliculas";
            this.tbpListar.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            this.btnListar.Image = global::CapaPresentacion.Properties.Resources.lista;
            this.btnListar.Location = new System.Drawing.Point(410, 14);
            this.btnListar.Margin = new System.Windows.Forms.Padding(2);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(37, 37);
            this.btnListar.TabIndex = 12;
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(2, 2);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.Size = new System.Drawing.Size(404, 259);
            this.dgvEmpleados.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 149);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Hora Funcion:";
            // 
            // txtHoraFuncA
            // 
            this.txtHoraFuncA.Enabled = false;
            this.txtHoraFuncA.Location = new System.Drawing.Point(133, 146);
            this.txtHoraFuncA.Margin = new System.Windows.Forms.Padding(2);
            this.txtHoraFuncA.Name = "txtHoraFuncA";
            this.txtHoraFuncA.Size = new System.Drawing.Size(83, 20);
            this.txtHoraFuncA.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 180);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Cantidad de boletas:";
            // 
            // txtCantBoletasA
            // 
            this.txtCantBoletasA.Enabled = false;
            this.txtCantBoletasA.Location = new System.Drawing.Point(133, 177);
            this.txtCantBoletasA.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantBoletasA.Name = "txtCantBoletasA";
            this.txtCantBoletasA.Size = new System.Drawing.Size(83, 20);
            this.txtCantBoletasA.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(229, 149);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Horas";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(229, 89);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Minutos";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(192, 89);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Minutos";
            // 
            // frmPrinciapal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 296);
            this.Controls.Add(this.tbcOpciones);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPrinciapal";
            this.Text = "Cadena de Cines Don Chucho";
            this.tbcOpciones.ResumeLayout(false);
            this.tbpRegistrar.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbpBuscar.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tbpListar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcOpciones;
        private System.Windows.Forms.TabPage tbpRegistrar;
        private System.Windows.Forms.TabPage tbpBuscar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbpListar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtGeneroA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDuracionA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkEditar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.TextBox txtHoraFuncA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCantBoletasA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

