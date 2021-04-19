using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autok
{
    public partial class Form1 : Form
    {
        /*public const string autofilepath = @"..\..\data\autok.txt";
        public const string infofilepath = @"..\..\data\info.txt";
        */
        public const string autofilepath = @"C:\Users\Tamas\RiderProjects\autok\data\autok.txt";
        public const string infofilepath = @"C:\Users\Tamas\RiderProjects\autok\data\info.txt";
        List<Records> sorok = new List<Records>(0);
        public Form1()
        { 
            StreamReader file = new StreamReader(Form1.autofilepath, Encoding.Default);
            string sor;
            while (!file.EndOfStream)
            {
                sor = file.ReadLine();
                //adminButton.Text = sor;
                string[] osztott = sor.Split(' ');
                string[] oszt = osztott[1].Split(':');
                sorok.Add(new Records(Convert.ToInt32(osztott[0]),Convert.ToInt32(oszt[0]),
                    Convert.ToInt32(oszt[1]),osztott[2],Convert.ToInt32(osztott[3]),Convert.ToInt32(osztott[4]),
                    Convert.ToInt32(osztott[5])));
            }
            file.Close();
            InitializeComponent();
        }
        
        private void idTextBox_Enter(object sender, EventArgs e)
        {
            idTextBox.Text = "";
        }
        private void idTextBox_Leave(object sender, EventArgs e)
        {
            if(idTextBox.Text=="")
                idTextBox.Text = "Id:";
        }

        private void rendszamTextBox_Enter(object sender, EventArgs e)
        {
            rendszamTextBox.Text = "";
        }

        private void rendszamTextBox_Leave(object sender, EventArgs e)
        {
            if(rendszamTextBox.Text=="")
            rendszamTextBox.Text = "Rendszam:";
        }

        private void kmTextBox_Enter(object sender, EventArgs e)
        {
            kmTextBox.Text = "";
        }

        private void kmTextBox_Leave(object sender, EventArgs e)
        {
            if(kmTextBox.Text=="")
            kmTextBox.Text = "Mennyi a kilometerora?";
        }

        private void hozRadioButton_Click(object sender, EventArgs e)
        {
            bool isChecked = hozRadioButton.Checked;
            if (isChecked)
            {
                kmTextBox.Visible = true;
            }
        }

        private void viszRadioButton_Click(object sender, EventArgs e)
        {
            bool isChecked =viszRadioButton.Checked;
            if (isChecked)
            {
                kmTextBox.Visible = false;
            }
        }

        private void rogzitButton_Click(object sender, EventArgs e)
        {
            
            StreamReader file= new StreamReader(Form1.autofilepath,Encoding.Default);
            int hossz=0;
            while (!file.EndOfStream)
            {
                file.ReadLine();
                hossz++;
            }
            file.Close();
            if (hossz >= 500)
            {
                testRichTextBox.Text = "Sajnalom ebben a honapban nem szabad tobb autot elvinni";
            }
            else
            {
                DateTime today = DateTime.Today;
                string h=DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                string[] he = h.Split(' ');
                string[] heh = he[1].Split(':');
                StreamReader file1= new StreamReader(infofilepath,Encoding.Default);
                string s;
                int t = 2;
                while (!file1.EndOfStream)
                {
                    s = file1.ReadLine();
                    string[] bont = s.Split(' ');
                    if (bont[0] == rendszamTextBox.Text)
                    {
                        if (hozRadioButton.Checked)
                        {
                            t = 0;
                        } else if (viszRadioButton.Checked)
                        {
                            t = 1;
                        }

                        if (Convert.ToInt32(bont[2]) == t)
                        {
                            if (sorok[hossz - 1].nap >= Convert.ToInt32(today))
                            {
                                if (sorok[hossz - 1].ora >= Convert.ToInt32(heh[0]))
                                {
                                    if (sorok[hossz - 1].perc >= Convert.ToInt32(heh[1]))
                                    {
                                        file1.Close();
                                        switch (t)
                                        {
                                            case 1:
                                                t = 0;
                                                break;
                                            case 0:
                                                t = 1;
                                                break;
                                        }
                                            sorok.Add(new Records(Convert.ToInt32(today),Convert.ToInt32(heh[0]),Convert.ToInt32(heh[1])
                                            ,rendszamTextBox.Text,Convert.ToInt32(idTextBox.Text),Convert.ToInt32(bont[1]),t));
                                        StreamWriter fileauto= new StreamWriter(Form1.autofilepath,true,Encoding.Default);
                                        string asd = sorok[hossz].Kiir();
                                        fileauto.WriteLine(asd);
                                    }
                                }
                            }
                        }
                    }
                }
                file1.Close();
            }
        }
        public static void lineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }
    }
}