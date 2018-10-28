using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionProyectos
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            pictureBox3.Visible = false;

        }

        #region metodo para abrir fromuarios
        private void abrir_form<formulario>() where formulario : Form, new() {
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
            else {
                form1.BringToFront();
            }
        }


        #endregion

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox3.Visible = true;
            if (Pmenu.Width == 250)
            {
                Pmenu.Visible = false;
                pictureBox1.Visible = false;
                Pmenu.Width = 50;
                bunifuTransition1.ShowSync(Pmenu);
            }
            else
            {
                Pmenu.Visible = false;
                Pmenu.Width = 250;
                pictureBox1.Visible = true;
                bunifuTransition1.ShowSync(Pmenu);
            }
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            pictureBox3.Visible = false;
            if (Pmenu.Width == 250)
            {
                Pmenu.Visible = false;
                pictureBox1.Visible = false;
                Pmenu.Width = 50;
                bunifuTransition1.ShowSync(Pmenu);
            }
            else
            {
                Pmenu.Visible = false;
                Pmenu.Width = 250;
                pictureBox1.Visible = true;
                bunifuTransition1.ShowSync(Pmenu);
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Hide();
            login.ShowDialog();
            this.Close();
        }

        private void btnChico_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            abrir_form<Grupos>();
        }
    }
}
