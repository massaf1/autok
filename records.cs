namespace autok
{
    public class Records
    {
        private int nap;
        private int ora;
        private int perc;
        private string rendszam;
        private int munkas;
        private int kilometerora;
        private int kibe;

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
    }
}