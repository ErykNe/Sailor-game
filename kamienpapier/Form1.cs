using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace kamienpapier
{
    public partial class Form1 : Form
    {
        Image KamienKomputer;
        Image PapierKomputer;
        Image NozyceKomputer;
        Image KamienGracz;
        Image PapierGracz;
        Image NozyceGracz;
        int scorePlayer;
        int scoreComputer;
        public Form1()
        {
            KamienKomputer = Image.FromFile("C:\\Users\\Matura_1\\source\\repos\\kamienpapier\\kamienpapier\\kamien1.png");
            PapierKomputer = Image.FromFile("C:\\Users\\Matura_1\\source\\repos\\kamienpapier\\kamienpapier\\papier1.png");
            NozyceKomputer = Image.FromFile("C:\\Users\\Matura_1\\source\\repos\\kamienpapier\\kamienpapier\\nozyce1.png");
            KamienGracz = Image.FromFile("C:\\Users\\Matura_1\\source\\repos\\kamienpapier\\kamienpapier\\kamien2.png");
            PapierGracz = Image.FromFile("C:\\Users\\Matura_1\\source\\repos\\kamienpapier\\kamienpapier\\papier2.png");
            NozyceGracz = Image.FromFile("C:\\Users\\Matura_1\\source\\repos\\kamienpapier\\kamienpapier\\nozyce2.png");
            InitializeComponent();
        }


        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if(button1.Enabled == true)
            {
                if (pictureBox5.Image == KamienGracz)
                {
                    pictureBox5.Image = PapierGracz;
                }
                else if (pictureBox5.Image == PapierGracz)
                {
                    pictureBox5.Image = NozyceGracz;
                }
                else
                {
                    pictureBox5.Image = KamienGracz;
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void label6_Click(object sender, EventArgs e)
        {
            if (button1.Enabled == false)
            {
                button1.Enabled = true;
                pictureBox3.Image = null;
                pictureBox1.Image = PapierKomputer;
                pictureBox5.Image = KamienGracz;
                label7.Text = "";
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {
            if (button1.Enabled == false)
            {
                button1.Enabled = true;
                pictureBox3.Image = null;
                pictureBox1.Image = PapierKomputer;
                pictureBox5.Image = KamienGracz;
                label7.Text = "";
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(button1.Enabled == false)
            {
                button1.Enabled = true;
                pictureBox3.Image = null;
                pictureBox1.Image = PapierKomputer;
                pictureBox5.Image = KamienGracz;
                label7.Text = "";
            }
        }
      

        private void button1_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            int wybraneKomputer = rand.Next(1, 4);
            pictureBox3.Image = pictureBox5.Image;
            switch (wybraneKomputer)
            {
                case 1:
                    pictureBox1.Image = KamienKomputer;
                    break;
                case 2:
                    pictureBox1.Image = PapierKomputer;
                    break;
                case 3:
                    pictureBox1.Image = NozyceKomputer;
                    break;
            }
            int wybraneGracz;
            if (pictureBox5.Image == KamienGracz)
            {
                wybraneGracz = 1;
            }
            else if (pictureBox5.Image == PapierGracz)
            {
                wybraneGracz = 2;
            }
            else
            {
                wybraneGracz = 3;
            }
            if (wybraneKomputer == wybraneGracz)
            {
                label7.Text = "Remis";
            }
            else if (wybraneGracz == 1 && wybraneKomputer == 2)
            {
                label7.Text = "Wygrywa komputer";
                scoreComputer++;
                label2.Text = scorePlayer + " : " + scoreComputer;
            }
            else if (wybraneGracz == 1 && wybraneKomputer == 3)
            {
                label7.Text = "Wygrywa Gracz";
                scorePlayer++;
                label2.Text = scorePlayer + " : " + scoreComputer;
            }
            else if (wybraneGracz == 2 && wybraneKomputer == 1)
            {
                label7.Text = "Wygrywa Gracz";
                scorePlayer++;
                label2.Text = scorePlayer + " : " + scoreComputer;
            }
            else if (wybraneGracz == 3 && wybraneKomputer == 2)
            {
                label7.Text = "Wygrywa Gracz";
                scorePlayer++;
                label2.Text = scorePlayer + " : " + scoreComputer;

            }
            else if (wybraneGracz == 3 && wybraneKomputer == 1)
            {
                label7.Text = "Wygrywa komputer";
                scoreComputer++;
                label2.Text = scorePlayer + " : " + scoreComputer;

            }
            else if (wybraneGracz == 2 && wybraneKomputer == 3)
            {
                label7.Text = "Wygrywa komputer";
                scoreComputer++;
                label2.Text = scorePlayer + " : " + scoreComputer;
            }
            button1.Enabled = false;
        }

    }
}
