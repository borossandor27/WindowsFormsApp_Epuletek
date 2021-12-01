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

        public int Alapterulet { 
            get => alapterulet;
            set {
                if (value >= 20)
                {
                    alapterulet = value;
                }
                else
                {
                    throw new Exception();
                }
            }  
        }

        internal Anyagok Epitesianyag => epitesianyag;

        public DateTime Kezdes
        {
            get => kezdes;
            set
            {
                if (value >= DateTime.Today)
                {
                    kezdes = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }
        public DateTime Befejezes
        {
            get => befejezes;
            set
            {
                if (value >= kezdes)
                {
                    befejezes = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }

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
