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
    public partial class Grupos : Form
    {
        public Grupos()
        {
            InitializeComponent();
            Consulta_grupos();
        }

        Query metodos = new Query();

        public void Consulta_grupos() {
            DataSet ds = new DataSet();
            ds = metodos.Consulta_Grupos();
            dgvGrupos.DataSource = ds.Tables[0];
        }

        private void btnBuscar_grupo_Click(object sender, EventArgs e)
        {
            int grgo_seleccionado =Convert.ToInt32(CBGruposeleccinar.SelectedIndex.ToString());

            //DataSet ds = new DataSet();
            //ds = metodos.c
        }

        private void btnModificar_grupo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtidgrupo_mod.Text) || string.IsNullOrEmpty(txtGrupo_mod.Text) || string.IsNullOrEmpty(txtGrado_mod.Text) || string.IsNullOrEmpty(txtAula_mod.Text))
            {
                MessageBox.Show("Llene los campos correspondientes.","ADVERTENCIA", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtGrupo_mod.Focus();
            }
            else {
                int id, grado;
                id = Convert.ToInt32(txtidgrupo_mod.Text);
                grado = Convert.ToInt32(txtGrado_mod.Text);
                string mensaje = metodos.Actualizar_Grupo(id,grado,txtGrupo_mod.Text,txtAula_mod.Text);

                MessageBox.Show(mensaje,"Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
                Consulta_grupos();
                txtAula_mod.Clear();
                txtGrado_mod.Clear();
                txtGrupo_mod.Clear();
                txtidgrupo_mod.Clear();
            }
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtidgrupo_mod.Text = dgvGrupos.CurrentRow.Cells[0].Value.ToString();
            txtGrado_mod.Text = dgvGrupos.CurrentRow.Cells[1].Value.ToString();
            txtGrupo_mod.Text = dgvGrupos.CurrentRow.Cells[2].Value.ToString();
            txtAula_mod.Text = dgvGrupos.CurrentRow.Cells[3].Value.ToString();
            txtGrado_mod.Focus();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult pregunta = MessageBox.Show("Desea eliminar el registro seleccionado.","Eliminar dato",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (pregunta == DialogResult.Yes) {
                int id = Convert.ToInt32(dgvGrupos.CurrentRow.Cells[0].Value.ToString());
                string mensaje = metodos.Eliminar_Grupo(id);
                MessageBox.Show(mensaje,"Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            Consulta_grupos();
        }

        private void btnListasGrupos_Click(object sender, EventArgs e)
        {
            VerListas pdf = new VerListas();
            pdf.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
