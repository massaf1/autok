namespace autok
{
    public class Records
    {
        public int nap;
        public int ora;
        public int perc;
        public string rendszam;
        public int munkas;
        public int kilometerora;
        public int kibe;

        public Records(int n,int o,int p,string r,int m,int k, int kb)
        {
            nap = n;
            ora = o;
            perc = p;
            rendszam = r;
            munkas = m;
            kilometerora = k;
            kibe = kb;
        }

        public string Kiir()
        {
            string s;
            if (ora < 10)
            {
                if (perc < 10)
                {
                    s =nap+" 0"+ora+":0"+perc+" "+rendszam+" "+munkas+" "+kilometerora+" "+kibe;
                }
                else
                {
                    s =nap+" 0"+ora+":"+perc+" "+rendszam+" "+munkas+" "+kilometerora+" "+kibe;
                }
            }
            else
            {
                if (perc < 10)
                {
                    s =nap+" "+ora+":0"+perc+" "+rendszam+" "+munkas+" "+kilometerora+" "+kibe;
                }
                else
                {
                    s =nap+" "+ora+":"+perc+" "+rendszam+" "+munkas+" "+kilometerora+" "+kibe;
                }
            }
            return s;
        }
    }
}