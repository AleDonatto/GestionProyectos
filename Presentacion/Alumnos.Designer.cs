namespace Presentacion
{
    partial class Alumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alumnos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dgvAlumnos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtCurp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.CBGruposeleccinar = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnGuardarAlumno = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtTipoSangre = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.CBGradoinscripcion = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEnferdadCronica = new System.Windows.Forms.TextBox();
            this.txtAlergias = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre_alumno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAp_materno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAP_paterno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefrescar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnBuscar_grupo = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefrescar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar_grupo)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.dgvAlumnos);
            this.bunifuGradientPanel1.Controls.Add(this.txtCurp);
            this.bunifuGradientPanel1.Controls.Add(this.label12);
            this.bunifuGradientPanel1.Controls.Add(this.CBGruposeleccinar);
            this.bunifuGradientPanel1.Controls.Add(this.label11);
            this.bunifuGradientPanel1.Controls.Add(this.btnGuardarAlumno);
            this.bunifuGradientPanel1.Controls.Add(this.txtTipoSangre);
            this.bunifuGradientPanel1.Controls.Add(this.label21);
            this.bunifuGradientPanel1.Controls.Add(this.CBGradoinscripcion);
            this.bunifuGradientPanel1.Controls.Add(this.label19);
            this.bunifuGradientPanel1.Controls.Add(this.txtDireccion);
            this.bunifuGradientPanel1.Controls.Add(this.label15);
            this.bunifuGradientPanel1.Controls.Add(this.txtEnferdadCronica);
            this.bunifuGradientPanel1.Controls.Add(this.txtAlergias);
            this.bunifuGradientPanel1.Controls.Add(this.label10);
            this.bunifuGradientPanel1.Controls.Add(this.label9);
            this.bunifuGradientPanel1.Controls.Add(this.cbGenero);
            this.bunifuGradientPanel1.Controls.Add(this.label8);
            this.bunifuGradientPanel1.Controls.Add(this.dtpFechaNacimiento);
            this.bunifuGradientPanel1.Controls.Add(this.label7);
            this.bunifuGradientPanel1.Controls.Add(this.txtEdad);
            this.bunifuGradientPanel1.Controls.Add(this.label6);
            this.bunifuGradientPanel1.Controls.Add(this.txtNombre_alumno);
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.txtAp_materno);
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.txtAP_paterno);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.btnRefrescar);
            this.bunifuGradientPanel1.Controls.Add(this.btnBuscar_grupo);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuSeparator1);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(12, 12);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1006, 750);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // dgvAlumnos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAlumnos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlumnos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvAlumnos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAlumnos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlumnos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAlumnos.DoubleBuffered = true;
            this.dgvAlumnos.EnableHeadersVisualStyles = false;
            this.dgvAlumnos.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvAlumnos.HeaderForeColor = System.Drawing.Color.White;
            this.dgvAlumnos.Location = new System.Drawing.Point(53, 107);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAlumnos.Size = new System.Drawing.Size(915, 223);
            this.dgvAlumnos.TabIndex = 70;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 48);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // txtCurp
            // 
            this.txtCurp.Enabled = false;
            this.txtCurp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCurp.Location = new System.Drawing.Point(393, 413);
            this.txtCurp.Name = "txtCurp";
            this.txtCurp.Size = new System.Drawing.Size(166, 23);
            this.txtCurp.TabIndex = 69;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(335, 417);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 17);
            this.label12.TabIndex = 68;
            this.label12.Text = "CURP:";
            // 
            // CBGruposeleccinar
            // 
            this.CBGruposeleccinar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CBGruposeleccinar.FormattingEnabled = true;
            this.CBGruposeleccinar.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.CBGruposeleccinar.Location = new System.Drawing.Point(188, 65);
            this.CBGruposeleccinar.Name = "CBGruposeleccinar";
            this.CBGruposeleccinar.Size = new System.Drawing.Size(121, 24);
            this.CBGruposeleccinar.TabIndex = 67;
            this.CBGruposeleccinar.Text = "Seleccione";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label11.Location = new System.Drawing.Point(49, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 20);
            this.label11.TabIndex = 66;
            this.label11.Text = "Seleccione grupo.";
            // 
            // btnGuardarAlumno
            // 
            this.btnGuardarAlumno.ActiveBorderThickness = 1;
            this.btnGuardarAlumno.ActiveCornerRadius = 20;
            this.btnGuardarAlumno.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarAlumno.ActiveForecolor = System.Drawing.Color.White;
            this.btnGuardarAlumno.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarAlumno.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuardarAlumno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGuardarAlumno.BackgroundImage")));
            this.btnGuardarAlumno.ButtonText = "Actulizar Datos";
            this.btnGuardarAlumno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarAlumno.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarAlumno.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarAlumno.IdleBorderThickness = 1;
            this.btnGuardarAlumno.IdleCornerRadius = 20;
            this.btnGuardarAlumno.IdleFillColor = System.Drawing.Color.White;
            this.btnGuardarAlumno.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnGuardarAlumno.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnGuardarAlumno.Location = new System.Drawing.Point(787, 670);
            this.btnGuardarAlumno.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardarAlumno.Name = "btnGuardarAlumno";
            this.btnGuardarAlumno.Size = new System.Drawing.Size(181, 41);
            this.btnGuardarAlumno.TabIndex = 65;
            this.btnGuardarAlumno.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGuardarAlumno.Click += new System.EventHandler(this.btnGuardarAlumno_Click);
            // 
            // txtTipoSangre
            // 
            this.txtTipoSangre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTipoSangre.Location = new System.Drawing.Point(144, 620);
            this.txtTipoSangre.Name = "txtTipoSangre";
            this.txtTipoSangre.Size = new System.Drawing.Size(166, 23);
            this.txtTipoSangre.TabIndex = 63;
            this.txtTipoSangre.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label21.Location = new System.Drawing.Point(48, 623);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(90, 17);
            this.label21.TabIndex = 64;
            this.label21.Text = "Tipo Sangre:";
            this.label21.Visible = false;
            // 
            // CBGradoinscripcion
            // 
            this.CBGradoinscripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CBGradoinscripcion.FormattingEnabled = true;
            this.CBGradoinscripcion.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.CBGradoinscripcion.Location = new System.Drawing.Point(221, 416);
            this.CBGradoinscripcion.Name = "CBGradoinscripcion";
            this.CBGradoinscripcion.Size = new System.Drawing.Size(92, 24);
            this.CBGradoinscripcion.TabIndex = 46;
            this.CBGradoinscripcion.Text = "Seleccione";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label19.Location = new System.Drawing.Point(48, 419);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(167, 17);
            this.label19.TabIndex = 62;
            this.label19.Text = "Grado al que se inscribe:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDireccion.Location = new System.Drawing.Point(121, 516);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(166, 23);
            this.txtDireccion.TabIndex = 53;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label15.Location = new System.Drawing.Point(45, 519);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 17);
            this.label15.TabIndex = 61;
            this.label15.Text = "Direccion:";
            // 
            // txtEnferdadCronica
            // 
            this.txtEnferdadCronica.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEnferdadCronica.Location = new System.Drawing.Point(191, 569);
            this.txtEnferdadCronica.Name = "txtEnferdadCronica";
            this.txtEnferdadCronica.Size = new System.Drawing.Size(166, 23);
            this.txtEnferdadCronica.TabIndex = 57;
            this.txtEnferdadCronica.Visible = false;
            // 
            // txtAlergias
            // 
            this.txtAlergias.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAlergias.Location = new System.Drawing.Point(442, 572);
            this.txtAlergias.Name = "txtAlergias";
            this.txtAlergias.Size = new System.Drawing.Size(166, 23);
            this.txtAlergias.TabIndex = 59;
            this.txtAlergias.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(44, 571);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 17);
            this.label10.TabIndex = 58;
            this.label10.Text = "Enfermedad Cronica:";
            this.label10.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(373, 574);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 55;
            this.label9.Text = "Alergias:";
            this.label9.Visible = false;
            // 
            // cbGenero
            // 
            this.cbGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Otro"});
            this.cbGenero.Location = new System.Drawing.Point(727, 569);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(168, 24);
            this.cbGenero.TabIndex = 60;
            this.cbGenero.Text = "Seleccione";
            this.cbGenero.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(661, 573);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 52;
            this.label8.Text = "Genero:";
            this.label8.Visible = false;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CustomFormat = "yyyy/MM/dd";
            this.dtpFechaNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(645, 521);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(246, 23);
            this.dtpFechaNacimiento.TabIndex = 56;
            this.dtpFechaNacimiento.Value = new System.DateTime(2018, 9, 26, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(490, 522);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 17);
            this.label7.TabIndex = 50;
            this.label7.Text = "Fecha de Nacimineto:";
            // 
            // txtEdad
            // 
            this.txtEdad.AutoCompleteCustomSource.AddRange(new string[] {
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtEdad.Location = new System.Drawing.Point(358, 519);
            this.txtEdad.MaxLength = 2;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(110, 23);
            this.txtEdad.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(307, 522);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 47;
            this.label6.Text = "Edad:";
            // 
            // txtNombre_alumno
            // 
            this.txtNombre_alumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNombre_alumno.Location = new System.Drawing.Point(112, 465);
            this.txtNombre_alumno.Name = "txtNombre_alumno";
            this.txtNombre_alumno.Size = new System.Drawing.Size(166, 23);
            this.txtNombre_alumno.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(44, 469);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "Nombre:";
            // 
            // txtAp_materno
            // 
            this.txtAp_materno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAp_materno.Location = new System.Drawing.Point(735, 467);
            this.txtAp_materno.Name = "txtAp_materno";
            this.txtAp_materno.Size = new System.Drawing.Size(156, 23);
            this.txtAp_materno.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(611, 472);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Apellido Materno:";
            // 
            // txtAP_paterno
            // 
            this.txtAP_paterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAP_paterno.Location = new System.Drawing.Point(425, 465);
            this.txtAP_paterno.Name = "txtAP_paterno";
            this.txtAP_paterno.Size = new System.Drawing.Size(165, 23);
            this.txtAP_paterno.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(303, 469);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "Apellido Paterno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(50, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "MODIFICACION DE ALUMNOS";
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.White;
            this.btnRefrescar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnRefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.ImageActive = null;
            this.btnRefrescar.Location = new System.Drawing.Point(929, 66);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(39, 35);
            this.btnRefrescar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRefrescar.TabIndex = 7;
            this.btnRefrescar.TabStop = false;
            this.btnRefrescar.Zoom = 10;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnBuscar_grupo
            // 
            this.btnBuscar_grupo.BackColor = System.Drawing.Color.White;
            this.btnBuscar_grupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnBuscar_grupo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar_grupo.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar_grupo.Image")));
            this.btnBuscar_grupo.ImageActive = null;
            this.btnBuscar_grupo.Location = new System.Drawing.Point(331, 65);
            this.btnBuscar_grupo.Name = "btnBuscar_grupo";
            this.btnBuscar_grupo.Size = new System.Drawing.Size(39, 35);
            this.btnBuscar_grupo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar_grupo.TabIndex = 6;
            this.btnBuscar_grupo.TabStop = false;
            this.btnBuscar_grupo.Zoom = 10;
            this.btnBuscar_grupo.Click += new System.EventHandler(this.btnBuscar_grupo_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(3, 336);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1000, 35);
            this.bunifuSeparator1.TabIndex = 2;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONSULTA DE ALUMNOS";
            // 
            // Alumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1030, 774);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alumnos";
            this.Text = "Alumnos";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRefrescar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar_grupo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton btnRefrescar;
        private Bunifu.Framework.UI.BunifuImageButton btnBuscar_grupo;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGuardarAlumno;
        private System.Windows.Forms.TextBox txtTipoSangre;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox CBGradoinscripcion;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEnferdadCronica;
        private System.Windows.Forms.TextBox txtAlergias;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre_alumno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAp_materno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAP_paterno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBGruposeleccinar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.TextBox txtCurp;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvAlumnos;
    }
}