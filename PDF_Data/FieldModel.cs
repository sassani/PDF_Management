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

        public enum FieldTypes { FIXED, LABEL };
        public string Name { get; set; }
        public Rectangle DataArea { get; set; }
        public FieldTypes Type { get; set; }

        public FieldModel(string name, FieldTypes ft, Rectangle rect)
        {
            Name = name;
            DataArea = rect;
            Type = ft;
        }
    }
}
