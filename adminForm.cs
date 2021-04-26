using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Windows.Forms;

namespace autok
{
    public partial class adminForm : Form
    {
        private List<Records> rekordok= Form1.sorok;
        public adminForm()
        {
            InitializeComponent();
        }

        private void masodikButton_Click(object sender, EventArgs e)
        {
            outputRichTextBox.Text = "";
            int szamolokint = 0;
            for (var i = Form1.sorok.Count - 1; i >= 0; i--)
            {
                if (Form1.sorok[i].kibe == 0)
                {
                    szamolokint = i;
                    break;
                }
            }
            outputRichTextBox.Text = Form1.sorok[szamolokint].Kiir();
        }

        private void harmadikButton_Click(object sender, EventArgs e)
        {
            outputRichTextBox.Text = "";
            string s,a;
            int temp = 0;
            foreach (var sor in Form1.sorok)
            {
                if (sor.nap == Convert.ToInt32(inputTextbox.Text))
                {
                    s = sor.Kiir();
                    temp = s.Length;
                    a = s.Substring(0, temp - 1);
                    if (sor.kibe == 0)
                    {
                        a += "ki";
                    }
                    else
                    {
                        a += "be";
                    }

                    a += "\n";
                    outputRichTextBox.Text+=a;
                }
            }
        }

        private void negyedikButton_Click(object sender, EventArgs e)
        {
            outputRichTextBox.Text = "";
            StreamReader file= new StreamReader(Form1.infofilepath,Encoding.Default);
            string s;
            int i=0;
            while (!file.EndOfStream)
            {
                s = file.ReadLine();
                string[] a = s.Split(' ');
                if (Convert.ToInt32(a[2])==0)
                {
                    i++;
                    a[0] += "\n";
                    outputRichTextBox.Text += a[0];
                }
            }
            file.Close();
            outputRichTextBox.Text +=i+" auto nem volt bent a parkoloban";
        }

        private void otodikButton_Click(object sender, EventArgs e)
        {
            outputRichTextBox.Text = "";
            string a = "CEG";
            int b = 300;
            string c = a+b;
            int[] f= new int[10];
            for (int i = 0; i < 10; i++)
            {
                foreach (var sor in Form1.sorok)
                {
                    if (sor.rendszam == c)
                    {
                        f[i] = sor.kilometerora;
                        b++;
                        c = a + b;
                        break;
                    }
                }
            }

            int k=0,temp=0;
            StreamReader file= new StreamReader(Form1.infofilepath,Encoding.Default);
            while (!file.EndOfStream)
            {
                c = file.ReadLine();
                string[] d=c.Split(' ');
                temp = Convert.ToInt32(d[1]) -f[k];
                outputRichTextBox.Text +=d[0]+" "+temp+"km\n";
                k++;
            }
            file.Close();
        }

        private void hatodikButton_Click(object sender, EventArgs e)
        {
                /*
            outputRichTextBox.Text = "";
            int auto = 0;
            int d = 0;
            int[] osszmax= new int[10];
            int szam =300;
            string ceg = "CEG";
            string s = ceg+szam;
            int[] megoldas= new int[10];
            int[] odavissza= new []{0,0};
            bool end = false;
            Records elvitt = null;
            while (!end)
            {
                for(int i=odavissza[1];i<Form1.sorok.Count;i++)
                {
                    if (Form1.sorok[i].rendszam == s && Form1.sorok[i].kibe==1)
                    {
                        elvitt.kibe = Form1.sorok[i].kibe;
                        elvitt.kilometerora = Form1.sorok[i].kilometerora;
                        elvitt.munkas = Form1.sorok[i].munkas;
                        elvitt.nap = Form1.sorok[i].nap;
                        elvitt.ora = Form1.sorok[i].ora;
                        elvitt.perc = Form1.sorok[i].perc;
                        elvitt.rendszam = Form1.sorok[i].rendszam;
                        odavissza[0] = i;
                        break;
                    }
                }
                for (int i = odavissza[0]; i<Form1.sorok.Count;i++)
                {
                    if (Form1.sorok[i].rendszam == elvitt.rendszam && Form1.sorok[i].munkas==elvitt.munkas && Form1.sorok[i].kibe!=elvitt.kibe)
                    {
                        d = Form1.sorok[i].kilometerora - elvitt.kilometerora;
                        if (d > osszmax[auto])
                        {
                            osszmax[auto] = d;
                            megoldas[auto] = i;
                        }
                        odavissza[1] = i;
                        break;
                    }
                }

                if (odavissza[1] >= Form1.sorok.Count || odavissza[0] >= Form1.sorok.Count)
                {
                    if (szam > 309)
                    {
                        end = true;
                        break;
                    }
                    else
                    {
                        odavissza[0] = 0;
                        odavissza[1] = 0;
                        auto++;
                        szam++;
                        s = ceg + szam;
                    }
                }
            }
            */
                
                outputRichTextBox.Text = "";
                List<Records> rszrendezett = rekordok.OrderBy(o => o.rendszam).ToList();
                int kmmax = 0;
                int szemely = 0;
                for (int i = 1; i < rszrendezett.Count; i++)
                {
                    if (rszrendezett[i].rendszam == rszrendezett[i-1].rendszam && rszrendezett[i].kibe == 1)
                    {
                        if (kmmax < rszrendezett[i].kilometerora - rszrendezett[i - 1].kilometerora)
                        {
                            kmmax = rszrendezett[i].kilometerora - rszrendezett[i - 1].kilometerora;
                            szemely = rszrendezett[i].munkas; 
                        }
                    }
                }
                outputRichTextBox.Text = "Leghosszabb út: " + kmmax.ToString() + " km, személy: " + szemely.ToString();
        }

        private void hetedikButton_Click(object sender, EventArgs e)
        {
            outputRichTextBox.Text = "";
            string cim = inputTextbox.Text;
            string s = inputTextbox.Text+"_menetlevel.txt";
            string hely = @"C:\Users\Tamas\RiderProjects\autok\data\"+s;
            StreamWriter file= new StreamWriter(@hely,true,Encoding.Default);
            foreach (var sor in Form1.sorok)
            {
                if (sor.rendszam == cim)
                {
                    file.WriteLine(sor.Kiir());
                    outputRichTextBox.Text += sor.Kiir()+"\n";
                }
            }
            file.Close();
        }
    }
}