using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        #region metodo para abrir formularios
        private void abrir_form<formulario>() where formulario : Form, new()
        {
            Form form1;
            form1 = P_formularios.Controls.OfType<formulario>().FirstOrDefault();

            if (form1 == null)
            {
                form1 = new formulario();
                form1.TopLevel = false;
                form1.Dock = DockStyle.Fill;
                P_formularios.Controls.Add(form1);
                P_formularios.Tag = form1;
                form1.Show();
                form1.BringToFront();
            }
            else
            {
                form1.BringToFront();
            }
        }
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.ShowDialog();
            this.Close();
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            abrir_form<Materias>();
        }

        private void btnInscripciones_Click(object sender, EventArgs e)
        {
            abrir_form<Inscripciones>();
        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            abrir_form<Grupos>();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            abrir_form<Alumnos>();
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            abrir_form<Captura_Calificaciones>();
        }
    }
}
