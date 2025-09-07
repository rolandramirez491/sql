using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;
namespace CapaPresentacion
{
    public partial class frmPrinciapal : Form
    {
        public frmPrinciapal()
        {
            InitializeComponent();
        }
        CN_Empleado pelicula = new CN_Empleado();
        private void tbpRegistrar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtIdA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                int id = int.Parse(txtIdA.Text);
                var emp = pelicula.Buscar(id);

                if (emp != null)
                {
                    txtNomA.Text = emp["Nombre"].ToString();
                    txtDuracionA.Text = emp["Duracion"].ToString();
                    txtGeneroA.Text = emp["Genero"].ToString();
                    txtHoraFuncA.Text = emp["HoraFunc"].ToString();
                    txtCantBoletasA.Text = emp["CantBoletas"].ToString();
                }
                else
                {
                    MessageBox.Show("La pelicula no esta registrada!");
                    txtNomA.Text = "";
                    txtDuracionA.Text = "";
                    txtGeneroA.Text = "";
                    txtHoraFuncA.Text = "";
                    txtCantBoletasA.Text = "";
                }
                txtIdA.Focus();
                txtIdA.SelectAll();
            }
        }

        private void tbpBuscar_Click(object sender, EventArgs e)
        {

        }

        private void chkEditar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEditar.Checked)
            {
                btnActualizar.Enabled = true;
                txtNomA.Enabled = true;
                txtGeneroA.Enabled = true;
                txtDuracionA.Enabled = true;
                txtHoraFuncA.Enabled = true;
                
                txtNomA.Focus();
                txtNomA.SelectAll();
            }
            else
            {
                btnActualizar.Enabled = false;
                txtNomA.Enabled = false;
                txtGeneroA.Enabled = false;
                txtDuracionA.Enabled = false;
                txtHoraFuncA.Enabled = false;
                txtCantBoletasA.Enabled = false;
                txtNomA.Focus();
                txtNomA.SelectAll();

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            pelicula.Actualizar(int.Parse(txtIdA.Text), txtNomA.Text, int.Parse(txtDuracionA.Text), txtGeneroA.Text, int.Parse(txtHoraFuncA.Text), int.Parse(txtCantBoletasA.Text));
            //int.Parse(txtId.Text), txtNom.Text, int.Parse(txtDuracion.Text), txtGenero.Text, int.Parse(txtHoraFuncA.Text), int.Parse(txtCantBoletasA.Text));
            MessageBox.Show("Se a actualizado la pelicula");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            pelicula.Eliminar(int.Parse(txtIdA.Text));
            MessageBox.Show("Se a eliminado la pelicula");
            txtIdA.Text = "";
            txtNomA.Text = "";
            txtDuracionA.Text = "";
            txtGeneroA.Text = "";
            txtHoraFuncA.Text = "";
            txtCantBoletasA.Text = "";
            txtIdA.Focus();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = null;
            dgvEmpleados.Rows.Clear();
            dgvEmpleados.DataSource = pelicula.Listar();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            pelicula.Insertar(
                int.Parse(txtId.Text), txtNom.Text, int.Parse(txtDuracion.Text), txtGenero.Text, int.Parse(txtHoraFun.Text), 0);
            MessageBox.Show("La pelicula Se ha registrado exitosamente!.");
            txtId.Text = "";
            txtNom.Text = "";
            txtDuracion.Text = "";
            txtGenero.Text = "";
            txtHoraFun.Text = "";
            txtId.Focus();
        }

        private void txtIdA_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void tbcOpciones_Enter(object sender, EventArgs e)
        {


        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            
            
                lblT.Text= (int.Parse(lblT.Text) + 1).ToString();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            lblT.Text = int.TryParse(lblT.Text, out var n) && n > 1 ? (n - 1).ToString() : lblT.Text;

        }

        private void tbcOpciones_Selected(object sender, TabControlEventArgs e)
        {
            var dtCombo = pelicula.Listar();
            
            comboBox1.DisplayMember = "Cod";
            comboBox1.DataSource = dtCombo;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtN.Text = comboBox1.Text;
            int id= int.Parse(comboBox1.Text);
            var pel = pelicula.Buscar(id);

            txtN.Text = pel["Nombre"].ToString();
            txtDur.Text = pel["Duracion"].ToString();
            txtGen.Text = pel["Genero"].ToString();
            txtH.Text = pel["HoraFunc"].ToString();
            lblV.Text = pel["CantBoletas"].ToString();

        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            pelicula.Actualizar(int.Parse(comboBox1.Text), txtN.Text, int.Parse(txtDur.Text), txtGen.Text, int.Parse(txtH.Text), (int.Parse(lblV.Text)+(int.Parse(lblT.Text))));
            //int.Parse(txtId.Text), txtNom.Text, int.Parse(txtDuracion.Text), txtGenero.Text, int.Parse(txtHoraFuncA.Text), int.Parse(txtCantBoletasA.Text));
            double valorPagar = (int.Parse(lblT.Text) * 7500);
            MessageBox.Show("Se ha registrado la entrada, el valor a pagar es de "+valorPagar.ToString()) ;
            lblT.Text = "0";
        }

        private void txtHoraFun_TextChanged(object sender, EventArgs e)
        {
            lblAm.Text = int.TryParse(txtHoraFun.Text, out var h) ? (h >= 12 ? "Pm" : "Am") : "";
            if (h > 23) txtHoraFun.Text = (23).ToString();
        }

        private void txtHoraFuncA_TextChanged(object sender, EventArgs e)
        {
            label11.Text = int.TryParse(txtHoraFuncA.Text, out var h) ? (h >= 12 ? "Pm" : "Am") : "";
            if (h > 23) txtHoraFuncA.Text = (23).ToString();
        }
    }
}
