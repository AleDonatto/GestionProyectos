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
    public partial class Captura_Calificaciones : Form
    {
        public Captura_Calificaciones()
        {
            InitializeComponent();
            Cargar_Opciones_Tabla();
        }

        Query consultas = new Query(); 

        public void Cargar_Opciones_Tabla() {
            DataGridViewButtonColumn btncol = new DataGridViewButtonColumn();
            btncol.Name = "btnGuardar";
            btncol.HeaderText = "Guardar Datos";
            btncol.Text = "Guardar";
            btncol.UseColumnTextForButtonValue = true;
            dgvCalificaciones.Columns.Add(btncol);
        }

       /* public void Dibujar_tabla() {
            if (e.ColumnIndex >= 0 && this.dgvCalificaciones.Columns[e.ColumnIndex].Name == "Guardar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell cellbuton = this.dgvCalificaciones.Rows[e.RowIndex].Cells["Guardar"] as DataGridViewButtonCell;

                Cargar_Opciones_Tabla();
            }
        }*/

        private void dgvCalificaciones_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dgvCalificaciones.Columns[e.ColumnIndex].Name == "Guardar" && e.RowIndex >= 0) {
                e.Paint(e.CellBounds,DataGridViewPaintParts.All);
                DataGridViewButtonCell cellbuton = this.dgvCalificaciones.Rows[e.RowIndex].Cells["Guardar"] as DataGridViewButtonCell;

                Cargar_Opciones_Tabla();

                //Icon iconoboton = new Icon(Environment.CurrentDirectory + @"\\delete.ico");
                //e.Graphics.DrawIcon(iconoboton,e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                //this.dgvCalificaciones.Rows[e.RowIndex].Height = iconoboton.Height + 8;
                //this.dgvCalificaciones.Columns[e.ColumnIndex].Width = iconoboton.Width + 8;

                //e.Handled = true;

            }

        }
        
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            if (cbGrupoCaptura.Text == "1" || cbGrupoCaptura.Text == "2")
            {
                
                ds = consultas.C_alumnos_calificaciones_grado1();
                dgvCalificaciones.DataSource = ds.Tables[0];
                DataGridViewTextBoxColumn español = new DataGridViewTextBoxColumn();
                español.HeaderText = "Español";
                dgvCalificaciones.Columns.Add(español);
                DataGridViewTextBoxColumn mate = new DataGridViewTextBoxColumn();
                mate.HeaderText = "Matemeticas";
                dgvCalificaciones.Columns.Add(mate);
                DataGridViewTextBoxColumn civismo = new DataGridViewTextBoxColumn();
                civismo.HeaderText = "Civismo";
                dgvCalificaciones.Columns.Add(civismo);
                DataGridViewTextBoxColumn efisica = new DataGridViewTextBoxColumn();
                efisica.HeaderText = "Educacion Fisica";
                dgvCalificaciones.Columns.Add(efisica);
                DataGridViewTextBoxColumn artes = new DataGridViewTextBoxColumn();
                artes.HeaderText = "Artes";
                dgvCalificaciones.Columns.Add(artes);
                DataGridViewTextBoxColumn misoc = new DataGridViewTextBoxColumn();
                misoc.HeaderText = "Mi sociedad";
                dgvCalificaciones.Columns.Add(misoc);
                DataGridViewTextBoxColumn compu = new DataGridViewTextBoxColumn();
                compu.HeaderText = "Computacion";
                dgvCalificaciones.Columns.Add(compu);
                DataGridViewTextBoxColumn ingles = new DataGridViewTextBoxColumn();
                ingles.HeaderText = "Ingles";
                dgvCalificaciones.Columns.Add(ingles);
            }
            else if (cbGrupoCaptura.Text == "3")
            {
                ds = consultas.C_alumnos_calificaciones_grado3();
                dgvCalificaciones.DataSource = ds.Tables[0];

                DataGridViewTextBoxColumn español = new DataGridViewTextBoxColumn();
                español.HeaderText = "Español";
                dgvCalificaciones.Columns.Add(español);
                DataGridViewTextBoxColumn mate = new DataGridViewTextBoxColumn();
                mate.HeaderText = "Matemeticas";
                dgvCalificaciones.Columns.Add(mate);
                DataGridViewTextBoxColumn nat = new DataGridViewTextBoxColumn();
                nat.HeaderText = "Ciencias Naturales";
                dgvCalificaciones.Columns.Add(nat);
                DataGridViewTextBoxColumn entidad = new DataGridViewTextBoxColumn();
                entidad.HeaderText = "Entidad donde Vivo";
                dgvCalificaciones.Columns.Add(entidad);
                DataGridViewTextBoxColumn civica = new DataGridViewTextBoxColumn();
                civica.HeaderText = "Formacion Civica y Etica";
                dgvCalificaciones.Columns.Add(civica);
                DataGridViewTextBoxColumn fisica = new DataGridViewTextBoxColumn();
                fisica.HeaderText = "Educacion Fisica";
                dgvCalificaciones.Columns.Add(fisica);
                DataGridViewTextBoxColumn artes = new DataGridViewTextBoxColumn();
                artes.HeaderText = "Educacion Artistica";
                dgvCalificaciones.Columns.Add(artes);
                DataGridViewTextBoxColumn compu = new DataGridViewTextBoxColumn();
                compu.HeaderText = "Computacion";
                dgvCalificaciones.Columns.Add(compu);
                DataGridViewTextBoxColumn ingles = new DataGridViewTextBoxColumn();
                ingles.HeaderText = "Ingles";
                dgvCalificaciones.Columns.Add(ingles);
            }
            else if (cbGrupoCaptura.Text == "4" || cbGrupoCaptura.Text == "5" || cbGrupoCaptura.Text == "6")
            {
                ds = consultas.C_alumnos_calificaciones_grado4();
                dgvCalificaciones.DataSource = ds.Tables[0];

                DataGridViewTextBoxColumn español = new DataGridViewTextBoxColumn();
                español.HeaderText = "Español";
                dgvCalificaciones.Columns.Add(español);
                DataGridViewTextBoxColumn mate = new DataGridViewTextBoxColumn();
                mate.HeaderText = "Matemeticas";
                dgvCalificaciones.Columns.Add(mate);
                DataGridViewTextBoxColumn nat = new DataGridViewTextBoxColumn();
                nat.HeaderText = "Ciencias Naturales";
                dgvCalificaciones.Columns.Add(nat);
                DataGridViewTextBoxColumn goe = new DataGridViewTextBoxColumn();
                goe.HeaderText = "Geografica";
                dgvCalificaciones.Columns.Add(goe);
                DataGridViewTextBoxColumn historia = new DataGridViewTextBoxColumn();
                historia.HeaderText = "Historia";
                dgvCalificaciones.Columns.Add(historia);
                DataGridViewTextBoxColumn civica = new DataGridViewTextBoxColumn();
                civica.HeaderText = "Formacion Civica y Etica";
                dgvCalificaciones.Columns.Add(civica);
                DataGridViewTextBoxColumn fisica = new DataGridViewTextBoxColumn();
                fisica.HeaderText = "Educacion Fisica";
                dgvCalificaciones.Columns.Add(fisica);
                DataGridViewTextBoxColumn artes = new DataGridViewTextBoxColumn();
                artes.HeaderText = "Educacion Artistica";
                dgvCalificaciones.Columns.Add(artes);
                DataGridViewTextBoxColumn compu = new DataGridViewTextBoxColumn();
                compu.HeaderText = "Computacion";
                dgvCalificaciones.Columns.Add(compu);
                DataGridViewTextBoxColumn ingles = new DataGridViewTextBoxColumn();
                ingles.HeaderText = "Ingles";
                dgvCalificaciones.Columns.Add(ingles);
            }
            
            
        }

        private void dgvCalificaciones_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            string curp, periodo = "Diagnostico-Agosto-18";
            int español, mate, civismo, efisica, artes, sociedad, compu, ingles, grado, entidad, naturales, geografia, historia;

            //MessageBox.Show("Mensaje del boton de la tabla");
            if (cbGrupoCaptura.Text == "1" || cbGrupoCaptura.Text == "2")
            {
                grado = Convert.ToInt32(cbGrupoCaptura.Text);

                curp = dgvCalificaciones.CurrentRow.Cells[1].Value.ToString();
                español = Convert.ToInt32(dgvCalificaciones.CurrentRow.Cells[5].Value.ToString());
                mate = Convert.ToInt32(dgvCalificaciones.CurrentRow.Cells[6].Value.ToString());
                civismo = Convert.ToInt32(dgvCalificaciones.CurrentRow.Cells[7].Value.ToString());
                efisica = Convert.ToInt32(dgvCalificaciones.CurrentRow.Cells[8].Value.ToString());
                artes = Convert.ToInt32(dgvCalificaciones.CurrentRow.Cells[9].Value.ToString());
                sociedad = Convert.ToInt32(dgvCalificaciones.CurrentRow.Cells[10].Value.ToString());
                compu = Convert.ToInt32(dgvCalificaciones.CurrentRow.Cells[11].Value.ToString());
                ingles = Convert.ToInt32(dgvCalificaciones.CurrentRow.Cells[12].Value.ToString());

                if (español < 5 || español > 10 || mate < 5 || mate > 10 || sociedad < 5 || sociedad > 10 || civismo < 5 || civismo > 10 || efisica < 5 || efisica > 10)
                {
                    MessageBox.Show("Formato de calificacion no valido", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string mensaje = consultas.Inser_cal_1and2(español, mate, civismo, efisica, artes, sociedad, compu, ingles, grado, periodo, curp);
                    MessageBox.Show(mensaje, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
            }
            else if (cbGrupoCaptura.Text == "3")
            {
                grado = Convert.ToInt32(cbGrupoCaptura.Text);


                curp = dgvCalificaciones.CurrentRow.Cells[1].Value.ToString();
                español = Convert.ToInt32(dgvCalificaciones.CurrentRow.Cells[5].Value.ToString());
                mate = Convert.ToInt32(dgvCalificaciones.CurrentRow.Cells[6].Value.ToString());
                naturales = Convert.ToInt32(dgvCalificaciones.CurrentRow.Cells[7].Value.ToString());
                entidad = Convert.ToInt32(dgvCalificaciones.CurrentRow.Cells[8].Value.ToString());
                civismo = Convert.ToInt32(dgvCalificaciones.CurrentRow.Cells[9].Value.ToString());
                efisica = Convert.ToInt32(dgvCalificaciones.CurrentRow.Cells[10].Value.ToString());
                artes = Convert.ToInt32(dgvCalificaciones.CurrentRow.Cells[11].Value.ToString());
                compu= Convert.ToInt32(dgvCalificaciones.CurrentRow.Cells[12].Value.ToString());
                ingles = Convert.ToInt32(dgvCalificaciones.CurrentRow.Cells[13].Value.ToString());

                if (español < 5 || español > 10 || mate < 5 || mate > 10 || naturales < 5 || naturales > 10 || civismo < 5 || civismo > 10 || efisica < 5 || efisica > 10)
                {
                    MessageBox.Show("Formato de calificacion no valido", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    string mensaje = consultas.Inser_cal_3(español, mate, naturales, entidad, civismo, efisica, artes, compu, ingles, grado, periodo, curp);
                    MessageBox.Show(mensaje, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
            }
            else if (cbGrupoCaptura.Text == "4" || cbGrupoCaptura.Text == "5" || cbGrupoCaptura.Text == "6")
            {
                grado = Convert.ToInt32(cbGrupoCaptura.Text);

                curp = dgvCalificaciones.CurrentRow.Cells[1].Value.ToString();
                español = Convert.ToInt32(dgvCalificaciones.CurrentRow.Cells[5].Value.ToString());
                mate = Convert.ToInt32(dgvCalificaciones.CurrentRow.Cells[6].Value.ToString());
                naturales = Convert.ToInt32(dgvCalificaciones.CurrentRow.Cells[7].Value.ToString());
                geografia = Convert.ToInt32(dgvCalificaciones.CurrentRow.Cells[8].Value.ToString());
                historia = Convert.ToInt32(dgvCalificaciones.CurrentRow.Cells[9].Value.ToString());
                civismo = Convert.ToInt32(dgvCalificaciones.CurrentRow.Cells[10].Value.ToString());
                efisica = Convert.ToInt32(dgvCalificaciones.CurrentRow.Cells[11].Value.ToString());
                artes = Convert.ToInt32(dgvCalificaciones.CurrentRow.Cells[12].Value.ToString());
                compu = Convert.ToInt32(dgvCalificaciones.CurrentRow.Cells[13].Value.ToString());
                ingles = Convert.ToInt32(dgvCalificaciones.CurrentRow.Cells[13].Value.ToString());

                if (español < 5 || español > 10 || mate < 5 || mate > 10 || naturales < 5 || naturales > 10 || geografia < 5 || geografia > 10)
                {
                    MessageBox.Show("Formato de calificacion no valido", "ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else {
                    string mensaje = consultas.Inser_cal_4_5_6(español,mate,naturales,geografia,historia,civismo,efisica,artes,compu,ingles,grado,periodo,curp);
                    MessageBox.Show(mensaje, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (cbGrupoCaptura.SelectedIndex == -1) {
                MessageBox.Show("Seleccione un grupo primero","ADVERTENCIA",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            
            
        }

        private void dgvCalificaciones_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int nuero_filas = 10;

            dgvCalificaciones.AllowUserToAddRows = dgvCalificaciones.RowCount <= nuero_filas;
        }

        private void dgvCalificaciones_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            /*if (dgvCalificaciones.CurrentCell.ColumnIndex == 5 || dgvCalificaciones.CurrentCell.ColumnIndex == 6 || dgvCalificaciones.CurrentCell.ColumnIndex == 7 ||
                dgvCalificaciones.CurrentCell.ColumnIndex == 8 || dgvCalificaciones.CurrentCell.ColumnIndex == 9 || dgvCalificaciones.CurrentCell.ColumnIndex == 10)
            {
                TextBox txt = e.Control as TextBox;

                if (txt != null)
                {
                    txt.KeyPress -= new KeyEventHandler(dgvCalificaciones_KeyPress);
                    txt.KeyPress += new KeyEventHandler(dgvCalificaciones_KeyPress);
                }

            }*/
        }

        private void dgvCalificaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) || e.KeyChar == (Char)Keys.Back)

            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
    }
}
