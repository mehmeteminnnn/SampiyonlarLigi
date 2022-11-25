using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamponsLeague
{
    internal class Takim
    {
        private string takimismi;
        private string takimulke;
        public Takim(string isim, string ulke)
        {
            takimismi = isim;
            takimulke = ulke;
        }
        public string Teamname
        {
            get { return takimismi; }
            set { takimismi = value; }
        }
        public string Teamcountry
        {
            get { return takimulke; }
            set { takimulke = value; }
        }
public override string ToString()
        {
            return takimismi + "-" + takimulke;
        }
    }
    
    
}


