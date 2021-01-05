using ImageProcessor;
using ImageProcessor.Imaging;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPic.Client
{
    public class PicPlayer
    {
        private List<PicInfo> picInfos;
        public PicInfo CurrentFile { get; set; }
        private Image small_img;
        private PicPlayerOptions options;
        private int MiniWidth = 500;
        private int MiniHeight = 500;

        public event Action<PlayPicInfo> OnPicNeedShow;


        public PicPlayer(List<PicInfo> list, PicPlayerOptions options)
        {
            this.picInfos = list;
            this.options = options;
        }


        public void NextPic()
        {
            var nextIndex = 1;
            if (this.CurrentFile != null)
                nextIndex = this.CurrentFile.ShowIndex + 1;

            var pic = this.picInfos.SingleOrDefault(x => x.ShowIndex == nextIndex);

            if(pic.ImageWidthAndHeight.Width <= this.MiniWidth && pic.ImageWidthAndHeight.Height <= this.MiniHeight)
            {
                this.CurrentFile = pic;
                NextPic();
                return;
            }

            if (pic != null)
                this.ShowPic(pic);
        }

        public void PrevPic()
        {
            var nextIndex = 1;
            if (this.CurrentFile != null)
                nextIndex = this.CurrentFile.ShowIndex - 1;

            var pic = this.picInfos.SingleOrDefault(x => x.ShowIndex == nextIndex);
            if (pic != null)
                this.ShowPic(pic);
        }

        private void ShowPic(PicInfo pic)
        {
            if (small_img != null)
                small_img.Dispose();

            PlayPicInfo result = new PlayPicInfo();
            result.PicInfo = pic;

            this.CurrentFile = pic;

            var currentIndex = pic.ShowIndex;
            var totalIndex = this.picInfos.Count();

            result.PageIndexTip = $"{currentIndex}/{totalIndex}";
            
            var img = pic.Bitmap;

            result.PicSize = img.Width + "x" + img.Height;

            var content_w = this.options.PicBoxWidth;
            var content_h = this.options.PicBoxHeight;

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
            result.SmallImage = small_img;

            // https://imageprocessor.org/imageprocessor/imagefactory
            result.BackgroundImage = new ImageFactory().Load(pic.Bitmap)
                .Resize(new ResizeLayer(
                    new Size(this.options.BackgroundWidth, this.options.BackgroundHeight),
                    resizeMode: ResizeMode.Crop))
                .Brightness(45)
                .GaussianBlur(15)
                .Image;

            this.OnPicNeedShow?.Invoke(result);

            pic.Dispose();
        }
    }

    public class PicPlayerOptions
    {
        public int BackgroundWidth { get; set; }

        public int BackgroundHeight { get; set; }

        public int PicBoxWidth { get; set; }

        public int PicBoxHeight { get; set; }
    }

    public class PlayPicInfo
    {
        public Image BackgroundImage { get; set; }

        public Image SmallImage { get; set; }

        public PicInfo PicInfo { get; set; }

        public string PicSize { get; set; }

        public string PageIndexTip { get; set; }
    }
}
