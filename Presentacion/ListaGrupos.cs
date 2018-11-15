using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Presentacion
{
    public partial class ListaGrupos : DevExpress.XtraReports.UI.XtraReport
    {
        int idGrupo;
        public ListaGrupos()
        {
            InitializeComponent();
            Cargar_parametro();
        }

        public void Cargar_parametro() {
            idGrupo = Convert.ToInt32(this.Parameters["Grupos"].Value);
        }
        private void ListaGrupos_DataSourceDemanded(object sender, EventArgs e)
        {
            this.Parameters["Grupos"].Value = idGrupo;
        }
    }
}
