using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLASSES;

namespace DAM_ClCpSqlServer.CLASSES
{
    public class ClCiclesSqlServer
    {
        private ClBDSqlServer bd = null;

        public Boolean bdAccessible = false;
        public String idCicle { get; set; }
        public String nomCicle { get; set; }
        public String idFamilia { get; set; }
        public String nHores { get; set; }
        public String idGrau { get; set; }

        public ClCiclesSqlServer(String cadenaConnexio, String nomBD)
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

        // destructor
        ~ClCiclesSqlServer()
        {

        }

        public Boolean nouCicle()
        {
            Boolean xb = bd.InserirDades("INSERT INTO tbCicles(idCicle,nomCicle,idFamilia,nHores,idGrau) VALUES ('" + idCicle + "','" + nomCicle + "','" + idFamilia + "'," + nHores +",'" + idGrau + "')");
            return xb;
        }

        public Boolean modificarCicle()
        {
            Boolean xb = bd.ModificarDades("UPDATE tbCicles SET nomCicle='" + nomCicle + "', idFamilia='" + idFamilia + "', nHores=" + nHores + ", idGrau='" + idGrau +"' WHERE idCicle='" + idCicle + "'");
            return xb;
        }

        public Boolean suprimirCicle()
        {
            Boolean xb = bd.SuprimirDades("DELETE FROM tbCicles WHERE (idCicle='" + idCicle + "')");
            return xb;
        }

        public Boolean getCicle()
        {
            Boolean xb = false;

            //Aqui farem la funcio que ens retornara el nom de la familia a partir de la id de la familia
            DataSet dset = new DataSet();

            //Aqui farem la string de sql que ens servira per saber si existeix la familia o no
            String xsql = "SELECT idCicle, nomCicle, idFamilia, nHores, idGrau FROM tbCicles WHERE idCicle LIKE '" + idCicle + "';";

            bd.Consulta(xsql, ref dset);

            try
            {
                if(dset.Tables[0].Rows.Count != 0)
                {
                    idCicle = dset.Tables[0].Rows[0].ItemArray[0].ToString();
                    nomCicle = dset.Tables[0].Rows[0].ItemArray[1].ToString();
                    idFamilia = dset.Tables[0].Rows[0].ItemArray[2].ToString();
                    nHores = dset.Tables[0].Rows[0].ItemArray[3].ToString();
                    idGrau = dset.Tables[0].Rows[0].ItemArray[4].ToString();
                    
                    xb = true;
                }
                
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "EXCEPCIÓ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return xb;
        }

        public Boolean existeixCicle()
        {
            Boolean xb = false;

            //Aqui farem la funcio que ens retornara el nom de la familia a partir de la id de la familia
            DataSet dset = new DataSet();

            //Aqui farem la string de sql que ens servira per saber si existeix la familia o no
            String xsql = "SELECT count(*) FROM tbCicles WHERE idCicle = '" + idCicle + "';";

            bd.Consulta(xsql, ref dset);

            try
            {
                if ((Int32)dset.Tables[0].Rows[0].ItemArray[0] != 0)
                {
                    //idCicle = dset.Tables[0].Rows[0].ItemArray[0].ToString();
                    //nomCicle = dset.Tables[0].Rows[0].ItemArray[1].ToString();
                    //idFamilia = dset.Tables[0].Rows[0].ItemArray[2].ToString();
                    xb = true;
                }

            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "EXCEPCIÓ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return xb;
        }

        public void llistaCicles(ref DataSet dset, int ordre)
        {
            String xsql = "";
            switch (ordre)
            {
                case 0: xsql = "SELECT tbCicles.idCicle,tbCicles.nomCicle,tbFamilies.nomFamilia,tbFamilies.idFamilia, tbCicles.nHores, tbCicles.idGrau, tbGraus.descrGrau FROM tbCicles LEFT JOIN tbFamilies ON tbCicles.idFamilia = tbFamilies.idFamilia LEFT JOIN tbGraus ON tbCicles.idGrau = tbGraus.idGrau ORDER BY tbCicles.idCicle;"; break;
                case 1: xsql = "SELECT tbCicles.idCicle,tbCicles.nomCicle,tbFamilies.nomFamilia,tbFamilies.idFamilia, tbCicles.nHores, tbCicles.idGrau, tbGraus.descrGrau FROM tbCicles LEFT JOIN tbFamilies ON tbCicles.idFamilia = tbFamilies.idFamilia LEFT JOIN tbGraus ON tbCicles.idGrau = tbGraus.idGrau ORDER BY tbCicles.nomCicle;"; break;
                case 2: xsql = "SELECT tbCicles.idCicle,tbCicles.nomCicle,tbFamilies.nomFamilia,tbFamilies.idFamilia, tbCicles.nHores, tbCicles.idGrau, tbGraus.descrGrau FROM tbCicles LEFT JOIN tbFamilies ON tbCicles.idFamilia = tbFamilies.idFamilia LEFT JOIN tbGraus ON tbCicles.idGrau = tbGraus.idGrau WHERE tbFamilies.idFamilia = '" + idFamilia +"'ORDER BY tbCicles.nomCicle;"; break;
            }
            bd.Consulta(xsql, ref dset);
        }

        public int quantsCiclexPrefix(String nomCicle)
        {
            return (Int32)bd.ConsultaEscalar("SELECT COUNT(*) FROM tbCicles WHERE nomCicle = '" + nomCicle + "'");
        }

        public int quantsCicles()
        {
            return (Int32)bd.ConsultaEscalar("SELECT COUNT(*) FROM tbCicles;");
        }

        internal List<String> retornaridsFamilies()
        {
            //String[] idsFamilies = [];

            List<String> idsFamilies = new List<String>();

            //Aqui farem la funcio que ens retornara el nom de la familia a partir de la id de la familia
            DataSet dset = new DataSet();

            //Aqui farem la string de sql que ens servira per saber si existeix la familia o no
            String xsql = "SELECT idFamilia FROM tbFamilies;";

            bd.Consulta(xsql, ref dset);
            
            try
            {
                foreach(DataRow item in dset.Tables[0].Rows)
                {
                    idsFamilies.Add(item.ItemArray[0].ToString());
                }
                
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "EXCEPCIÓ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return idsFamilies;
        }
    }
}
