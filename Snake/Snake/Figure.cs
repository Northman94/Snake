using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Figure
    {
        //protected - чтоб ее видели наследники
        protected List<Point> pList;

        // Добавляем virtual будет ошибка в Horizontalline вызове
        public virtual void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

    }
}
