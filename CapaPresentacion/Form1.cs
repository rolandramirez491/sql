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
        CN_Empleado empleado = new CN_Empleado();
        private void tbpRegistrar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtIdA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                int id = int.Parse(txtIdA.Text);
                var emp = empleado.Buscar(id);

                if (emp != null)
                {
                    txtNomA.Text = emp["Nombre"].ToString();
                    txtApeA.Text = emp["Apellido"].ToString();
                    txtSalarioA.Text = emp["SalarioBase"].ToString();
                }
                else
                {
                    MessageBox.Show("El empleado no esta registrado!");
                    txtNomA.Text = "";
                    txtApeA.Text = "";
                    txtSalarioA.Text = "";
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
                txtSalarioA.Enabled = true;
                txtApeA.Enabled = true;
                txtNomA.Focus();
                txtNomA.SelectAll();
            }
            else
            {
                btnActualizar.Enabled = false;
                txtNomA.Enabled = false;
                txtSalarioA.Enabled = false;
                txtApeA.Enabled = false;
                txtNomA.Focus();
                txtNomA.SelectAll();

            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            empleado.Actualizar(
                int.Parse(txtIdA.Text), txtNomA.Text, txtApeA.Text,
                double.Parse(txtSalarioA.Text)
                );
            MessageBox.Show("Se a actualizado el cliente");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            empleado.Eliminar(int.Parse(txtIdA.Text));
            MessageBox.Show("Se a eliminado el empleado");
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = null;
            dgvEmpleados.Rows.Clear();
            dgvEmpleados.DataSource = empleado.Listar();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            empleado.Insertar(
                int.Parse(txtId.Text), txtNom.Text, txtApe.Text, double.Parse(txtSalario.Text));
            MessageBox.Show("Se ha registrado exitosamente!.");
        }
    }
}
