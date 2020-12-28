using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EverythingSharp;
using EverythingSharp.Enums;

namespace RandomPic.Client
{
    public partial class Form1 : Form
    {
        private int TotalFileCount = 0;
        private List<EverythingResult> SearchResultList;

        public Form1()
        {
            InitializeComponent();

            using (var everything = new Everything())
            {
                var query = "pic_";
                var maxResults = -1;
                var offset = 0;
                var sorting = Sort.NameAscending;
                var fields = RequestFlags.FullPathAndFileName | RequestFlags.Size;



                var results = everything.Search(query, maxResults, offset, sorting, fields);
                this.TotalFileCount = results.Count();
                this.SearchResultList = results.ToList();
            }

            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            timer1.Enabled = true;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            var currentValue = progressBar1.Value;

            if (currentValue >= 10)
            {
                this.progressBar1.Value = 0;
                return;
            }
            currentValue += 1;
            this.progressBar1.Value = currentValue;
        }

        private Image small_img;
        private Image bg_img;

        private void button1_Click(object sender, EventArgs e)
        {
            if (small_img != null)
                small_img.Dispose();

            if (bg_img != null)
                bg_img.Dispose();

            var rand = new Random();

            var num = rand.Next(0, this.TotalFileCount);
            var file = this.SearchResultList[num];

            var img = System.Drawing.Image.FromFile(file.FullPath);

            var content_w = this.pictureBox1.Width;
            var content_h = this.pictureBox1.Height;

            var small_img_w = 0;
            var small_img_h = 0;

            double rate = 1;

            if (img.Width > content_w)
                rate = Convert.ToDouble(content_w) / Convert.ToDouble(img.Width);
            else if (img.Height > content_h)
                rate = Convert.ToDouble(content_h) / Convert.ToDouble(img.Height);

            small_img_w = Convert.ToInt32(img.Width * rate);
            small_img_h = Convert.ToInt32(img.Height * rate);

            small_img = img.GetThumbnailImage(small_img_w, small_img_h, null, (IntPtr)0);
            this.pictureBox1.Image = small_img;

            bg_img = new GaussianBlur(small_img as Bitmap).Process(10);
            this.BackgroundImage = bg_img;


            this.lbFileName.Text = Path.GetFileName(file.FullPath);
            this.lbPath.Text = file.FullPath;
            this.lbSize.Text = file.Size.ToString();
            this.lbWidthAndHeight.Text = img.Width + "x" + img.Height;

            img.Dispose();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            Pen pp = new Pen(Color.White,5);
            e.Graphics.DrawRectangle(pp, e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle.X + e.ClipRectangle.Width - 1, e.ClipRectangle.Y + e.ClipRectangle.Height - 1);
        }
    }
}
