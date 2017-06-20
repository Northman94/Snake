using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine : Figure
    {
        #region List
        List<Point> pList;
        #endregion

        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            pList = new List<Point>();

            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        #region Draw
        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
        #endregion

    }
}
