using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BejegyzesProjekt
{
    class Bejegyzes
    {
        string szerzo;
        string tartalom;
        int likok;
        DateTime letrejott;
        DateTime szerkesztve;

        public Bejegyzes(string szerzo,string tartalom)
        {
            this.szerzo = szerzo;
            this.tartalom = tartalom;
            this.likok = 0;
            this.letrejott =DateTime.Now;
            this.szerkesztve = DateTime.Now;
        }
        public string Szerzo
        {
            get
            {
                return szerzo;
            }
        }
        public string Tartalom
        {
            get
            {
                return tartalom;
            }
            set
            {
                szerkesztve = DateTime.Now;
                tartalom = value;
            }
        }
        public int Likok
        {
            get
            {
                return likok;
            }
        }
        public DateTime Letrejott
        {
            get
            {
                return letrejott;
            }
        }
        public DateTime Szerkeztve
        {
            get
            {
                return szerkesztve;
            }
        }
        public void Like()
        {
            likok++;
        }
        public string Kiir()
        {
            string s = szerzo + "-" + likok + "-" + "\n Szerkeztve: " + szerkesztve + "\n" + tartalom;
            return s;
        }
    

    }
   

}
