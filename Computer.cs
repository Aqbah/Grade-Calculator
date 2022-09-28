using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiWindowApp
{
    public partial class Computer : Form
    {
        public Computer()
        {
            InitializeComponent();
        }

        private void BtnPerc_Click(object sender, EventArgs e)
        {
            int English = Convert.ToInt32(TbEnglish.Text);
            int Urdu = Convert.ToInt32(TbUrdu.Text);
            int Mathematics = Convert.ToInt32(TbMath.Text);
            int PakStudies = Convert.ToInt32(TbPak.Text);
            int Islamiat = Convert.ToInt32(TbIsl.Text);
            int Computer = Convert.ToInt32(TbCS.Text);
            int Physics = Convert.ToInt32(TbPhy.Text);
            int Chemistry = Convert.ToInt32(TbChem.Text);
            string title = "Percentage";

            int subjectTotal = 100;
            int subjectNo = 8;

            double obtPerc = ((English + Urdu + Mathematics + PakStudies + Islamiat + Computer + Physics + Chemistry) * 100) / (subjectTotal * subjectNo);
            Percentage.Text = obtPerc.ToString() + "%";
            string message = "You got " + obtPerc.ToString() + "%" + " marks in your class!";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TbEnglish.Text = "";
            TbUrdu.Text = "";
            TbMath.Text = "";
            TbPak.Text = "";
            TbIsl.Text = "";
            TbCS.Text = "";
            TbPhy.Text = "";
            TbChem.Text = "";
            Percentage.Text = "";
            Grade.Text = "";
        }

        private void BtnGrade_Click(object sender, EventArgs e)
        {
            int English = Convert.ToInt32(TbEnglish.Text);
            int Urdu = Convert.ToInt32(TbUrdu.Text);
            int Mathematics = Convert.ToInt32(TbMath.Text);
            int PakStudies = Convert.ToInt32(TbPak.Text);
            int Islamiat = Convert.ToInt32(TbIsl.Text);
            int Computer = Convert.ToInt32(TbCS.Text);
            int Physics = Convert.ToInt32(TbPhy.Text);
            int Chemistry = Convert.ToInt32(TbChem.Text);
            string title = "Grade";

            int subjectTotal = 100;
            int subjectNo = 8;

            double obtPerc = ((English + Urdu + Mathematics + PakStudies + Islamiat + Computer + Physics + Chemistry) * 100) / (subjectTotal * subjectNo);
            if (obtPerc >= 90 && obtPerc <= 100)
            {
                Grade.Text = "A*";
            }
            else if (obtPerc >= 80 && obtPerc <= 89)
            {
                Grade.Text = "A";
            }
            else if (obtPerc >= 70 && obtPerc <= 79)
            {
                Grade.Text = "B";
            }
            else if (obtPerc >= 60 && obtPerc <= 69)
            {
                Grade.Text = "C";
            }
            else if (obtPerc >= 50 && obtPerc <= 59)
            {
                Grade.Text = "D";
            }
            else if (obtPerc >= 40 && obtPerc <= 49)
            {
                Grade.Text = "E";
            }
            else
            {
                Grade.Text = "U";
            }
            string message = "You got " + Grade.Text + " Grade in your class!";
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void businessSubjectGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }

        private void computerSubjectGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Computer newForm = new Computer();
            this.Hide();
            newForm.ShowDialog();
            this.Close();
        }

        private void biologySubjectGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bio newform = new Bio();
            this.Hide();
            newform.ShowDialog();
            this.Close();
        }
    }

}
