using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '%');
            upLine.Drow();
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '%');
            downLine.Drow();
            VerticalLine leftLine = new VerticalLine(0, 24, 0, '%');
            leftLine.Drow();
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '%');
            rightLine.Drow();

            Point p2 = new Point(4, 5, '*');
            Snake snake = new Snake(p2, 4, Direction.Right);
            snake.Drow();

            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);

            Console.ReadKey();
        }

    }
}
