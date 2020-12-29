using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPic.Client
{
    public class PicInfo :IDisposable
    {
        public string FilePath { get; set; }

        public string FileName
        {
            get
            {
                return Path.GetFileName(this.FilePath);
            }
        }

        public long FileSize { get; set; }

        public string FileSizeName
        {
            get
            {
                if (FileSize <= 0)
                    return "0";
                return this.GetString(this.FileSize);
            }
        }

        public string FolderPath
        {
            get
            {
                return Path.GetDirectoryName(this.FilePath);
            }
        }

        public bool IsFav { get; set; }

        public int ShowIndex { get; set; }

        private Bitmap _Bitmap;
        public Bitmap Bitmap
        {
            get
            {
                if(this._Bitmap==null)
                    this._Bitmap = Image.FromFile(this.FilePath) as Bitmap;
                return this._Bitmap;
            }
        }

        public void Dispose()
        {
            if (this._Bitmap != null)
            {
                this._Bitmap.Dispose();
                this._Bitmap = null;
            }
        }

        private string GetString(long b)
        {
            const int GB = 1024 * 1024 * 1024;
            const int MB = 1024 * 1024;
            const int KB = 1024;


            if (b / GB >= 1)
            {
                return Math.Round(b / (float)GB, 2) + "GB";
            }


            if (b / MB >= 1)
            {
                return Math.Round(b / (float)MB, 2) + "MB";
            }


            if (b / KB >= 1)
            {
                return Math.Round(b / (float)KB, 2) + "KB";
            }


            return b + "B";
        }
    }
}
