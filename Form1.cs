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
        public const string newfilepath = @"C:\Users\Tamas\RiderProjects\autok\data\ujhonap.txt";
        
        public static List<Records> sorok = new List<Records>(0);
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
            var date = DateTime.Now;
            DateTime today = DateTime.Today;
            string nap = Convert.ToString(today);
            string d="";
            int f=2;
            if (hozRadioButton.Checked)
            {
                f = 1;
                d = kmTextBox.Text;
            } else if (viszRadioButton.Checked)
            {
                f = 0;
                StreamReader hehe= new StreamReader(Form1.infofilepath,Encoding.Default);
                while (!hehe.EndOfStream)
                {
                    string r = hehe.ReadLine();
                    string[] n = r.Split(' ');
                    if (rendszamTextBox.Text == n[0])
                    {
                        d = n[1];
                    }
                }
                hehe.Close();
            }
            string jegyzet =date.Day +" "+ date.Hour + ":" + date.Minute + " " +rendszamTextBox.Text+" "+idTextBox.Text+" "
                             +d+" "+f;
            StreamWriter file6= new StreamWriter(Form1.newfilepath,true,Encoding.Default);
            file6.WriteLine(jegyzet);
            file6.Close();
            testRichTextBox.Text = "Rogzitettuk ezeket az adatokat:\n"+jegyzet;
        }
        public static void lineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminForm f2= new adminForm();
            f2.ShowDialog();
        }
    }
}