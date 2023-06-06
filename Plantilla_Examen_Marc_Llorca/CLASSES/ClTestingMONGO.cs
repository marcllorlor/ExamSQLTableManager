using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plantilla_Examen_Marc_Llorca.CLASSES
{
    public class ClTestingMONGO
    {
        private ClTestingMONGODB model = null;
        public ClTestingMONGO(String cadenaConnexio, String nomBD)
        {
            this.model = new ClTestingMONGODB(cadenaConnexio, nomBD);
            if (!model.bdaccessible)
            {
                model = null;
            }
        }

        public Boolean modelAccessible()
        {
            return (model != null);
        }
    }
}
