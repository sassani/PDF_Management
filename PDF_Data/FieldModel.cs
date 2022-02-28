using System;
using System.Collections.Generic;
using System.Drawing;

namespace PDF_Data
{
    public class FieldModel
    {
        public enum DataTypes {ROWS, FIXED}
        public string Name { get; set; }
        public DataTypes Type { get; set; }
        public Rectangle DataRegion { get; set; }
        public int FirstPage { get; set; }
        public int LastPage { get; set; }

        public FieldModel(string name, Rectangle rect,DataTypes type, int firstPage = 1, int lastPage = -1)
        {
            Name = name;
            DataRegion = rect;
            FirstPage = firstPage;
            LastPage = lastPage;
            Type = type;
        }

        public static string[] GetTypes()
        {
            return Enum.GetNames(typeof(DataTypes));
        }

    }
}
