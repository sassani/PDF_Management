﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDF_Data
{
    public class BLine
    {
        public Point P1 { get; set; }
        public Point P2 { get; set; }
        public Color PenColor { get; set; }
        public string Name { get; set; }

        public BLine(string name, Point p1, Point p2, Color c)
        {
            P1 = p1;
            P2 = p2;
            PenColor = c;
            Name = name;
        }
    }
}
