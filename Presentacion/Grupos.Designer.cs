namespace Presentacion
{
    partial class Grupos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Grupos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dgvGrupos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModificar_grupo = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txtAula_mod = new System.Windows.Forms.TextBox();
            this.txtGrupo_mod = new System.Windows.Forms.TextBox();
            this.txtGrado_mod = new System.Windows.Forms.TextBox();
            this.txtidgrupo_mod = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnRefrescar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnBuscar_grupo = new Bunifu.Framework.UI.BunifuImageButton();
            this.CBGruposeleccinar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListasGrupos = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).BeginInit();
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
            this.bunifuGradientPanel1.Controls.Add(this.btnListasGrupos);
            this.bunifuGradientPanel1.Controls.Add(this.dgvGrupos);
            this.bunifuGradientPanel1.Controls.Add(this.btnModificar_grupo);
            this.bunifuGradientPanel1.Controls.Add(this.txtAula_mod);
            this.bunifuGradientPanel1.Controls.Add(this.txtGrupo_mod);
            this.bunifuGradientPanel1.Controls.Add(this.txtGrado_mod);
            this.bunifuGradientPanel1.Controls.Add(this.txtidgrupo_mod);
            this.bunifuGradientPanel1.Controls.Add(this.label7);
            this.bunifuGradientPanel1.Controls.Add(this.label6);
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuSeparator1);
            this.bunifuGradientPanel1.Controls.Add(this.btnRefrescar);
            this.bunifuGradientPanel1.Controls.Add(this.btnBuscar_grupo);
            this.bunifuGradientPanel1.Controls.Add(this.CBGruposeleccinar);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(10, 9);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1020, 624);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // dgvGrupos
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvGrupos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGrupos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGrupos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvGrupos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGrupos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrupos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvGrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupos.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvGrupos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGrupos.DoubleBuffered = true;
            this.dgvGrupos.EnableHeadersVisualStyles = false;
            this.dgvGrupos.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvGrupos.HeaderForeColor = System.Drawing.Color.White;
            this.dgvGrupos.Location = new System.Drawing.Point(59, 110);
            this.dgvGrupos.Name = "dgvGrupos";
            this.dgvGrupos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvGrupos.Size = new System.Drawing.Size(898, 210);
            this.dgvGrupos.TabIndex = 17;
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
            // btnModificar_grupo
            // 
            this.btnModificar_grupo.ActiveBorderThickness = 1;
            this.btnModificar_grupo.ActiveCornerRadius = 20;
            this.btnModificar_grupo.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnModificar_grupo.ActiveForecolor = System.Drawing.Color.White;
            this.btnModificar_grupo.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnModificar_grupo.BackColor = System.Drawing.SystemColors.Control;
            this.btnModificar_grupo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnModificar_grupo.BackgroundImage")));
            this.btnModificar_grupo.ButtonText = "Modificar Grupo";
            this.btnModificar_grupo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar_grupo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar_grupo.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnModificar_grupo.IdleBorderThickness = 1;
            this.btnModificar_grupo.IdleCornerRadius = 20;
            this.btnModificar_grupo.IdleFillColor = System.Drawing.Color.White;
            this.btnModificar_grupo.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnModificar_grupo.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnModificar_grupo.Location = new System.Drawing.Point(776, 502);
            this.btnModificar_grupo.Margin = new System.Windows.Forms.Padding(5);
            this.btnModificar_grupo.Name = "btnModificar_grupo";
            this.btnModificar_grupo.Size = new System.Drawing.Size(181, 41);
            this.btnModificar_grupo.TabIndex = 16;
            this.btnModificar_grupo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModificar_grupo.Click += new System.EventHandler(this.btnModificar_grupo_Click);
            // 
            // txtAula_mod
            // 
            this.txtAula_mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAula_mod.Location = new System.Drawing.Point(845, 438);
            this.txtAula_mod.Name = "txtAula_mod";
            this.txtAula_mod.Size = new System.Drawing.Size(100, 23);
            this.txtAula_mod.TabIndex = 15;
            // 
            // txtGrupo_mod
            // 
            this.txtGrupo_mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtGrupo_mod.Location = new System.Drawing.Point(607, 438);
            this.txtGrupo_mod.Name = "txtGrupo_mod";
            this.txtGrupo_mod.Size = new System.Drawing.Size(100, 23);
            this.txtGrupo_mod.TabIndex = 14;
            // 
            // txtGrado_mod
            // 
            this.txtGrado_mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtGrado_mod.Location = new System.Drawing.Point(357, 435);
            this.txtGrado_mod.Name = "txtGrado_mod";
            this.txtGrado_mod.Size = new System.Drawing.Size(100, 23);
            this.txtGrado_mod.TabIndex = 13;
            // 
            // txtidgrupo_mod
            // 
            this.txtidgrupo_mod.Enabled = false;
            this.txtidgrupo_mod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtidgrupo_mod.Location = new System.Drawing.Point(125, 437);
            this.txtidgrupo_mod.Name = "txtidgrupo_mod";
            this.txtidgrupo_mod.Size = new System.Drawing.Size(100, 23);
            this.txtidgrupo_mod.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(800, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Aula";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(48, 438);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "ID grado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(299, 436);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Grado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(549, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Grupo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(55, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Modificacionn de grupos.";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(3, 326);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1014, 35);
            this.bunifuSeparator1.TabIndex = 6;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.BackColor = System.Drawing.Color.White;
            this.btnRefrescar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnRefrescar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.ImageActive = null;
            this.btnRefrescar.Location = new System.Drawing.Point(391, 72);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(39, 35);
            this.btnRefrescar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRefrescar.TabIndex = 5;
            this.btnRefrescar.TabStop = false;
            this.btnRefrescar.Zoom = 10;
            // 
            // btnBuscar_grupo
            // 
            this.btnBuscar_grupo.BackColor = System.Drawing.Color.White;
            this.btnBuscar_grupo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnBuscar_grupo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar_grupo.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar_grupo.Image")));
            this.btnBuscar_grupo.ImageActive = null;
            this.btnBuscar_grupo.Location = new System.Drawing.Point(346, 72);
            this.btnBuscar_grupo.Name = "btnBuscar_grupo";
            this.btnBuscar_grupo.Size = new System.Drawing.Size(39, 35);
            this.btnBuscar_grupo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBuscar_grupo.TabIndex = 4;
            this.btnBuscar_grupo.TabStop = false;
            this.btnBuscar_grupo.Zoom = 10;
            this.btnBuscar_grupo.Click += new System.EventHandler(this.btnBuscar_grupo_Click);
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
            this.CBGruposeleccinar.Location = new System.Drawing.Point(200, 80);
            this.CBGruposeleccinar.Name = "CBGruposeleccinar";
            this.CBGruposeleccinar.Size = new System.Drawing.Size(121, 24);
            this.CBGruposeleccinar.TabIndex = 3;
            this.CBGruposeleccinar.Text = "Seleccione";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(61, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione grupo.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(55, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Conslta de grupos.";
            // 
            // btnListasGrupos
            // 
            this.btnListasGrupos.ActiveBorderThickness = 1;
            this.btnListasGrupos.ActiveCornerRadius = 20;
            this.btnListasGrupos.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnListasGrupos.ActiveForecolor = System.Drawing.Color.White;
            this.btnListasGrupos.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnListasGrupos.BackColor = System.Drawing.SystemColors.Control;
            this.btnListasGrupos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnListasGrupos.BackgroundImage")));
            this.btnListasGrupos.ButtonText = "Ver Listas de Grupos";
            this.btnListasGrupos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListasGrupos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListasGrupos.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnListasGrupos.IdleBorderThickness = 1;
            this.btnListasGrupos.IdleCornerRadius = 20;
            this.btnListasGrupos.IdleFillColor = System.Drawing.Color.White;
            this.btnListasGrupos.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.btnListasGrupos.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnListasGrupos.Location = new System.Drawing.Point(776, 61);
            this.btnListasGrupos.Margin = new System.Windows.Forms.Padding(5);
            this.btnListasGrupos.Name = "btnListasGrupos";
            this.btnListasGrupos.Size = new System.Drawing.Size(181, 41);
            this.btnListasGrupos.TabIndex = 18;
            this.btnListasGrupos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnListasGrupos.Click += new System.EventHandler(this.btnListasGrupos_Click);
            // 
            // Grupos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 645);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Grupos";
            this.Text = "Grupos";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupos)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRefrescar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar_grupo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton btnRefrescar;
        private Bunifu.Framework.UI.BunifuImageButton btnBuscar_grupo;
        private System.Windows.Forms.ComboBox CBGruposeleccinar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnModificar_grupo;
        private System.Windows.Forms.TextBox txtAula_mod;
        private System.Windows.Forms.TextBox txtGrupo_mod;
        private System.Windows.Forms.TextBox txtGrado_mod;
        private System.Windows.Forms.TextBox txtidgrupo_mod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvGrupos;
        private Bunifu.Framework.UI.BunifuThinButton2 btnListasGrupos;
    }
}