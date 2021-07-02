using System;
using System.Collections.Generic;
using System.Text;

namespace LineComparison
{
    class Line
    {
        public string name;
        public int x1, x2, y1, y2;
        public double lengthOfTheLine;
        public Line(string name)
        {
            this.name = name;
            this.x1 = 0;
            this.x2 = 0;
            this.y1 = 0;
            this.y2 = 0;
            this.lengthOfTheLine = 0;
        }
    }
}
