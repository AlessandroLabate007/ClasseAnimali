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
            FileLogger.Instance.Log("Form1 caricato con successo.");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CCane dog = new CCane(0, 0, "");
            FileLogger.Instance.Log($"Click Cane - Verso: {dog.Verso()}");
            SoundPlayer cane = new SoundPlayer("canesuono.wav");
            cane.Play();
            MessageBox.Show(dog.Verso());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            CUccello crow = new CUccello(0, 0, "i");
            FileLogger.Instance.Log($"Click Corvo - Verso: {crow.Verso()}");
            SoundPlayer corvo = new SoundPlayer("corvosuono.wav");
            corvo.Play();
            MessageBox.Show(crow.Verso());
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            CGatto cat = new CGatto(8, 67, "n");
            FileLogger.Instance.Log($"Click Gatto - Verso: {cat.Verso()}");
            SoundPlayer gatto = new SoundPlayer("gattosuono.wav");
            gatto.Play();
            MessageBox.Show(cat.Verso());
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            CScimmia scimmia = new CScimmia(0, 0, "");
            FileLogger.Instance.Log($"Click Scimmia - Verso: {scimmia.Verso()}");
            SoundPlayer monkey = new SoundPlayer("scimmiasuono.wav");
            monkey.Play();
            MessageBox.Show(scimmia.Verso());
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            CLeone lion = new CLeone(0, 0, "");
            FileLogger.Instance.Log($"Click Leone - Verso: {lion.Verso()}");
            SoundPlayer leone = new SoundPlayer("suonoleone.wav");
            leone.Play();
            MessageBox.Show(lion.Verso());
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            CParrot parrot = new CParrot(0, 0, "");
            FileLogger.Instance.Log($"Click Pappagallo - Verso: {parrot.Verso()}");
            SoundPlayer pappagallo = new SoundPlayer("parrotsuono.wav");
            pappagallo.Play();
            MessageBox.Show(parrot.Verso());
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            CCanguro kangaroo = new CCanguro(0, 0, "");
            FileLogger.Instance.Log($"Click Canguro - Verso: {kangaroo.Verso()}");
            SoundPlayer canguro = new SoundPlayer("cangurosuono.wav");
            canguro.Play();
            MessageBox.Show(kangaroo.Verso());
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            CPanda pandi = new CPanda(0, 0, "");
            FileLogger.Instance.Log($"Click Panda - Verso: {pandi.Verso()}");
            SoundPlayer panda = new SoundPlayer("pandasuono.wav");
            panda.Play();
            MessageBox.Show(pandi.Verso());
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            CMaiale pig = new CMaiale(0, 0, "");
            FileLogger.Instance.Log($"Click Maiale - Verso: {pig.Verso()}");
            SoundPlayer maiale = new SoundPlayer("maialesuono.wav");
            maiale.Play();
            MessageBox.Show(pig.Verso());
        }
    }
}
