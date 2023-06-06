using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plantilla_Examen_Marc_Llorca.FORMS
{
    public partial class FrmBDSQL : Form
    {
        public FrmBDSQL()
        {
            InitializeComponent();
        }

        private void FrmBDSQL_Load(object sender, EventArgs e)
        {
            tbCadenaConnexio.Text = ((FrmMain)this.MdiParent).servidorbasedadesarxiuSQL;
            tbNomBD.Text = ((FrmMain)this.MdiParent).basedadesarxiuSQL;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            //Primer farem el canvi de variables del mainForm

            ((FrmMain)this.MdiParent).servidorbasedadesarxiuSQL = tbCadenaConnexio.Text;
            ((FrmMain)this.MdiParent).basedadesarxiuSQL = tbNomBD.Text;

            ((FrmMain)this.MdiParent).funcioobrirconnexiosql(); //Com que aqui petara, l'arxiu no s'esciura
            StreamWriter fcfg;
            fcfg = new StreamWriter(((FrmMain)this.MdiParent).nomfitxercfgSQL);
            fcfg.WriteLine(tbCadenaConnexio.Text);
            fcfg.WriteLine(tbNomBD.Text);
            fcfg.Close();


            //Despres farem l'execució del metode per canviar la base de dades

            this.Close();
        }

        private void btNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
