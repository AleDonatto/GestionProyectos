namespace GestionProyectos
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
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.Pcabezera = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnChico = new Bunifu.Framework.UI.BunifuImageButton();
            this.Pmenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnCerrarSesion = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lnombre = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnModificarCalificaciones = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMaterias = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGrupo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.P_formularios = new Bunifu.Framework.UI.BunifuGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.Pcabezera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnChico)).BeginInit();
            this.Pmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1228, 1);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(37, 29);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Pcabezera;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Pcabezera
            // 
            this.Pcabezera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Pcabezera.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pcabezera.BackgroundImage")));
            this.Pcabezera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pcabezera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pcabezera.Controls.Add(this.btnChico);
            this.Pcabezera.Controls.Add(this.bunifuImageButton1);
            this.bunifuTransition1.SetDecoration(this.Pcabezera, BunifuAnimatorNS.DecorationType.None);
            this.Pcabezera.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pcabezera.GradientBottomLeft = System.Drawing.Color.White;
            this.Pcabezera.GradientBottomRight = System.Drawing.Color.White;
            this.Pcabezera.GradientTopLeft = System.Drawing.Color.White;
            this.Pcabezera.GradientTopRight = System.Drawing.Color.White;
            this.Pcabezera.Location = new System.Drawing.Point(0, 0);
            this.Pcabezera.Name = "Pcabezera";
            this.Pcabezera.Quality = 10;
            this.Pcabezera.Size = new System.Drawing.Size(1270, 35);
            this.Pcabezera.TabIndex = 0;
            // 
            // btnChico
            // 
            this.btnChico.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.btnChico, BunifuAnimatorNS.DecorationType.None);
            this.btnChico.Image = ((System.Drawing.Image)(resources.GetObject("btnChico.Image")));
            this.btnChico.ImageActive = null;
            this.btnChico.Location = new System.Drawing.Point(1185, 1);
            this.btnChico.Name = "btnChico";
            this.btnChico.Size = new System.Drawing.Size(37, 29);
            this.btnChico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnChico.TabIndex = 2;
            this.btnChico.TabStop = false;
            this.btnChico.Zoom = 10;
            this.btnChico.Click += new System.EventHandler(this.btnChico_Click);
            // 
            // Pmenu
            // 
            this.Pmenu.BackColor = System.Drawing.Color.Gainsboro;
            this.Pmenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pmenu.BackgroundImage")));
            this.Pmenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pmenu.Controls.Add(this.btnModificarCalificaciones);
            this.Pmenu.Controls.Add(this.btnCerrarSesion);
            this.Pmenu.Controls.Add(this.bunifuSeparator2);
            this.Pmenu.Controls.Add(this.bunifuSeparator1);
            this.Pmenu.Controls.Add(this.label4);
            this.Pmenu.Controls.Add(this.label3);
            this.Pmenu.Controls.Add(this.label2);
            this.Pmenu.Controls.Add(this.label1);
            this.Pmenu.Controls.Add(this.Lnombre);
            this.Pmenu.Controls.Add(this.pictureBox3);
            this.Pmenu.Controls.Add(this.pictureBox2);
            this.Pmenu.Controls.Add(this.bunifuFlatButton5);
            this.Pmenu.Controls.Add(this.btnMaterias);
            this.Pmenu.Controls.Add(this.bunifuFlatButton3);
            this.Pmenu.Controls.Add(this.bunifuFlatButton2);
            this.Pmenu.Controls.Add(this.btnGrupo);
            this.Pmenu.Controls.Add(this.pictureBox1);
            this.bunifuTransition1.SetDecoration(this.Pmenu, BunifuAnimatorNS.DecorationType.None);
            this.Pmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pmenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.Pmenu.GradientBottomLeft = System.Drawing.Color.White;
            this.Pmenu.GradientBottomRight = System.Drawing.Color.White;
            this.Pmenu.GradientTopLeft = System.Drawing.Color.White;
            this.Pmenu.GradientTopRight = System.Drawing.Color.White;
            this.Pmenu.Location = new System.Drawing.Point(0, 35);
            this.Pmenu.Name = "Pmenu";
            this.Pmenu.Quality = 10;
            this.Pmenu.Size = new System.Drawing.Size(250, 615);
            this.Pmenu.TabIndex = 1;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuTransition1.SetDecoration(this.btnCerrarSesion, BunifuAnimatorNS.DecorationType.None);
            this.btnCerrarSesion.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarSesion.Image")));
            this.btnCerrarSesion.ImageActive = null;
            this.btnCerrarSesion.Location = new System.Drawing.Point(186, 182);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(55, 48);
            this.btnCerrarSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarSesion.TabIndex = 18;
            this.btnCerrarSesion.TabStop = false;
            this.btnCerrarSesion.Zoom = 10;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(3, 169);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(244, 17);
            this.bunifuSeparator2.TabIndex = 17;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition1.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(3, 227);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(244, 14);
            this.bunifuSeparator1.TabIndex = 16;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(66, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(119, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(66, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cargo:";
            // 
            // Lnombre
            // 
            this.Lnombre.AutoSize = true;
            this.Lnombre.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.Lnombre, BunifuAnimatorNS.DecorationType.None);
            this.Lnombre.ForeColor = System.Drawing.Color.Black;
            this.Lnombre.Location = new System.Drawing.Point(3, 189);
            this.Lnombre.Name = "Lnombre";
            this.Lnombre.Size = new System.Drawing.Size(47, 13);
            this.Lnombre.TabIndex = 12;
            this.Lnombre.Text = "Nombre:";
            // 
            // pictureBox3
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(3, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // pictureBox2
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(203, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // btnModificarCalificaciones
            // 
            this.btnModificarCalificaciones.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnModificarCalificaciones.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnModificarCalificaciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarCalificaciones.BorderRadius = 0;
            this.btnModificarCalificaciones.ButtonText = "MODIFICAR CALIFICACIONES";
            this.btnModificarCalificaciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnModificarCalificaciones, BunifuAnimatorNS.DecorationType.None);
            this.btnModificarCalificaciones.DisabledColor = System.Drawing.Color.Gray;
            this.btnModificarCalificaciones.ForeColor = System.Drawing.Color.DimGray;
            this.btnModificarCalificaciones.Iconcolor = System.Drawing.Color.WhiteSmoke;
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
            this.btnModificarCalificaciones.Location = new System.Drawing.Point(2, 504);
            this.btnModificarCalificaciones.Name = "btnModificarCalificaciones";
            this.btnModificarCalificaciones.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnModificarCalificaciones.OnHovercolor = System.Drawing.Color.LightGray;
            this.btnModificarCalificaciones.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnModificarCalificaciones.selected = false;
            this.btnModificarCalificaciones.Size = new System.Drawing.Size(248, 48);
            this.btnModificarCalificaciones.TabIndex = 9;
            this.btnModificarCalificaciones.Text = "MODIFICAR CALIFICACIONES";
            this.btnModificarCalificaciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModificarCalificaciones.Textcolor = System.Drawing.Color.Black;
            this.btnModificarCalificaciones.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "PROFESORES";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton5.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton5.Iconimage")));
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 90D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(2, 339);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(248, 48);
            this.bunifuFlatButton5.TabIndex = 8;
            this.bunifuFlatButton5.Text = "PROFESORES";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnMaterias
            // 
            this.btnMaterias.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMaterias.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnMaterias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaterias.BorderRadius = 0;
            this.btnMaterias.ButtonText = "MATERIAS";
            this.btnMaterias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnMaterias, BunifuAnimatorNS.DecorationType.None);
            this.btnMaterias.DisabledColor = System.Drawing.Color.Gray;
            this.btnMaterias.ForeColor = System.Drawing.Color.DimGray;
            this.btnMaterias.Iconcolor = System.Drawing.Color.WhiteSmoke;
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
            this.btnMaterias.Location = new System.Drawing.Point(2, 292);
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnMaterias.OnHovercolor = System.Drawing.Color.LightGray;
            this.btnMaterias.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnMaterias.selected = false;
            this.btnMaterias.Size = new System.Drawing.Size(248, 48);
            this.btnMaterias.TabIndex = 7;
            this.btnMaterias.Text = "MATERIAS";
            this.btnMaterias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMaterias.Textcolor = System.Drawing.Color.Black;
            this.btnMaterias.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "CALIFICAIONES";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(2, 438);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(248, 48);
            this.bunifuFlatButton3.TabIndex = 6;
            this.bunifuFlatButton3.Text = "CALIFICAIONES";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "INSCRIPCIONES";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(2, 391);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(248, 48);
            this.bunifuFlatButton2.TabIndex = 5;
            this.bunifuFlatButton2.Text = "INSCRIPCIONES";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnGrupo
            // 
            this.btnGrupo.Activecolor = System.Drawing.Color.WhiteSmoke;
            this.btnGrupo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGrupo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGrupo.BorderRadius = 0;
            this.btnGrupo.ButtonText = "GRUPOS";
            this.btnGrupo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnGrupo, BunifuAnimatorNS.DecorationType.None);
            this.btnGrupo.DisabledColor = System.Drawing.Color.Gray;
            this.btnGrupo.ForeColor = System.Drawing.Color.DimGray;
            this.btnGrupo.Iconcolor = System.Drawing.Color.WhiteSmoke;
            this.btnGrupo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGrupo.Iconimage")));
            this.btnGrupo.Iconimage_right = null;
            this.btnGrupo.Iconimage_right_Selected = null;
            this.btnGrupo.Iconimage_Selected = null;
            this.btnGrupo.IconMarginLeft = 0;
            this.btnGrupo.IconMarginRight = 0;
            this.btnGrupo.IconRightVisible = true;
            this.btnGrupo.IconRightZoom = 0D;
            this.btnGrupo.IconVisible = true;
            this.btnGrupo.IconZoom = 90D;
            this.btnGrupo.IsTab = false;
            this.btnGrupo.Location = new System.Drawing.Point(2, 247);
            this.btnGrupo.Name = "btnGrupo";
            this.btnGrupo.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.btnGrupo.OnHovercolor = System.Drawing.Color.LightGray;
            this.btnGrupo.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnGrupo.selected = false;
            this.btnGrupo.Size = new System.Drawing.Size(248, 48);
            this.btnGrupo.TabIndex = 4;
            this.btnGrupo.Text = "GRUPOS";
            this.btnGrupo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGrupo.Textcolor = System.Drawing.Color.Black;
            this.btnGrupo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnGrupo.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation2;
            // 
            // P_formularios
            // 
            this.P_formularios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("P_formularios.BackgroundImage")));
            this.P_formularios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.P_formularios, BunifuAnimatorNS.DecorationType.None);
            this.P_formularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.P_formularios.GradientBottomLeft = System.Drawing.Color.White;
            this.P_formularios.GradientBottomRight = System.Drawing.Color.White;
            this.P_formularios.GradientTopLeft = System.Drawing.Color.White;
            this.P_formularios.GradientTopRight = System.Drawing.Color.White;
            this.P_formularios.Location = new System.Drawing.Point(250, 35);
            this.P_formularios.Name = "P_formularios";
            this.P_formularios.Quality = 10;
            this.P_formularios.Size = new System.Drawing.Size(1020, 615);
            this.P_formularios.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1270, 650);
            this.Controls.Add(this.P_formularios);
            this.Controls.Add(this.Pmenu);
            this.Controls.Add(this.Pcabezera);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.Pcabezera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnChico)).EndInit();
            this.Pmenu.ResumeLayout(false);
            this.Pmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarSesion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuGradientPanel Pmenu;
        private Bunifu.Framework.UI.BunifuFlatButton btnMaterias;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton btnGrupo;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lnombre;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrarSesion;
        private Bunifu.Framework.UI.BunifuGradientPanel Pcabezera;
        private Bunifu.Framework.UI.BunifuImageButton btnChico;
        private Bunifu.Framework.UI.BunifuGradientPanel P_formularios;
        public Bunifu.Framework.UI.BunifuFlatButton btnModificarCalificaciones;
    }
}