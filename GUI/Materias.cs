using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;

namespace Presentacion
{
    public partial class Materias : Form
    {
        public Materias()
        {
            InitializeComponent();
            cargradatos();
        }

        Query operaciones = new Query();

        public void cargradatos() {
            DataSet ds = new DataSet();
            ds = operaciones.Consultar_Materias();
            dgvMaterias.DataSource = ds.Tables[0];
        }

        private void btnRefres_Click(object sender, EventArgs e)
        {
            cargradatos();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string grado = CBgruposConsulta.Text;
            int grado_1 = Convert.ToInt32(grado);

            DataSet da = new DataSet();
            da = operaciones.Cons_mat_grad(grado_1);
            dgvMaterias.DataSource = da.Tables[0];
        }

        private void btnActmateria_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombremateria.Text) || CBgradoper.SelectedIndex == -1 || CBtip_materia.SelectedIndex == -1)
            {
                MessageBox.Show("Asegurese de llenar los campos o selccionar alguna opcion.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombremateria.Focus();
            }
            else {
                int grado = Convert.ToInt32(CBgradoper.Text);
                string mensaje = operaciones.Modificar_materias(this.txtClavemateria.Text,this.txtNombremateria.Text, CBtip_materia.Text, grado);
                MessageBox.Show(mensaje, "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);

                txtClavemateria.Clear();
                txtNombremateria.Clear();
                cargradatos();
            }
        }

        private void btnNuevamateria_Click(object sender, EventArgs e)
        {
            string clave;
            string nombre = txtNombremateria.Text;
            int grado = Convert.ToInt32(CBgradoper.Text);

            clave = "pri" + grado + "_" + nombre.Substring(0, 3);

            MessageBox.Show(clave);
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtClavemateria.Text = dgvMaterias.CurrentRow.Cells[0].Value.ToString();
            txtNombremateria.Text = dgvMaterias.CurrentRow.Cells[1].Value.ToString();
            CBtip_materia.Text = dgvMaterias.CurrentRow.Cells[2].Value.ToString();
            CBgradoper.Text = dgvMaterias.CurrentRow.Cells[3].Value.ToString();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
