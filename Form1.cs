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
                "bitmapy (*.bmp) |*.bmp"+
                "|metapliki (*.wmf) |*.wmf"+
                "|piktogrsmy (*.ico) |*.ico" +
                "|jpegi (*.jpg) |*.jpg" +
                "|gify (*.gif) |*.gif";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream plik;
                StreamWriter stZapis;
                
                //za³adowanie obrazka do pictureBox
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

                //dodanie obrazka do kolekcji
                Kolekcja.Add(openFileDialog1.FileName);

                //zapis nazwy i œcie¿ki w pliku tekstowym
                plik = new FileStream(
                    "C:\\Users\\gab\\Desktop\\plikObrazkow.txt", 
                    FileMode.Append,
                    FileAccess.Write,
                    FileShare.None);
                stZapis = new StreamWriter(plik);
                stZapis.WriteLine(openFileDialog1.FileName);
                stZapis.Close();
                plik.Close();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream plik;
            StreamReader stCzyt;

            //odczyt z pliku
            plik = new FileStream(
                "C:\\Users\\gab\\Desktop\\plikObrazkow.txt",
                FileMode.OpenOrCreate,
                FileAccess.Read,
                FileShare.None);
            stCzyt = new StreamReader(plik);

            //wczytuje obrazki póki s¹ wiersze
            //Peek() daje 
            while (stCzyt.Peek() > -1)
            {
                Kolekcja.Add(stCzyt.ReadLine());
            }

            stCzyt.Close();
            plik.Close();

            //jezeli jest coœ zapisane
            //za³aduj pierwszy element do pictureBox
            if (Kolekcja.Count > 0)
            {
                pictureBox1.Image = 
                    Image.FromFile(Kolekcja[0].ToString());
            }
        }
    }
}