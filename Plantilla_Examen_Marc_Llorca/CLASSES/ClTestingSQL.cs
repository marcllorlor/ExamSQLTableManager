using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plantilla_Examen_Marc_Llorca.CLASSES
{
    public class ClTestingSQL
    {
        private ClTestingSQLServer model = null;

        public ClTestingSQL(String cadenaConnexio, String nomBD)
        {
            model = new ClTestingSQLServer(cadenaConnexio, nomBD);
        }

        public Boolean modelAccessible()
        {
            return model.bdAccessible;
        }
    }
}
