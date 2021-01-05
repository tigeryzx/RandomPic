using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPic.Client
{
    public class ImageHelper
    {
        public static ImageSizeInfo GetImageSizeInfo(string imgPath)
        {
            using (FileStream file = new FileStream(imgPath, FileMode.Open, FileAccess.Read))
            {
                using (Image tif = Image.FromStream(stream: file,
                                                    useEmbeddedColorManagement: false,
                                                    validateImageData: false))
                {
                    float width = tif.PhysicalDimension.Width;
                    float height = tif.PhysicalDimension.Height;
                    float hresolution = tif.HorizontalResolution;
                    float vresolution = tif.VerticalResolution;

                    return new ImageSizeInfo()
                    {
                        Width = Convert.ToInt32(width),
                        Height = Convert.ToInt32(height)
                    };
                }
            }
        }
    }

    public class ImageSizeInfo
    {
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
