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
            string s =nap+""+ora+":"+perc+" "+rendszam+" "+munkas+" "+kilometerora+" "+kibe;
            return s;
        }
    }
}