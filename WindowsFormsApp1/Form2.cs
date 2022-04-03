using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int i;
        string c;
        int tk;
        private void GameForm_Load(object sender, EventArgs e)
        {
            i = 300;
            c = "5:00";
            label1.Text = c;
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            timer1.Enabled = true;
            timer1.Start();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tk = --i;
            TimeSpan span = TimeSpan.FromMinutes(tk);
            string label = span.ToString(@"hh\:mm");
            label1.Text = label.ToString();
            if (i < 0) timer1.Stop();
        }

        List<Image> images = new List<Image>();
        List<PictureBox> pictureBoxes = new List<PictureBox>();
        
        public void images_add()
        {
            Random rnd = new Random();
            DirectoryInfo dir = new DirectoryInfo($"{Environment.CurrentDirectory}\\Photos");
            foreach (FileInfo file in dir.EnumerateFiles("*.jpg"))
            {
                images.Add(Image.FromFile(file.FullName));
            }
        }

        public void AssignImagessToPicterBoxes()
        {
            images_add();
            
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                //Label imageLabel = control as Label;
                //if (imageLabel != null)
                //{
                //    int randomNumber = random.Next(images.Count);
                //    imageLabel.Image = images[randomNumber];
                //    images.RemoveAt(randomNumber);
                //}
            }
        }



    }
}
