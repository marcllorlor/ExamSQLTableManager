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
using CLASSES;
using DAM_ClCpSqlServer.CLASSES;
using Gestio_ClCicles.CLASSES;
using MongoDB.Driver;
using Plantilla_Examen_Marc_Llorca.CLASSES;
using Plantilla_Examen_Marc_Llorca.FORMS;

namespace Plantilla_Examen_Marc_Llorca
{
    public partial class FrmMain : Form
    {
        //AQqui farem la declaracio de les variables de la configuracio de la base de dades
        public string nomfitxercfgSQL = "CFGBDSQL.TXT";
        public string nomfitxercfgMONGO = "CFGBDMONGO.TXT";

        //Aquestes són les variables que tindran la configuracio de cada servidor
        //Aqui farem la part de SQL
        public string servidorbasedadesarxiuSQL = "";
        public string basedadesarxiuSQL = "";
        //Aqui farem la part de Mongo
        public string servidorbasedadesarxiuMONGO = "";
        public string basedadesarxiuMONGO = "";

        //Aqui es a on declararem les classes que fara servir el programa
        ClTestingSQL testingSQL = null;
        ClTestingMONGO testingMONGO = null;
        public ClFamilies ctrlFamilia = null; //Recorda que les classes han d'estar publiques
        public ClGraus ctrlGraus = null;
        public ClCicles ctrlCicles = null;
        public ClModuls ctrlModuls = null;
        //Aqui farem la declaracio dels forms que ens faran falta
        //Comneçarem per els Forms de BD
        FrmBDSQL fBDSQL;
        FrmBDMONGO fBDMONGO;

        FrmCicles fCicles; //Gestio de cicles
        FrmModuls fModuls;

        


        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            funcioobrirarxiuconfiguraciosql();
            funcioobrirconnexiosql();

            //funcioobrirarxiuconfiguraciomongo();
            //funcioobrirconnexiomongo();

            this.WindowState = FormWindowState.Maximized;
        }

        public void funcioobrirconnexiomongo()
        {
            testingMONGO = new ClTestingMONGO(servidorbasedadesarxiuMONGO, basedadesarxiuMONGO);
            opcionsMenuGestio(testingMONGO.modelAccessible());
            if (testingMONGO.modelAccessible())
            {
                //Aqui es a on farem la gestio per obrir totes les classes que facin falta
                //ctrlFamilia = new ClFamilies(servidorbasedadesarxiu, basedadesarxiu);

            }
        }

        private void funcioobrirarxiuconfiguraciomongo()
        {
            StreamReader fcfg;
            if (File.Exists(nomfitxercfgMONGO))
            {
                fcfg = new StreamReader(nomfitxercfgMONGO);
                servidorbasedadesarxiuMONGO = fcfg.ReadLine().Trim();
                basedadesarxiuMONGO = fcfg.ReadLine().Trim();
                fcfg.Close();
                //Aqui haurem de cridar a la classe ClTesting que aquesta cridara a ClTestingSqlServer que aquesta cridara a ClBDSqlServer
                //Aquesta part la podriem comentar de moment fins que no sapiguem quines son les classes que haguen dobrir
                //testingSQL = new ClTestingSQL(servidorbasedadesarxiuSQL, basedadesarxiuSQL);
                //Boolean xb = testingSQL.modelAccessible();
                //opcionsMenuGestio(testingSQL.modelAccessible()); 
            }
            else
            {
                //Aqui hauras indicat malament o no hauras indicat el nom de l'arxiu de la connexio a la base de dades
                //En el cas que l'arxiu de la  base de dades no existeixi, entrara a dins daquesta 
                opcionsMenuGestio(false);
            }
        }

        public void funcioobrirconnexiosql()
        {
            testingSQL = new ClTestingSQL(servidorbasedadesarxiuSQL, basedadesarxiuSQL);
            opcionsMenuGestio(testingSQL.modelAccessible());
            if (testingSQL.modelAccessible())
            {
                //Aqui es a on farem la gestio per obrir totes les classes que facin falta
                ctrlFamilia = new ClFamilies(servidorbasedadesarxiuSQL, basedadesarxiuSQL);
                ctrlCicles = new ClCicles(servidorbasedadesarxiuSQL, basedadesarxiuSQL);
                ctrlGraus = new ClGraus(servidorbasedadesarxiuSQL, basedadesarxiuSQL);
                ctrlModuls = new ClModuls(servidorbasedadesarxiuSQL, basedadesarxiuSQL);
            }
        }

