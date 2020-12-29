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
using ImageProcessor;
using ImageProcessor.Imaging;

namespace RandomPic.Client
{
    public partial class Form1 : Form
    {
        private string pic_keyword = "pic_";
        private int NextPicTime = 10;

        private PicPlayer picPlayer;

        public Form1()
        {   
            this._CurrentValue = this.NextPicTime;

            InitializeComponent();

            PicFinder picFinder = new PicFinder();
            picPlayer = new PicPlayer(picFinder.GetAllPicInfo(this.pic_keyword), new PicPlayerOptions()
            {
                BackgroundHeight = this.Height,
                BackgroundWidth = this.Width,
                PicBoxHeight = this.pictureBox1.Height,
                PicBoxWidth = this.pictureBox1.Width
            });

            picPlayer.OnPicNeedShow += new Action<PlayPicInfo>((obj)=>
            {
                this.lbTotalCount.Text = obj.PageIndexTip;
                this.pictureBox1.Image = obj.SmallImage;
                this.BackgroundImage = obj.BackgroundImage;
                this.lbFileName.Text = obj.PicInfo.FileName;
                this.lbPath.Text = obj.PicInfo.FilePath;
                this.lbSize.Text = obj.PicInfo.FileSizeName;
                this.lbWidthAndHeight.Text = obj.PicSize;
                this.lbForder.Text = obj.PicInfo.FolderPath;
            });

            picPlayer.NextPic();

            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            timer1.Enabled = true;

            this.btnNext.Click += new EventHandler((s, e) =>
            {
                this.timer1.Enabled = false;
                this.picPlayer.NextPic();
                this.CurrentValue = this.NextPicTime;
                this.timer1.Enabled = true;
            });

            this.btnPrev.Click += new EventHandler((s, e) =>
            {
                this.timer1.Enabled = false;
                this.picPlayer.PrevPic();
                this.CurrentValue = this.NextPicTime;
                this.timer1.Enabled = true;
            });

            var openFile = new EventHandler((s,e)=>
            {
                if (this.picPlayer.CurrentFile != null)
                    System.Diagnostics.Process.Start(this.picPlayer.CurrentFile.FilePath);
            });

            var openFolder = new EventHandler((s,e)=>
            {
                if (this.picPlayer.CurrentFile != null)
                    System.Diagnostics.Process.Start("Explorer.exe", @"/select," + this.picPlayer.CurrentFile.FilePath);
            });

            this.pictureBox1.Click += openFile;
            this.lbFileName.Click += openFile;
            this.lbPath.Click += openFile;

            this.lbForder.Click += openFolder;
            this.btnStop.Click += new EventHandler((s, e) => this.timer1.Enabled = !this.timer1.Enabled);
        }


        private int _CurrentValue = 10;
        public int CurrentValue
        {
            get
            {
                return this._CurrentValue;
            }
            set
            {
                this._CurrentValue = value;
                this.lbTime.Text = this._CurrentValue.ToString();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (CurrentValue <= 0)
            {
                CurrentValue = this.NextPicTime;
                picPlayer.NextPic();
            }
            else
                CurrentValue -= 1;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            Pen pp = new Pen(Color.White,5);
            e.Graphics.DrawRectangle(pp, e.ClipRectangle.X, e.ClipRectangle.Y, e.ClipRectangle.X + e.ClipRectangle.Width - 1, e.ClipRectangle.Y + e.ClipRectangle.Height - 1);
        }

    }
}
