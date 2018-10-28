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
            //idGrupo = grupo;
        }

        public void Cargra_parametro(int grupo) {
            idGrupo = grupo;
        }
        private void ListaGrupos_DataSourceDemanded(object sender, EventArgs e)
        {
            this.Parameters["Lista_grupo"].Value = idGrupo;
        }
    }
}
