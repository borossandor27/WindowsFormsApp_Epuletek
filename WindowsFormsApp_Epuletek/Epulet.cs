using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Epuletek
{
    enum Anyagok { tégla, panel, fa };
    class Epulet
    {
        readonly string cim;
        int alapterulet;
        readonly Anyagok epitesianyag;
        DateTime kezdes;
        DateTime befejezes;

        public string Cim => cim;



        internal Anyagok Epitesianyag => epitesianyag;

        public DateTime Kezdes { get => kezdes; set => kezdes = value; }
        public DateTime Befejezes { get => befejezes; set => befejezes = value; }
        public int Alapterulet { get => alapterulet; set => alapterulet = value; }

        public Epulet(string cim, int alapterulet, Anyagok epitesianyag, DateTime kezdes, DateTime befejezes)
        {
            this.cim = cim;
            Alapterulet = alapterulet;
            this.epitesianyag = epitesianyag;
            Kezdes = kezdes;
            Befejezes = befejezes;
        }
    } //-- Epuletek vége ---------
}
