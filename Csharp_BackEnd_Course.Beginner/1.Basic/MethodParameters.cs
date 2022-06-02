using System;

namespace Csharp_BackEnd_Course.Beginner._1.Basic
{
    internal class MethodParameters
    {
        static void Run(string[] args)
        {
            // Passing value types by value
            showDoubled(4);

            // Passing reference types by value
            Ball ball = new Ball();
            ball.Diameter = 15;
            InflateBall(ball);
            GetNewBall(ball);
            Console.WriteLine("Diameter: {0}", ball.Diameter);

            // Passing value types by reference
            int original = 100;
            showDoubledByReference(ref original);
            Console.WriteLine("Original: {0}", original);

            // Passing reference types by reference
            InflateBallByReference(ref ball);
            GetNewBallByReference(ref ball);
            Console.WriteLine("Diameter: {0}", ball.Diameter);

            // Output parameters
            int parameter;
            CalculateRectangle(1, 2, out parameter);
            Console.WriteLine(parameter);

            // parameter arrays
            showScores("Bob", 15);
            showScores("Jill", 10, 12, 15, 25);
            showScores("James");
        }

        static void showDoubled(int valueToShow)
        {
            valueToShow *= 2;
            Console.WriteLine("Double: {0}", valueToShow);
        }

        static void showDoubledByReference(ref int valueToShow)
        {
            valueToShow *= 2;
            Console.WriteLine("Double: {0}", valueToShow);
        }

        static void InflateBall(Ball ball)
        {
            ball.Diameter++;
        }

        static void GetNewBall(Ball ball)
        {
            ball = new Ball();
            ball.Diameter = 1;
        }

        static void InflateBallByReference(ref Ball ball)
        {
            ball.Diameter++;
        }

        static void GetNewBallByReference(ref Ball ball)
        {
            ball = new Ball();
            ball.Diameter = 1;
        }

        static int CalculateRectangle(int width, int height, out int parameter)
        {
            parameter = (width * 2) + (height * 2);
            return width * height;
        }

        static void showScores(string player, params int[] scores)
        {
            Console.WriteLine("Player: {0}", player);

            foreach (int score in scores)
            {
                Console.Write("{0}\t", score);
            }

            Console.WriteLine("\n");
        }
    }
}
