using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLASSES;

namespace Plantilla_Examen_Marc_Llorca.CLASSES
{
    public class ClGraus
    {

        private ClGrausSqlServer model = null;

        public String idGrau { get; set; }
        public String nomGrau { get; set; }

        public ClGraus(String cadenaConnexio, String nomBD)
        {
            model = new ClGrausSqlServer(cadenaConnexio, nomBD);
        }

        public Boolean modelAccessible()
        {
            return model != null;
        }

        public Boolean getGrau()
        {
            Boolean xb = false;
            model.idGrau = idGrau;
            if (model.getGrau())
            {
                idGrau = model.idGrau;
                nomGrau = model.nomGrau;
                xb = true;
            }
            return xb;
        }

        public Boolean existeixGrau()
        {
            model.idGrau = idGrau;
            return model.existeixGrau();
        }

        public void llistaGraus(ref DataSet dset)
        {
            model.llistaGraus(ref dset, 0);
        }

        public void llistaXnomGraus(ref DataSet dset)
        {
            model.llistaGraus(ref dset, 1);
        }
    }
}
