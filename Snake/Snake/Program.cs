﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            // Установить размер окна и убрать возможность пролистывать экран
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            // Отрисовка рамочки

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');

            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rightLine.Draw();




            // Отрисовка точек

            Point p1 = new Point(3, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();



            // Создаем линию
            HorizontalLine line = new HorizontalLine(5, 10, 8 , '+');
            line.Draw();

            Console.ReadLine();
        }
    }
}
