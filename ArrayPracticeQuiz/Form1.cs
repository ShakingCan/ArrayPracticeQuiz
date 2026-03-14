using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayPracticeQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            String niggas = message.Text;
            String[] cm = new string[5];
            cm[0] = "Kennzoe";
            cm[1] = "Charlito";
            cm[2] = "Erig";
            cm[3] = "PJ";
            cm[4] = "Justine";

            foreach(String cmname in cm)
            {
                cmnamebox.Items.Add(cmname);
            }

            String[,] twodim = new String[2, 3];
            twodim[0, 0] = "1";
            twodim[0, 1] = "2";
            twodim[0, 2] = "3";
            twodim[1, 0] = "4";
            twodim[1, 1] = "5";
            twodim[1, 2] = "6";

            foreach (String twodimalp in twodim)
            {
                alphabetsbox.Items.Add(twodimalp);
            }
          
            message.Text = niggas;



        }

        private void Determinebutton_Click(object sender, EventArgs e)
        {
            if (message.Text.Contains("Hello"))
            {
                label1.Visible = true;
                label1.Text = "The message contains hello/Hello";
                MessageBox.Show("The message contains hello/Hello");
            }else if (message.Text.Contains("hello"))
            {
                MessageBox.Show("The message contains hello/Hello");
                label1.Visible = true;
                label1.Text = "The message contains hello/Hello";
            }
            else
            {
                MessageBox.Show("The message does not contain hello/Hello");
                label1.Visible = true;
                label1.Text = "The message does not contain hello/Hello";
            }
        }

        private void cmnameboxmanual_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        int i = 0;
        private void manualcmbtn_Click(object sender, EventArgs e)
        {

            String[] cm = new string[5];
            cm[0] = "Kennzoe";
            cm[1] = "Charlito";
            cm[2] = "Erig";
            cm[3] = "PJ";
            cm[4] = "Justine";

            
            i++;
            if (i == 1)
            {
                cmnameboxmanual.Items.Add(cm[0]);
            }
            else if (i == 2)
            {
                cmnameboxmanual.Items.Add(cm[1]);
            }
            else if (i == 3)
            {
                cmnameboxmanual.Items.Add(cm[2]);
            }
            else if (i == 4)
            {
                cmnameboxmanual.Items.Add(cm[3]);
            }
            else if (i == 5)
            {
                cmnameboxmanual.Items.Add(cm[4]);
            }

            }
        int i2 = 0;
        private void manualalphabtn_Click(object sender, EventArgs e)
        {
            String[,] twodim = new String[2, 3];
            twodim[0, 0] = "1";
            twodim[0, 1] = "2";
            twodim[0, 2] = "3";
            twodim[1, 0] = "4";
            twodim[1, 1] = "5";
            twodim[1, 2] = "6";

            if(i2 == 0)
            {
                alphabetsboxmanual.Items.Add(twodim[0, 0]);
            }
            else if (i2 == 1)
            {
                alphabetsboxmanual.Items.Add(twodim[0, 1]);
            }
            else if (i2 == 2)
            {
                alphabetsboxmanual.Items.Add(twodim[0, 2]);
            }
            else if (i2 == 3)
            {
                alphabetsboxmanual.Items.Add(twodim[1, 0]);
            }
            else if (i2 == 4)
            {
                alphabetsboxmanual.Items.Add(twodim[1, 1]);
            }
            else if (i2 == 5)
            {
                alphabetsboxmanual.Items.Add(twodim[1, 2]);
            }
            i2++;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            i2 = 0;
            i = 0;
            alphabetsboxmanual.Items.Clear();
            cmnameboxmanual.Items.Clear();
        }
    }
}
