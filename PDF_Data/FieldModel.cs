using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDF_Data
{
    public class FieldModel
    {

        public enum PageLocation { COVER, ALL, RANGE };
        public string Name { get; set; }
        public Rectangle DataArea { get; set; }
        public PageLocation Page { get; set; }
        public int FirstPage { get; set; }
        public int LastPage { get; set; }

        public FieldModel(string name, PageLocation ft, Rectangle rect, int firstPage = 1, int lastPage = -1)
        {
            Name = name;
            DataArea = rect;
            Page = ft;
            FirstPage = firstPage;
            LastPage = lastPage;
        }
    }
}