        private void funcioobrirarxiuconfiguraciosql()
        {
            StreamReader fcfg;
            if (File.Exists(nomfitxercfgSQL))
            {
                fcfg = new StreamReader(nomfitxercfgSQL);
                servidorbasedadesarxiuSQL = fcfg.ReadLine().Trim();
                basedadesarxiuSQL = fcfg.ReadLine().Trim();
                fcfg.Close();
                //Aqui haurem de cridar a la classe ClTesting que aquesta cridara a ClTestingSqlServer que aquesta cridara a ClBDSqlServer
                //Aquesta part la podriem comentar de moment fins que no sapiguem quines son les classes que haguen dobrir

                //testingSQL = new ClTestingSQL(servidorbasedadesarxiuSQL, basedadesarxiuSQL);
                //Boolean xb = testingSQL.modelAccessible();
                //opcionsMenuGestio(testingSQL.modelAccessible()); 
            }
            else
            {
                //Aqui hauras indicat malament o no hauras indicat el nom de l'arxiu de la connexio a la base de dades
                //En el cas que l'arxiu de la  base de dades no existeixi, entrara a dins daquesta 
                opcionsMenuGestio(false);
            }
        }

        Boolean ja_està_obert(String xnom_frm)
        {
            //Aquesta es la funcio que farem servir per saber si una pagina ja esta oberta actualment o no
            int x1 = 0;
            Boolean xb = false;

            while ((x1 < this.MdiChildren.Length) && (!(xb)))
            {
                xb = (this.MdiChildren[x1].Name == xnom_frm);
                x1++;
            }
            return (xb); //Aqui retornara el valor TRUE si esta oberta i FALSE si la pagina no esta oberta
        }

        private void opcionsMenuGestio(bool v)
        {
            //Aqui es on farem la gestio de si s'ha dobrir una cosa o una altre
            //Recordem que potser hem de fer diferenciar entre SQL I MongoDB a l'examen
        }

        private void connexioBDSQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ja_està_obert("FrmBDSQL"))
            {
                //Recorda que sempre per obrir un nou formulari hem de tenir el mdi parent activat
                fBDSQL = new FrmBDSQL(); //En el cas que sigui importar posarem la connSQL i el tipus de dades que volem importar
                fBDSQL.MdiParent = this;           // --- hem fet que FRM_MAIN sigui MdiContainer i posem aquest Form com a fill seu ---

                fBDSQL.WindowState = FormWindowState.Normal;
                fBDSQL.Location = new System.Drawing.Point(0, 0);
                fBDSQL.Show();
            }
        }

        private void connexioBDMongoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ja_està_obert("FrmBDMONGO"))
            {
                //Recorda que sempre per obrir un nou formulari hem de tenir el mdi parent activat
                fBDMONGO = new FrmBDMONGO(); //En el cas que sigui importar posarem la connSQL i el tipus de dades que volem importar
                fBDMONGO.MdiParent = this;           // --- hem fet que FRM_MAIN sigui MdiContainer i posem aquest Form com a fill seu ---

                fBDMONGO.WindowState = FormWindowState.Normal;
                fBDMONGO.Location = new System.Drawing.Point(0, 0);
                fBDMONGO.Show();
            }
        }

        private void sortirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Segur que vols sortir?", "Finalitzar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ciclesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Aqui es a on obirem el form de la cicles
            if (!ja_està_obert("FrmCicles"))
            {
                //Recorda que sempre per obrir un nou formulari hem de tenir el mdi parent activat
                fCicles = new FrmCicles(); //En el cas que sigui importar posarem la connSQL i el tipus de dades que volem importar
                fCicles.MdiParent = this;           // --- hem fet que FRM_MAIN sigui MdiContainer i posem aquest Form com a fill seu ---
                //Aqui li hem de passar les classes
                fCicles.ctrlCicles = ctrlCicles;
                fCicles.ctrlFamilies = ctrlFamilia;
                fCicles.ctrlGraus = ctrlGraus;


                fCicles.WindowState = FormWindowState.Normal;
                fCicles.Location = new System.Drawing.Point(0, 0);
                fCicles.Show();
            }
        }

        private void modulsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((!ja_està_obert("FrmModuls"))) //aQUI HAUREM DE FER EL DE MODULS
            {
                fModuls = new FrmModuls();
                fModuls.MdiParent = this;

                fModuls.ctrlModuls = ctrlModuls;
                fModuls.ctrlCicles = ctrlCicles;
            }
            fModuls.Show();
        }
    }
}
