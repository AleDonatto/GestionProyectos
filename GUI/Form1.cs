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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            LabelMensaje.Visible = false;
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtUser.Text))
            {
                MessageBox.Show(null, "Debe Ingresar Usuario y Contraseña", "ADVERTENCA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string user, contraseña, nombre, apellido, cargo;
                user = this.txtUser.Text;
                contraseña = this.txtPassword.Text;
                nombre = "";
                apellido = "";
                cargo = "";
                Query logeo = new Query();
                string mensaje = logeo.login(user, contraseña, ref nombre, ref apellido, ref cargo);

                if (mensaje == "Accesando")
                {
                    Main principal = new Main();
                    principal.label3.Text = nombre;
                    principal.label4.Text = apellido;
                    principal.label5.Text = cargo;

                    if (cargo == "Secretario" || cargo == "Secretaria")
                    {
                        principal.btnModificarCalificaciones.Visible = false;
                    }

                    this.Hide();
                    principal.ShowDialog();
                    this.Close();
                }
                else
                {
                    LabelMensaje.Visible = true;
                    LabelMensaje.Text = mensaje;
                    this.txtUser.BorderColorIdle = Color.Red;
                    this.txtPassword.BorderColorIdle = Color.Red;
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
