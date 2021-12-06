using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Epuletek
{
    enum TetoAnyaga { cserép, zsindely, nád };

    class Csaladihaz : Epulet, CSV
    {
        int ottElok;
        bool vanGarazs;
        TetoAnyaga tetotipus;

        public int OtkElok { get => ottElok; set => ottElok = value; }
        public bool VanGarazs { get => vanGarazs; set => vanGarazs = value; }
        internal TetoAnyaga Tetotipus { get => tetotipus; set => tetotipus = value; }

        public Csaladihaz(string cim, int alapterulet, Anyagok epitesianyag, DateTime kezdes, DateTime befejezes, int otkElok, bool vanGarazs, TetoAnyaga tetotipus) :base(cim, alapterulet, epitesianyag, kezdes, befejezes)
        {
            OtkElok = otkElok;
            VanGarazs = vanGarazs;
            Tetotipus = tetotipus;
        }
        public override string ToString()
        {
             //-- Minden esetben, amikor karaktersorozattal jelenítjük meg
            return Cim;
        }

        public string toCSV()
        {
            return String.Join(";", "csaladi", Cim, Alapterulet, Epitesianyag, Kezdes.ToString("yyyy-MM-dd"), Befejezes.ToString("yyyy-MM-dd"), ottElok, vanGarazs, tetotipus);
        }
    }
}
