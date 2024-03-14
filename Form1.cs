using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;



namespace Film
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Resim dosyasının yolunu belirtin
            string imagePath = "C:\\myImage.jpg";

            // PictureBox kontrolünün Image özelliğini ayarlayın
            pictureBox1.Image = System.Drawing.Image.FromFile("C:\\Users\\TUĞÇE\\Pictures\\image1.jpg");

            string videoPath = "C:\\Users\\TUĞÇE\\Downloads\\Bird Box _ Official Trailer [HD] _ Netflix.mp4";
            axWindowsMediaPlayer2.URL = videoPath;

           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
