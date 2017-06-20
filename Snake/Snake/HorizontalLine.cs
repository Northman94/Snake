using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure
    {
        #region List
        //List<Point> pList;
        #endregion

        public HorizontalLine(int xLeft, int xRight, int y, char sym)
        {
            pList = new List<Point>();

            for (int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        #region Draw
        //public void Draw()
        //{
        //    foreach (Point p in pList)
        //    {
        //        p.Draw();
        //    }
        //}
        #endregion
    }
}
