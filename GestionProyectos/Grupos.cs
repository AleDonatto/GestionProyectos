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

namespace GestionProyectos
{
    public partial class Grupos : Form
    {
        public Grupos()
        {
            InitializeComponent();
            cargar_grupos();
        }

        Query metodos = new Query();

        public void cargar_grupos() {
            DataSet ds = new DataSet();
            ds = metodos.Comsulta_grupos();
            dgv_grupos.DataSource = ds.Tables[0];
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txtgrado_mod.Text = dgv_grupos.CurrentRow.Cells[1].Value.ToString();
            txtGrupo_mod.Text = dgv_grupos.CurrentRow.Cells[2].Value.ToString();
            txtAula_mod.Text = dgv_grupos.CurrentRow.Cells[3].Value.ToString();

            txtgrado_mod.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string clave = dgv_grupos.CurrentRow.Cells[0].Value.ToString();
            int id = Convert.ToInt32(clave);
            DialogResult result = MessageBox.Show("Desea eleiminar el registro","Eliminacion de Registro",MessageBoxButtons.OKCancel,MessageBoxIcon.Asterisk);

            if (result == DialogResult.OK) {
                string mensaje = metodos.Eliminar_grupo(id);
                MessageBox.Show(mensaje,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnCrearGrupo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGrado.Text) || string.IsNullOrEmpty(txtGrupo.Text) || string.IsNullOrEmpty(txtAula.Text))
            {
                MessageBox.Show("Debe LLenar los Campos Correspondientes", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                int grado1 = Convert.ToInt32(txtGrado.Text);
                string mensaje = metodos.Agregar_grupo(grado1, txtGrupo.Text, txtAula.Text);
                MessageBox.Show(mensaje,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtAula.Clear();
                txtGrado.Clear();
                txtGrupo.Clear();
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtGrado.Text) || string.IsNullOrEmpty(txtGrupo.Text) || string.IsNullOrEmpty(txtAula.Text))
            {
                MessageBox.Show("Debe LLenar los Campos Correspondientes", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string id = dgv_grupos.CurrentRow.Cells[0].Value.ToString();
                int id_1 = Convert.ToInt32(id);
                int grado_1 = Convert.ToInt32(txtgrado_mod.Text);
                string mensaje = metodos.Actualizar_grupo(id_1,grado_1, txtGrupo_mod.Text, txtAula_mod.Text);
                MessageBox.Show(mensaje,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtgrado_mod.Clear();
                txtAula_mod.Clear();
                txtGrupo_mod.Clear();
            }
        }
    }
}
