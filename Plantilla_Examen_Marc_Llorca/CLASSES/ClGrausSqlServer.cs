using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLASSES;

namespace Plantilla_Examen_Marc_Llorca.CLASSES
{
    public class ClGrausSqlServer
    {
        private ClBDSqlServer bd = null;

        public Boolean bdAccessible = false;
        public String idGrau { get; set; }
        public String nomGrau { get; set; }

        public ClGrausSqlServer(String cadenaConnexio, String nomBD)
        {
            bd = new ClBDSqlServer(cadenaConnexio);
            if (bd.Connectar() && bd.ObrirBD(nomBD))
            {
                bdAccessible = true;
            }
            else
            {
                bd = null;
            }
        }

        ~ClGrausSqlServer()
        {

        }

        public Boolean getGrau()
        {
            Boolean xb = false;

            //Aqui farem la funcio que ens retornara el nom de la familia a partir de la id de la familia
            DataSet dset = new DataSet();

            //Aqui farem la string de sql que ens servira per saber si existeix la familia o no
            String xsql = "SELECT idGrau, descrGrau FROM tbGraus WHERE idGrau = '" + idGrau + "';";

            bd.Consulta(xsql, ref dset);

            try
            {
                if (dset.Tables[0].Rows.Count != 0)
                {
                    idGrau = dset.Tables[0].Rows[0].ItemArray[0].ToString();
                    nomGrau = dset.Tables[0].Rows[0].ItemArray[1].ToString();
                    xb = true;
                }

            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "EXCEPCIÓ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return xb;
        }

        public void llistaGraus(ref DataSet dset, int ordre)
        {
            String xsql = "";
            switch (ordre)
            {
                case 0: xsql = "SELECT * FROM tbGraus ORDER BY idGrau"; break;
                case 1: xsql = "SELECT * FROM tbGraus ORDER BY descrGrau"; break;
            }
            bd.Consulta(xsql, ref dset);
        }

        public Boolean existeixGrau()
        {
            Boolean xb = false;

            //Aqui farem la funcio que ens retornara el nom de la familia a partir de la id de la familia
            DataSet dset = new DataSet();

            //Aqui farem la string de sql que ens servira per saber si existeix la familia o no
            String xsql = "SELECT count(*) FROM tbGraus WHERE idGrau = '" + idGrau + "';";

            bd.Consulta(xsql, ref dset);

            try
            {
                if (dset.Tables[0].Rows[0].ItemArray.Count() > 1)
                {
                    idGrau = dset.Tables[0].Rows[0].ItemArray[0].ToString();
                    nomGrau = dset.Tables[0].Rows[0].ItemArray[1].ToString();
                    xb = true;
                }

            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "EXCEPCIÓ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return xb;
        }




    }
}
