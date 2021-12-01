using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_Epuletek
{
    class Tombhaz : Epulet
    {
        readonly int lakasokSzama;
        Fenntartas fenntartasTipusa;
        readonly bool vanLift;

        public int LakasokSzama => lakasokSzama;

        internal Fenntartas FenntartasTipusa { get => fenntartasTipusa; set => fenntartasTipusa = value; }

        public bool VanLift => vanLift;

        public Tombhaz(string cim, int alapterulet, Anyagok epitesianyag, DateTime kezdes, DateTime befejezes, int lakasokSzama, Fenntartas fenntartasTipusa, bool vanLift) : base(cim, alapterulet, epitesianyag, kezdes, befejezes)
        {
            this.lakasokSzama = lakasokSzama;
            FenntartasTipusa = fenntartasTipusa;
            this.vanLift = vanLift;
        }
    }
}
