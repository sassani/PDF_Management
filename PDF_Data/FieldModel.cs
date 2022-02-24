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
        public string Name { get; set; }
        public List<Point> RectPoints { get; set; }

        public FieldModel(string name, List<Point> recPoints)
        {
            Name = name;
            RectPoints = recPoints;
        }
    }
}
