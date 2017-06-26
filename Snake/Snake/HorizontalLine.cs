using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure
    {
        #region Before_Bad_Change
        //public HorizontalLine(int xLeft, int xRight, int y, char sym)
        //{
        //    pList = new List<Point>();

        //    for (int x = xLeft; x <= xRight; x++)
        //    {
        //        Point p = new Point(x, y, sym);
        //        pList.Add(p);
        //    }
        //}

        //// В 14 уроке все кардинально ппоменяется без толкового объяснения
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

        #region Отменяем эти изменения обратно
        //public override void Draw()
        //{
        //    Console.ForegroundColor = ConsoleColor.Yellow;

        //    base.Draw();

        //    Console.ForegroundColor = ConsoleColor.White;
        //}
#endregion
    }
}
