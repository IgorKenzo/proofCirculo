using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proofCirculo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int qtdFab = int.Parse(txtQtd.Text);

            gerarImgVw(qtdFab);
        }

        public void gerarImgVw(int qtd)
        {
            int centroX = this.Width / 2;
            int centroY = this.Height / 2;
            int numFab = qtd * 2 + 1;
            double diffAng = 360 / qtd;
            Image imgCoronga = Properties.Resources.img;

            for(int i = 0; i < numFab; i++)
            {
                PictureBox img = new PictureBox();
                img.Name = "img" + i;   
                img.Location = new Point(centroX + Convert.ToInt32(Math.Cos(diffAng * Math.PI/180 * i) * 2), centroY + Convert.ToInt32(Math.Sin(diffAng * Math.PI / 180 *  i) * 2));
                img.Image = imgCoronga;
                img.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Controls.Add(img);
                //Console.WriteLine(centroX + Convert.ToInt32(Math.Cos(diffAng * Math.PI / 180 * i) * 2) + " , " + centroY + Convert.ToInt32(Math.Sin(diffAng * Math.PI / 180 * i) * 2));
                Console.WriteLine(Math.Sin(diffAng * Math.PI / 180 * i) * 2);
            }
        }
  
    }
}
