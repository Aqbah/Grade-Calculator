using MultiWindowApp;

namespace GradeWithSplash
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;

            if (panel2.Width >= 799)
            {
                timer1.Stop();
                Form1 f2 = new Form1();
                this.Hide();
                f2.Show();
            }
        }
    }
}