using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLASSES;

namespace Plantilla_Examen_Marc_Llorca.CLASSES
{
    public class ClTestingSQLServer
    {
        private ClBDSqlServer bd = null;

        public Boolean bdAccessible = false;

        public ClTestingSQLServer(String cadenaConnexio, string nomBD)
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
    }
}
