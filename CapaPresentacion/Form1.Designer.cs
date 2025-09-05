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
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApe = new System.Windows.Forms.TextBox();
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
            this.txtSalarioA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApeA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNomA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbpListar = new System.Windows.Forms.TabPage();
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
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
            this.tbcOpciones.Location = new System.Drawing.Point(0, 0);
            this.tbcOpciones.Name = "tbcOpciones";
            this.tbcOpciones.SelectedIndex = 0;
            this.tbcOpciones.Size = new System.Drawing.Size(611, 354);
            this.tbcOpciones.TabIndex = 0;
            // 
            // tbpRegistrar
            // 
            this.tbpRegistrar.Controls.Add(this.btnRegistrar);
            this.tbpRegistrar.Controls.Add(this.btnNuevo);
            this.tbpRegistrar.Controls.Add(this.groupBox1);
            this.tbpRegistrar.Location = new System.Drawing.Point(4, 25);
            this.tbpRegistrar.Name = "tbpRegistrar";
            this.tbpRegistrar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpRegistrar.Size = new System.Drawing.Size(603, 325);
            this.tbpRegistrar.TabIndex = 0;
            this.tbpRegistrar.Text = "Registrar Empleado";
            this.tbpRegistrar.UseVisualStyleBackColor = true;
            this.tbpRegistrar.Click += new System.EventHandler(this.tbpRegistrar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Image = global::CapaPresentacion.Properties.Resources.guardar;
            this.btnRegistrar.Location = new System.Drawing.Point(531, 49);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(49, 46);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::CapaPresentacion.Properties.Resources.nuevo;
            this.btnNuevo.Location = new System.Drawing.Point(531, 102);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(49, 42);
            this.btnNuevo.TabIndex = 9;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSalario);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtApe);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Empleado";
            // 
            // txtSalario
            // 
            this.txtSalario.Location = new System.Drawing.Point(121, 144);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(109, 22);
            this.txtSalario.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Salario Base:";
            // 
            // txtApe
            // 
            this.txtApe.Location = new System.Drawing.Point(121, 107);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(221, 22);
            this.txtApe.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellidos:";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(121, 68);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(221, 22);
            this.txtNom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombres:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(121, 28);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(109, 22);
            this.txtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificación:";
            // 
            // tbpBuscar
            // 
            this.tbpBuscar.Controls.Add(this.btnActualizar);
            this.tbpBuscar.Controls.Add(this.btnEliminar);
            this.tbpBuscar.Controls.Add(this.groupBox2);
            this.tbpBuscar.Location = new System.Drawing.Point(4, 25);
            this.tbpBuscar.Name = "tbpBuscar";
            this.tbpBuscar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBuscar.Size = new System.Drawing.Size(603, 325);
            this.tbpBuscar.TabIndex = 1;
            this.tbpBuscar.Text = "Buscar Empleado";
            this.tbpBuscar.UseVisualStyleBackColor = true;
            this.tbpBuscar.Click += new System.EventHandler(this.tbpBuscar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Enabled = false;
            this.btnActualizar.Image = global::CapaPresentacion.Properties.Resources.actualizar;
            this.btnActualizar.Location = new System.Drawing.Point(534, 52);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(49, 46);
            this.btnActualizar.TabIndex = 11;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::CapaPresentacion.Properties.Resources.eliminar;
            this.btnEliminar.Location = new System.Drawing.Point(534, 105);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(49, 42);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkEditar);
            this.groupBox2.Controls.Add(this.txtSalarioA);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtApeA);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtNomA);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtIdA);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(20, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 211);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Empleado";
            // 
            // chkEditar
            // 
            this.chkEditar.AutoSize = true;
            this.chkEditar.Location = new System.Drawing.Point(278, 27);
            this.chkEditar.Name = "chkEditar";
            this.chkEditar.Size = new System.Drawing.Size(64, 20);
            this.chkEditar.TabIndex = 8;
            this.chkEditar.Text = "Editar";
            this.chkEditar.UseVisualStyleBackColor = true;
            this.chkEditar.CheckedChanged += new System.EventHandler(this.chkEditar_CheckedChanged);
            // 
            // txtSalarioA
            // 
            this.txtSalarioA.Enabled = false;
            this.txtSalarioA.Location = new System.Drawing.Point(121, 144);
            this.txtSalarioA.Name = "txtSalarioA";
            this.txtSalarioA.Size = new System.Drawing.Size(109, 22);
            this.txtSalarioA.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Salario Base:";
            // 
            // txtApeA
            // 
            this.txtApeA.Enabled = false;
            this.txtApeA.Location = new System.Drawing.Point(121, 107);
            this.txtApeA.Name = "txtApeA";
            this.txtApeA.Size = new System.Drawing.Size(221, 22);
            this.txtApeA.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Apellidos:";
            // 
            // txtNomA
            // 
            this.txtNomA.Enabled = false;
            this.txtNomA.Location = new System.Drawing.Point(121, 68);
            this.txtNomA.Name = "txtNomA";
            this.txtNomA.Size = new System.Drawing.Size(221, 22);
            this.txtNomA.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nombres:";
            // 
            // txtIdA
            // 
            this.txtIdA.Location = new System.Drawing.Point(121, 28);
            this.txtIdA.Name = "txtIdA";
            this.txtIdA.Size = new System.Drawing.Size(109, 22);
            this.txtIdA.TabIndex = 1;
            this.txtIdA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdA_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Identificación:";
            // 
            // tbpListar
            // 
            this.tbpListar.Controls.Add(this.btnListar);
            this.tbpListar.Controls.Add(this.dgvEmpleados);
            this.tbpListar.Location = new System.Drawing.Point(4, 25);
            this.tbpListar.Name = "tbpListar";
            this.tbpListar.Size = new System.Drawing.Size(603, 325);
            this.tbpListar.TabIndex = 2;
            this.tbpListar.Text = "Listar Empleados";
            this.tbpListar.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            this.btnListar.Image = global::CapaPresentacion.Properties.Resources.lista;
            this.btnListar.Location = new System.Drawing.Point(547, 17);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(49, 46);
            this.btnListar.TabIndex = 12;
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(3, 3);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowHeadersWidth = 51;
            this.dgvEmpleados.RowTemplate.Height = 24;
            this.dgvEmpleados.Size = new System.Drawing.Size(538, 319);
            this.dgvEmpleados.TabIndex = 0;
            // 
            // frmPrinciapal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 364);
            this.Controls.Add(this.tbcOpciones);
            this.Name = "frmPrinciapal";
            this.Text = "Empresa de Alimentos Don Chucho";
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
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtApe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbpListar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSalarioA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApeA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNomA;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chkEditar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvEmpleados;
    }
}

