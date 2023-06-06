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
    public partial class FrmBDMONGO : Form
    {
        public FrmBDMONGO()
        {
            InitializeComponent();
        }

        private void FrmBDMONGO_Load(object sender, EventArgs e)
        {
            tbCadena.Text = ((FrmMain)this.MdiParent).servidorbasedadesarxiuMONGO;
            tbNomBD.Text = ((FrmMain)this.MdiParent).nomfitxercfgMONGO;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            //Primer farem el canvi de variables del mainForm
            ((FrmMain)this.MdiParent).servidorbasedadesarxiuMONGO = tbCadena.Text;
            ((FrmMain)this.MdiParent).basedadesarxiuMONGO = tbNomBD.Text;

            ((FrmMain)this.MdiParent).funcioobrirconnexiomongo(); //Com que aqui petara, l'arxiu no s'esciura
            StreamWriter fcfg;
            fcfg = new StreamWriter(((FrmMain)this.MdiParent).nomfitxercfgMONGO);
            fcfg.WriteLine(tbCadena.Text);
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
