namespace Presentacion
{
    partial class Captura_Calificaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Captura_Calificaciones));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnSeleccionar = new Bunifu.Framework.UI.BunifuImageButton();
            this.cbGrupoCaptura = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCalificaciones = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificaciones)).BeginInit();
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
            this.bunifuGradientPanel1.Controls.Add(this.comboBox1);
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.btnSeleccionar);
            this.bunifuGradientPanel1.Controls.Add(this.cbGrupoCaptura);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.dgvCalificaciones);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(2, 12);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1007, 711);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.White;
            this.btnSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.Image")));
            this.btnSeleccionar.ImageActive = null;
            this.btnSeleccionar.Location = new System.Drawing.Point(803, 71);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(36, 32);
            this.btnSeleccionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSeleccionar.TabIndex = 3;
            this.btnSeleccionar.TabStop = false;
            this.btnSeleccionar.Zoom = 10;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // cbGrupoCaptura
            // 
            this.cbGrupoCaptura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbGrupoCaptura.FormattingEnabled = true;
            this.cbGrupoCaptura.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbGrupoCaptura.Location = new System.Drawing.Point(234, 71);
            this.cbGrupoCaptura.Name = "cbGrupoCaptura";
            this.cbGrupoCaptura.Size = new System.Drawing.Size(179, 24);
            this.cbGrupoCaptura.TabIndex = 2;
            this.cbGrupoCaptura.Text = "Seleccione una opcion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(16, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grupo para Capturar Calificanes";
            // 
            // dgvCalificaciones
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvCalificaciones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCalificaciones.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvCalificaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCalificaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCalificaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalificaciones.DoubleBuffered = true;
            this.dgvCalificaciones.EnableHeadersVisualStyles = false;
            this.dgvCalificaciones.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvCalificaciones.HeaderForeColor = System.Drawing.Color.White;
            this.dgvCalificaciones.Location = new System.Drawing.Point(10, 169);
            this.dgvCalificaciones.Name = "dgvCalificaciones";
            this.dgvCalificaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCalificaciones.Size = new System.Drawing.Size(980, 378);
            this.dgvCalificaciones.TabIndex = 0;
            this.dgvCalificaciones.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCalificaciones_CellMouseDoubleClick);
            this.dgvCalificaciones.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvCalificaciones_RowsAdded);
            this.dgvCalificaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvCalificaciones_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox1.Location = new System.Drawing.Point(601, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 24);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Seleccione una opcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(428, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Periodo de Calificaciones";
            // 
            // Captura_Calificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1014, 735);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Captura_Calificaciones";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSeleccionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalificaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvCalificaciones;
        private Bunifu.Framework.UI.BunifuImageButton btnSeleccionar;
        private System.Windows.Forms.ComboBox cbGrupoCaptura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}