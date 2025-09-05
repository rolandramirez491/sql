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
            pelicula.Actualizar(int.Parse(txtId.Text), txtNom.Text, int.Parse(txtDuracion.Text), txtGenero.Text, 9, 9);
            //int.Parse(txtId.Text), txtNom.Text, int.Parse(txtDuracion.Text), txtGenero.Text, int.Parse(txtHoraFuncA.Text), int.Parse(txtCantBoletasA.Text));
            MessageBox.Show("Se a actualizado la pelicula");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            pelicula.Eliminar(int.Parse(txtIdA.Text));
            MessageBox.Show("Se a eliminado la pelicula");
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
                int.Parse(txtId.Text), txtNom.Text, int.Parse(txtDuracion.Text), txtGenero.Text, 0, 0);
            MessageBox.Show("La pelicula Se ha registrado exitosamente!.");
        }

        private void txtIdA_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
