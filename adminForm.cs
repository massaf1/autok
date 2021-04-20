using System;
using System.Windows.Forms;

namespace autok
{
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
        }

        private void masodikButton_Click(object sender, EventArgs e)
        {
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
            throw new System.NotImplementedException();
        }

        private void otodikButton_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void hatodikButton_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void hetedikButton_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}