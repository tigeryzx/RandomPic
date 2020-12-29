using EverythingSharp;
using EverythingSharp.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPic.Client
{
    public class PicFinder
    {
        public List<PicInfo> GetAllPicInfo(string keyword)
        {
            var piclist = new List<PicInfo>();

            using (var everything = new Everything())
            {
                var query = keyword;
                var maxResults = -1;
                var offset = 0;
                var sorting = Sort.NameAscending;
                var fields = RequestFlags.FullPathAndFileName | RequestFlags.Size;

                var results = everything.Search(query, maxResults, offset, sorting, fields);
                if (results != null && results.Count() > 0)
                {
                    foreach (var item in results)
                    {
                        var ext = Path.GetExtension(item.FullPath);
                        if (string.IsNullOrEmpty(ext))
                            continue;

                        var picInfo = new PicInfo();
                        picInfo.FilePath = item.FullPath;
                        picInfo.FileSize = item.Size;
                        piclist.Add(picInfo);
                    }
                }
            }

            if (piclist != null && piclist.Count > 0)
            {
                int startIndex = 1;
                piclist.OrderBy(x => Guid.NewGuid()).ToList().ForEach(x =>
                {
                    x.ShowIndex = startIndex;
                    startIndex++;
                });
            }

            return piclist.OrderBy(x=>x.ShowIndex).ToList();
        }
    }
}
