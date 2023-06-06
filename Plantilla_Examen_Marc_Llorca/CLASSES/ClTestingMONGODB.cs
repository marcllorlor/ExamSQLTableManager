using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLASSES;

namespace Plantilla_Examen_Marc_Llorca.CLASSES
{
    public class ClTestingMONGODB
    {

        private ClBDMongoDB bd = null;
        public Boolean bdaccessible = false;

        public ClTestingMONGODB(String connexio, String nomBD)
        {
            bd = new ClBDMongoDB(connexio);
            if (bd.Connectar())
            {
                if (bd.ObrirBD(nomBD))
                {
                    bdaccessible = true;
                }
            }
            if (!bdaccessible)
            {
                bd = null;
            }
        }
    }
}
