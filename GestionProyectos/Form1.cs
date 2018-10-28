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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.LabelMensaje.Visible = false;            
        }
        
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtUser.Text))
            {
                MessageBox.Show(null, "Debe Ingresar Usuario y Contraseña", "ADVERTENCA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
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
                    Main principa = new Main();
                    principa.label2.Text = nombre;
                    principa.label3.Text = apellido;
                    principa.label4.Text = cargo;

                    if (cargo == "Secretario" || cargo == "Secretaria") {
                        principa.btnModificarCalificaciones.Visible = false;
                    }

                    this.Hide();
                    principa.ShowDialog();
                    this.Close();
                }
                else {
                    LabelMensaje.Visible = true;
                    LabelMensaje.Text = mensaje;
                    this.txtUser.BorderColorIdle = Color.Red;
                    this.txtPassword.BorderColorIdle = Color.Red;
                }
            }
        }   
    }
}