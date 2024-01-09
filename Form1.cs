using System.Collections;
using System.IO;

namespace WinForms_240108_PictureBox
{
    public partial class Form1 : Form
    {
        ArrayList Kolekcja = new ArrayList();
        int nr = 0;

        public Form1()
        {
            InitializeComponent();         

        }
           

        private void buttonPoprzedni_Click(object sender, EventArgs e)
        {
            if (nr > 0)
            {
                pictureBox1.Image = 
                    Image.FromFile(Kolekcja[nr--].ToString());
            }
        }

        private void buttonNastepny_Click(object sender, EventArgs e)
        {
            if (nr < Kolekcja.Count - 1)
            {
                pictureBox1.Image =
                    Image.FromFile(Kolekcja[nr++].ToString());
            }
        }

        private void buttonNowy_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter =
                "bitmapy(*.bmp) |*bmp" +
                "metapliki(*.wmf)|*.wmf" +
                "piktogrsmy(*.ico)|*.ico" +
                "jpegi(8.jpg)|*.jpg" +
                "gify(*.gif)|*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

            }

        }
    }
}