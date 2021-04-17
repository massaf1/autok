using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autok
{
    public partial class Form1 : Form
    {
        public const string autofilepath = @"..\..\..\data\autok.txt";
        public const string infofilepath = @"..\..\..\data\info.txt";
        List<Records> sorok = new List<Records>(0);
        public Form1()
        {
            InitializeComponent();
        }
        
        private void idTextBox_Enter(object sender, EventArgs e)
        {
            idTextBox.Text = "";
        }
        private void idTextBox_Leave(object sender, EventArgs e)
        {
            idTextBox.Text = "Id:";
        }

        private void rendszamTextBox_Enter(object sender, EventArgs e)
        {
            rendszamTextBox.Text = "";
        }

        private void rendszamTextBox_Leave(object sender, EventArgs e)
        {
            rendszamTextBox.Text = "Rendszam";
        }

        private void kmTextBox_Enter(object sender, EventArgs e)
        {
            kmTextBox.Text = "";
        }

        private void kmTextBox_Leave(object sender, EventArgs e)
        {
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
            
        }
        public static void lineChanger(string newText, string fileName, int line_to_edit)
        {
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[line_to_edit - 1] = newText;
            File.WriteAllLines(fileName, arrLine);
        }
    }
}