using System.Drawing.Imaging;
using System.Media;
namespace WFAnimali
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CCane dog = new CCane(0, 0, "");
            SoundPlayer cane = new SoundPlayer("canesuono.wav");
            cane.Play();
            MessageBox.Show(dog.Verso());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CUccello crow = new CUccello(0, 0, "i");
            SoundPlayer corvo = new SoundPlayer("corvosuono.wav");
            corvo.Play();
            MessageBox.Show(crow.Verso());
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            CGatto cat = new CGatto(8, 67, "n");
            SoundPlayer gatto = new SoundPlayer("gattosuono.wav");
            gatto.Play();
            MessageBox.Show(cat.Verso());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SoundPlayer monkey = new SoundPlayer("scimmiasuono.wav");
            monkey.Play();
            CScimmia scimmia = new CScimmia(0, 0, "");
            MessageBox.Show(scimmia.Verso());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            SoundPlayer leone = new SoundPlayer("suonoleone.wav");
            leone.Play();
            CLeone lion = new CLeone(0, 0, "");
            MessageBox.Show(lion.Verso());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            SoundPlayer pappagallo = new SoundPlayer("parrotsuono.wav");
            pappagallo.Play();
            CParrot parrot = new CParrot(0, 0, "");
            MessageBox.Show(parrot.Verso());
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            SoundPlayer canguro = new SoundPlayer("cangurosuono.wav");
            canguro.Play();
            CCanguro kangaroo = new CCanguro(0, 0, "");
            MessageBox.Show(kangaroo.Verso());
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            SoundPlayer panda = new SoundPlayer("pandasuono.wav");
            panda.Play();
            CPanda pandi = new CPanda(0, 0, "");
            MessageBox.Show(pandi.Verso());
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            SoundPlayer maiale = new SoundPlayer("maialesuono.wav");
            maiale.Play();
            CMaiale pig = new CMaiale(0, 0, "");
            MessageBox.Show(pig.Verso());
        }
    }
}
