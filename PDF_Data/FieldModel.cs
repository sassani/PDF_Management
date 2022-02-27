using System.Drawing;

namespace PDF_Data
{
    public class FieldModel
    {

        public string Name { get; set; }
        public Rectangle DataRegion { get; set; }
        public int FirstPage { get; set; }
        public int LastPage { get; set; }

        public FieldModel(string name, Rectangle rect, int firstPage = 1, int lastPage = -1)
        {
            Name = name;
            DataRegion = rect;
            FirstPage = firstPage;
            LastPage = lastPage;
        }

    }
}
