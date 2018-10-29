namespace Presentacion
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.Pmenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnAlumnos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnProfesores = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnModificarCalificaciones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMaterias = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnInscripciones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGrupos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.P_formularios = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.Pmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.bunifuGradientPanel1.Controls.Add(this.btnMinimize);
            this.bunifuGradientPanel1.Controls.Add(this.btnClose);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.SystemColors.ControlLight;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.SystemColors.ControlLight;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.SystemColors.ControlLight;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.SystemColors.ControlLight;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1310, 39);
            this.bunifuGradientPanel1.TabIndex = 4;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(1234, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(38, 36);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(1269, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(38, 36);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Pmenu
            // 
            this.Pmenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pmenu.BackgroundImage")));
            this.Pmenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pmenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pmenu.Controls.Add(this.btnAlumnos);
            this.Pmenu.Controls.Add(this.bunifuSeparator2);
            this.Pmenu.Controls.Add(this.bunifuSeparator1);
            this.Pmenu.Controls.Add(this.btnProfesores);
            this.Pmenu.Controls.Add(this.btnModificarCalificaciones);
            this.Pmenu.Controls.Add(this.label5);
            this.Pmenu.Controls.Add(this.label4);
            this.Pmenu.Controls.Add(this.label3);
            this.Pmenu.Controls.Add(this.label2);
            this.Pmenu.Controls.Add(this.label1);
            this.Pmenu.Controls.Add(this.btnMaterias);
            this.Pmenu.Controls.Add(this.btnInscripciones);
            this.Pmenu.Controls.Add(this.btnGrupos);
            this.Pmenu.Controls.Add(this.pictureBox1);
            this.Pmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pmenu.GradientBottomLeft = System.Drawing.Color.White;
            this.Pmenu.GradientBottomRight = System.Drawing.Color.White;
            this.Pmenu.GradientTopLeft = System.Drawing.Color.White;
            this.Pmenu.GradientTopRight = System.Drawing.Color.White;
            this.Pmenu.Location = new System.Drawing.Point(0, 39);
            this.Pmenu.Name = "Pmenu";
            this.Pmenu.Quality = 10;
            this.Pmenu.Size = new System.Drawing.Size(268, 661);
            this.Pmenu.TabIndex = 5;
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.Activecolor = System.Drawing.Color.LightGray;
            this.btnAlumnos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAlumnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlumnos.BorderRadius = 0;
            this.btnAlumnos.ButtonText = "ALUMNOS";
            this.btnAlumnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlumnos.DisabledColor = System.Drawing.Color.Gray;
            this.btnAlumnos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAlumnos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAlumnos.Iconimage")));
            this.btnAlumnos.Iconimage_right = null;
            this.btnAlumnos.Iconimage_right_Selected = null;
            this.btnAlumnos.Iconimage_Selected = null;
            this.btnAlumnos.IconMarginLeft = 0;
            this.btnAlumnos.IconMarginRight = 0;
            this.btnAlumnos.IconRightVisible = true;
            this.btnAlumnos.IconRightZoom = 0D;
            this.btnAlumnos.IconVisible = true;
            this.btnAlumnos.IconZoom = 90D;
            this.btnAlumnos.IsTab = false;
            this.btnAlumnos.Location = new System.Drawing.Point(6, 405);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnAlumnos.OnHovercolor = System.Drawing.Color.LightGray;
            this.btnAlumnos.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnAlumnos.selected = false;
            this.btnAlumnos.Size = new System.Drawing.Size(261, 48);
            this.btnAlumnos.TabIndex = 13;
            this.btnAlumnos.Text = "ALUMNOS";
            this.btnAlumnos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAlumnos.Textcolor = System.Drawing.Color.Black;
            this.btnAlumnos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(1, 241);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(264, 12);
            this.bunifuSeparator2.TabIndex = 12;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(1, 160);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(264, 28);
            this.bunifuSeparator1.TabIndex = 11;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // btnProfesores
            // 
            this.btnProfesores.Activecolor = System.Drawing.Color.LightGray;
            this.btnProfesores.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnProfesores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProfesores.BorderRadius = 0;
            this.btnProfesores.ButtonText = "CAPTURA DE CALIFICAIONES";
            this.btnProfesores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfesores.DisabledColor = System.Drawing.Color.Gray;
            this.btnProfesores.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProfesores.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProfesores.Iconimage")));
            this.btnProfesores.Iconimage_right = null;
            this.btnProfesores.Iconimage_right_Selected = null;
            this.btnProfesores.Iconimage_Selected = null;
            this.btnProfesores.IconMarginLeft = 0;
            this.btnProfesores.IconMarginRight = 0;
            this.btnProfesores.IconRightVisible = true;
            this.btnProfesores.IconRightZoom = 0D;
            this.btnProfesores.IconVisible = true;
            this.btnProfesores.IconZoom = 90D;
            this.btnProfesores.IsTab = false;
            this.btnProfesores.Location = new System.Drawing.Point(6, 455);
            this.btnProfesores.Name = "btnProfesores";
            this.btnProfesores.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnProfesores.OnHovercolor = System.Drawing.Color.LightGray;
            this.btnProfesores.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnProfesores.selected = false;
            this.btnProfesores.Size = new System.Drawing.Size(261, 48);
            this.btnProfesores.TabIndex = 10;
            this.btnProfesores.Text = "CAPTURA DE CALIFICAIONES";
            this.btnProfesores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnProfesores.Textcolor = System.Drawing.Color.Black;
            this.btnProfesores.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfesores.Click += new System.EventHandler(this.btnProfesores_Click);
            // 
            // btnModificarCalificaciones
            // 
            this.btnModificarCalificaciones.Activecolor = System.Drawing.Color.LightGray;
            this.btnModificarCalificaciones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificarCalificaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarCalificaciones.BorderRadius = 0;
            this.btnModificarCalificaciones.ButtonText = "MODIFICAR CALIFICACIONES";
            this.btnModificarCalificaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarCalificaciones.DisabledColor = System.Drawing.Color.Gray;
            this.btnModificarCalificaciones.Iconcolor = System.Drawing.Color.Transparent;
            this.btnModificarCalificaciones.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnModificarCalificaciones.Iconimage")));
            this.btnModificarCalificaciones.Iconimage_right = null;
            this.btnModificarCalificaciones.Iconimage_right_Selected = null;
            this.btnModificarCalificaciones.Iconimage_Selected = null;
            this.btnModificarCalificaciones.IconMarginLeft = 0;
            this.btnModificarCalificaciones.IconMarginRight = 0;
            this.btnModificarCalificaciones.IconRightVisible = true;
            this.btnModificarCalificaciones.IconRightZoom = 0D;
            this.btnModificarCalificaciones.IconVisible = true;
            this.btnModificarCalificaciones.IconZoom = 90D;
            this.btnModificarCalificaciones.IsTab = false;
            this.btnModificarCalificaciones.Location = new System.Drawing.Point(7, 600);
            this.btnModificarCalificaciones.Name = "btnModificarCalificaciones";
            this.btnModificarCalificaciones.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnModificarCalificaciones.OnHovercolor = System.Drawing.Color.LightGray;
            this.btnModificarCalificaciones.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnModificarCalificaciones.selected = false;
            this.btnModificarCalificaciones.Size = new System.Drawing.Size(261, 48);
            this.btnModificarCalificaciones.TabIndex = 9;
            this.btnModificarCalificaciones.Text = "MODIFICAR CALIFICACIONES";
            this.btnModificarCalificaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModificarCalificaciones.Textcolor = System.Drawing.Color.Black;
            this.btnModificarCalificaciones.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(75, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(153, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(91, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(13, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cargo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(13, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre:";
            // 
            // btnMaterias
            // 
            this.btnMaterias.Activecolor = System.Drawing.Color.LightGray;
            this.btnMaterias.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMaterias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaterias.BorderRadius = 0;
            this.btnMaterias.ButtonText = "MATERIAS";
            this.btnMaterias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaterias.DisabledColor = System.Drawing.Color.Gray;
            this.btnMaterias.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMaterias.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMaterias.Iconimage")));
            this.btnMaterias.Iconimage_right = null;
            this.btnMaterias.Iconimage_right_Selected = null;
            this.btnMaterias.Iconimage_Selected = null;
            this.btnMaterias.IconMarginLeft = 0;
            this.btnMaterias.IconMarginRight = 0;
            this.btnMaterias.IconRightVisible = true;
            this.btnMaterias.IconRightZoom = 0D;
            this.btnMaterias.IconVisible = true;
            this.btnMaterias.IconZoom = 90D;
            this.btnMaterias.IsTab = false;
            this.btnMaterias.Location = new System.Drawing.Point(4, 307);
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnMaterias.OnHovercolor = System.Drawing.Color.LightGray;
            this.btnMaterias.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnMaterias.selected = false;
            this.btnMaterias.Size = new System.Drawing.Size(261, 48);
            this.btnMaterias.TabIndex = 3;
            this.btnMaterias.Text = "MATERIAS";
            this.btnMaterias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMaterias.Textcolor = System.Drawing.Color.Black;
            this.btnMaterias.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterias.Click += new System.EventHandler(this.btnMaterias_Click);
            // 
            // btnInscripciones
            // 
            this.btnInscripciones.Activecolor = System.Drawing.Color.LightGray;
            this.btnInscripciones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnInscripciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInscripciones.BorderRadius = 0;
            this.btnInscripciones.ButtonText = "INSCRIPCIONES";
            this.btnInscripciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInscripciones.DisabledColor = System.Drawing.Color.Gray;
            this.btnInscripciones.Iconcolor = System.Drawing.Color.Transparent;
            this.btnInscripciones.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnInscripciones.Iconimage")));
            this.btnInscripciones.Iconimage_right = null;
            this.btnInscripciones.Iconimage_right_Selected = null;
            this.btnInscripciones.Iconimage_Selected = null;
            this.btnInscripciones.IconMarginLeft = 0;
            this.btnInscripciones.IconMarginRight = 0;
            this.btnInscripciones.IconRightVisible = true;
            this.btnInscripciones.IconRightZoom = 0D;
            this.btnInscripciones.IconVisible = true;
            this.btnInscripciones.IconZoom = 90D;
            this.btnInscripciones.IsTab = false;
            this.btnInscripciones.Location = new System.Drawing.Point(5, 356);
            this.btnInscripciones.Name = "btnInscripciones";
            this.btnInscripciones.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnInscripciones.OnHovercolor = System.Drawing.Color.LightGray;
            this.btnInscripciones.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnInscripciones.selected = false;
            this.btnInscripciones.Size = new System.Drawing.Size(261, 48);
            this.btnInscripciones.TabIndex = 2;
            this.btnInscripciones.Text = "INSCRIPCIONES";
            this.btnInscripciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnInscripciones.Textcolor = System.Drawing.Color.Black;
            this.btnInscripciones.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInscripciones.Click += new System.EventHandler(this.btnInscripciones_Click);
            // 
            // btnGrupos
            // 
            this.btnGrupos.Activecolor = System.Drawing.Color.LightGray;
            this.btnGrupos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGrupos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGrupos.BorderRadius = 0;
            this.btnGrupos.ButtonText = "GRUPOS";
            this.btnGrupos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrupos.DisabledColor = System.Drawing.Color.Gray;
            this.btnGrupos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGrupos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGrupos.Iconimage")));
            this.btnGrupos.Iconimage_right = null;
            this.btnGrupos.Iconimage_right_Selected = null;
            this.btnGrupos.Iconimage_Selected = null;
            this.btnGrupos.IconMarginLeft = 0;
            this.btnGrupos.IconMarginRight = 0;
            this.btnGrupos.IconRightVisible = true;
            this.btnGrupos.IconRightZoom = 0D;
            this.btnGrupos.IconVisible = true;
            this.btnGrupos.IconZoom = 90D;
            this.btnGrupos.IsTab = false;
            this.btnGrupos.Location = new System.Drawing.Point(4, 259);
            this.btnGrupos.Name = "btnGrupos";
            this.btnGrupos.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnGrupos.OnHovercolor = System.Drawing.Color.LightGray;
            this.btnGrupos.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnGrupos.selected = false;
            this.btnGrupos.Size = new System.Drawing.Size(261, 48);
            this.btnGrupos.TabIndex = 1;
            this.btnGrupos.Text = "GRUPOS";
            this.btnGrupos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGrupos.Textcolor = System.Drawing.Color.Black;
            this.btnGrupos.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrupos.Click += new System.EventHandler(this.btnGrupos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // P_formularios
            // 
            this.P_formularios.AutoScroll = true;
            this.P_formularios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("P_formularios.BackgroundImage")));
            this.P_formularios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.P_formularios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P_formularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_formularios.GradientBottomLeft = System.Drawing.Color.White;
            this.P_formularios.GradientBottomRight = System.Drawing.Color.White;
            this.P_formularios.GradientTopLeft = System.Drawing.Color.White;
            this.P_formularios.GradientTopRight = System.Drawing.Color.White;
            this.P_formularios.Location = new System.Drawing.Point(268, 39);
            this.P_formularios.Name = "P_formularios";
            this.P_formularios.Quality = 10;
            this.P_formularios.Size = new System.Drawing.Size(1042, 661);
            this.P_formularios.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 700);
            this.Controls.Add(this.P_formularios);
            this.Controls.Add(this.Pmenu);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.Pmenu.ResumeLayout(false);
            this.Pmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuGradientPanel Pmenu;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnMaterias;
        private Bunifu.Framework.UI.BunifuFlatButton btnInscripciones;
        private Bunifu.Framework.UI.BunifuFlatButton btnGrupos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuGradientPanel P_formularios;
        public Bunifu.Framework.UI.BunifuFlatButton btnModificarCalificaciones;
        private Bunifu.Framework.UI.BunifuFlatButton btnProfesores;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        public Bunifu.Framework.UI.BunifuFlatButton btnAlumnos;
    }
}