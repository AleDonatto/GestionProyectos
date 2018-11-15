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
    public partial class Alumnos : Form
    {
        public Alumnos()
        {
            InitializeComponent();
            cargra_datos();
        }

        Query metodos = new Query();

        public void cargra_datos() {
            int grado = 1;
            DataSet ds = new DataSet();
            ds = metodos.Consulta_Alumnos_Grupo(grado);
            dgvAlumnos.DataSource = ds.Tables[0];
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            cargra_datos();
        }

        private void btnBuscar_grupo_Click(object sender, EventArgs e)
        {
            if (CBGruposeleccinar.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un grupo a consultar", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                int grado = Convert.ToInt32(CBGruposeleccinar.Text);

                DataSet ds = new DataSet();
                ds = metodos.Consulta_Alumnos_Grupo(grado);
                dgvAlumnos.DataSource = ds.Tables[0];
            }
      
        }
        
        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtCurp.Text = dgvAlumnos.CurrentRow.Cells[0].Value.ToString();
            txtAP_paterno.Text = dgvAlumnos.CurrentRow.Cells[1].Value.ToString();
            txtAp_materno.Text = dgvAlumnos.CurrentRow.Cells[2].Value.ToString();
            txtNombre_alumno.Text = dgvAlumnos.CurrentRow.Cells[3].Value.ToString();
            txtEdad.Text = dgvAlumnos.CurrentRow.Cells[4].Value.ToString();
            txtDireccion.Text = dgvAlumnos.CurrentRow.Cells[5].Value.ToString();
            dtpFechaNacimiento.Text = dgvAlumnos.CurrentRow.Cells[6].Value.ToString();
            CBGradoinscripcion.Text = dgvAlumnos.CurrentRow.Cells[9].Value.ToString();
            txtCurp.Focus();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult pregunta = MessageBox.Show("Desea eliminar el registro seleccionado.", "Eliminar dato", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pregunta == DialogResult.Yes)
            {
                string curp = dgvAlumnos.CurrentRow.Cells[0].Value.ToString();
                string mensaje = metodos.Eliminar_alumno(curp);
                MessageBox.Show(mensaje, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            cargra_datos();
        }

        private void btnGuardarAlumno_Click(object sender, EventArgs e)
        {
            int grado = Convert.ToInt32(CBGradoinscripcion.Text);
            int edad = Convert.ToInt32(txtEdad.Text);
            if (string.IsNullOrEmpty(txtCurp.Text) || string.IsNullOrEmpty(txtAP_paterno.Text) || string.IsNullOrEmpty(txtAp_materno.Text) || string.IsNullOrEmpty(txtNombre_alumno.Text)
                || string.IsNullOrEmpty(txtEdad.Text) || string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("Asegurese de Llenar los campos correspondientes", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                string mensaje = metodos.Modifcacion_alumnos(txtCurp.Text, txtAP_paterno.Text, txtAp_materno.Text, txtNombre_alumno.Text, edad, txtDireccion.Text, dtpFechaNacimiento.Text, "1", grado);
                MessageBox.Show(mensaje,"Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (mensaje != "Excepcion no Controlada") {
                   // string mensaje1 = metodos.Modificar_detalle_alumno(cbGenero.Text,txtTipoSangre.Text,txtAlergias.Text,txtEnferdadCronica.Text,txtCurp.Text);
                }
                txtCurp.Clear(); txtAP_paterno.Clear(); txtAp_materno.Clear(); txtNombre_alumno.Clear(); txtEdad.Clear(); txtDireccion.Clear();
                cargra_datos();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
