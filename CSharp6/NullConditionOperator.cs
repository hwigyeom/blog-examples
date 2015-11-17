using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp6
{
    class NullConditionOperator
    {
        public ComicBook ComicBook { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public Bitmap GetPage(int page)
        {
            Bitmap bitmap = null;

            if (ComicBook != null)
            {
                if (ComicBook.Images != null)
                {
                    if (ComicBook.Images.Count >= page &&
                        ComicBook.Images[page - 1] != null)
                    {
                        bitmap = ComicBook.Images[page - 1];
                    }
                }
            }

            return bitmap;
        }

        public Bitmap GetPage2(int page)
        {
            return ComicBook?.Images?[page - 1];
        }

        public Bitmap Resize(Bitmap bitmap)
        {
            return bitmap;
        }
    }

    class ComicBook
    {
        public string Name { get; set; }

        public int TotalPage { get; set; }

        public IList<Bitmap> Images { get; set; }
    }
}
