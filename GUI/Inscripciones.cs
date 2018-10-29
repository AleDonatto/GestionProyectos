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
    public partial class Inscripciones : Form
    {
        public Inscripciones()
        {
            InitializeComponent();
            campos_Alumno();
        }

        Query funciones = new Query();

        public void campos_Alumno() {
            txtNombre_alumno.Enabled = false;
            txtAP_paterno.Enabled = false;
            txtAp_materno.Enabled = false;
            txtDireccion.Enabled = false;
            txtEdad.Enabled = false;
            txtEnferdadCronica.Enabled = false;
            txtAlergias.Enabled = false;
            txtTipoSangre.Enabled = false;
            cbGenero.Enabled = false;
            CBGradoinscripcion.Enabled = false;
            dtpFechaNacimiento.Enabled = false;
        }

        public void Descampos_alumnos() {
            txtNombre_alumno.Enabled = true;
            txtAP_paterno.Enabled = true;
            txtAp_materno.Enabled = true;
            txtDireccion.Enabled = true;
            txtEdad.Enabled = true;
            txtEnferdadCronica.Enabled = true;
            txtAlergias.Enabled = true;
            txtTipoSangre.Enabled = true;
            cbGenero.Enabled = true;
            CBGradoinscripcion.Enabled = true;
            dtpFechaNacimiento.Enabled = true;
        }

        private void btnGuardar_Tutor_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtApP_tutor.Text) || string.IsNullOrEmpty(txtAm_T.Text)
                || string.IsNullOrEmpty(txtNombre_T.Text) || string.IsNullOrEmpty(txtTelefono.Text)
                || string.IsNullOrEmpty(txtCelular.Text) || string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Debe Rellenar los Campos Correspondientes", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {

                string mensaje = funciones.Agregar_Tutor(txtCURP.Text,txtApP_tutor.Text, txtAm_T.Text,txtNombre_T.Text, txtCelular.Text, txtTelefono.Text, txtEmail.Text, txtDireccion_tutor.Text);
                MessageBox.Show(mensaje,"Information",MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (mensaje != "Excepcion no Controlada") {
                    txtCURP.Enabled = false;
                    txtApP_tutor.Enabled = false;
                    txtAm_T.Enabled = false;
                    txtNombre_T.Enabled = false;
                    txtCelular.Enabled = false;
                    txtTelefono.Enabled = false;
                    txtEmail.Enabled = false;
                    txtDireccion_tutor.Enabled = false;
                    Descampos_alumnos();
                    CBGradoinscripcion.Focus();
                }
            }
        }

        private void btnGuardarAlumno_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre_alumno.Text) || string.IsNullOrEmpty(txtAP_paterno.Text)
                || string.IsNullOrEmpty(txtAp_materno.Text) || string.IsNullOrEmpty(txtDireccion.Text)
                || string.IsNullOrEmpty(txtEdad.Text) || string.IsNullOrEmpty(txtEnferdadCronica.Text)
                || string.IsNullOrEmpty(txtAlergias.Text) || cbGenero.SelectedIndex == -1 || CBGradoinscripcion.SelectedIndex == -1)
            {

                MessageBox.Show("Asegurese de llenar los campos correspondientes.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {
                int edad = Convert.ToInt32(txtEdad.Text);
                int grado = Convert.ToInt32(CBGradoinscripcion.Text);
                int año = Convert.ToInt32(dtpFechaNacimiento.Value.Year.ToString());
                string curpcompleta = txtCURP.Text;
                string año_curp = curpcompleta.Substring(4,2);
                string añocompleto = dtpFechaNacimiento.Value.Year.ToString();
                string año_nacimineto = añocompleto.Substring(2,2);

                //string prueba = string.Format("edad = {0}, año de nacimiento = {1}, grado = {2}", edad, año, grado);
                //MessageBox.Show(año_nacimineto, "Cabron", MessageBoxButtons.OK, MessageBoxIcon.Information);
                int curp_año = Convert.ToInt32(año_curp);
                int nacimineto_año = Convert.ToInt32(año_nacimineto);

                bool comp_edad_grado = funciones.grado_edad(grado, edad);
                bool edad_fechanacimiento = funciones.edad_fecha(edad,año);
                bool com_curp_año = funciones.curp_fecha(curp_año, nacimineto_año);


                if (comp_edad_grado == false && edad_fechanacimiento == true)
                {
                    MessageBox.Show("La edad no corresponde al grado al que se desea inscribir.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (edad_fechanacimiento == false && comp_edad_grado == true)
                {
                    MessageBox.Show("La edad no corresponde con la fecha de nacimiento.", "ADVERTECIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (com_curp_año == false) {
                    MessageBox.Show("La fecha de nacimineto no corresponde con la CURP", "ADVERTECIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (edad_fechanacimiento == false && comp_edad_grado == false)
                {
                    MessageBox.Show("La edad y fecha de nacimiento no son correctos verifique los datos.", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int contador_de_inscripciones = funciones.Contar_Alumnos_Grado(grado);
                    if (contador_de_inscripciones <= 25)
                    {
                        string mensaje = funciones.Inscripciones_alumno(txtCURP.Text, txtAP_paterno.Text, txtAp_materno.Text, txtNombre_alumno.Text, edad, txtDireccion.Text, dtpFechaNacimiento.Text, "Agosto-2018", grado);
                        MessageBox.Show(mensaje, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (mensaje != "Excepcion no Controlada")
                        {
                            funciones.Insertar_detalle_alumno(cbGenero.Text, txtTipoSangre.Text, txtAlergias.Text, txtEnferdadCronica.Text, txtCURP.Text);

                            DialogResult pregunta = MessageBox.Show("Inscribir Otro Alumno del Mismo Tutor","Question",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (pregunta == DialogResult.Yes)
                            {
                                txtNombre_alumno.Clear();
                                txtAP_paterno.Clear();
                                txtAp_materno.Clear();
                                txtDireccion.Clear();
                                txtEdad.Clear();
                                txtEnferdadCronica.Clear();
                                txtAlergias.Clear();
                                txtTipoSangre.Clear();
                                cbGenero.Text = "Seleccione";
                                CBGradoinscripcion.Text = "Seleccione";

                                txtCURP.Enabled = false;
                                txtApP_tutor.Enabled = false;
                                txtAm_T.Enabled = false;
                                txtNombre_T.Enabled = false;
                                txtCelular.Enabled = false;
                                txtTelefono.Enabled = false;
                                txtEmail.Enabled = false;
                                txtDireccion_tutor.Enabled = false;
                                txtCURP.Clear();
                                txtCURP.Focus();
                            }
                            else if (pregunta == DialogResult.No) {

                                //campos del alumno
                                txtNombre_alumno.Clear();
                                txtAP_paterno.Clear();
                                txtAp_materno.Clear();
                                txtDireccion.Clear();
                                txtEdad.Clear();
                                txtEnferdadCronica.Clear();
                                txtAlergias.Clear();
                                txtTipoSangre.Clear();
                                cbGenero.Text = "Seleccione";
                                CBGradoinscripcion.Text = "Seleccione";

                                //campos del tutor
                                txtCURP.Enabled = true;
                                txtApP_tutor.Enabled = true;
                                txtAm_T.Enabled = true;
                                txtNombre_T.Enabled = true;
                                txtCelular.Enabled = true;
                                txtTelefono.Enabled = true;
                                txtEmail.Enabled = true;
                                txtDireccion_tutor.Enabled = true;

                                //limpiar campos del tutor
                                txtCURP.Clear();
                                txtApP_tutor.Clear();
                                txtAm_T.Clear();
                                txtNombre_T.Clear();
                                txtCelular.Clear();
                                txtTelefono.Clear();
                                txtEmail.Clear();
                                txtDireccion_tutor.Clear();
                                txtCURP.Focus();

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El grupo alcanzo el numero maximo de alumnos inscritos", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) {
                e.Handled = true;
            }
        }
    }
}
