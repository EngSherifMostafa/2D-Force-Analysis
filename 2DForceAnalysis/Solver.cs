using System;

namespace _2DForceAnalysis
{
    class Solver
    {
        public static double[] Elimination(double rightAngle, double leftAngle, double weight)
        {
            //trigonometric functions in C# use radian system
            rightAngle = rightAngle * Math.PI / 180;
            leftAngle = leftAngle * Math.PI / 180;

            //fill matrix
            double[,] gaussianElimination =
            {
                { Math.Cos(rightAngle), -Math.Cos(leftAngle), 0 },
                { Math.Sin(rightAngle), Math.Sin(leftAngle), weight }
            };

            //eliminate element (1,0) and multiple (1,1), (1,2)
            var factor = -1 * (gaussianElimination[1, 0] / gaussianElimination[0, 0]);
            gaussianElimination[1, 0] += factor * gaussianElimination[0, 0]; //must equal zero
            gaussianElimination[1, 1] += factor * gaussianElimination[0, 1];
            gaussianElimination[1, 2] += factor * gaussianElimination[0, 2];

            //eliminate element (0,1) and multiple (0,0), (0,2)
            factor = -1 * (gaussianElimination[0, 1] / gaussianElimination[1, 1]);
            gaussianElimination[0, 0] += factor * gaussianElimination[1, 0];
            gaussianElimination[0, 1] += factor * gaussianElimination[1, 1]; //must equal zero
            gaussianElimination[0, 2] += factor * gaussianElimination[1, 2];

            return new[]
            {
                Math.Round(gaussianElimination[0, 2] / gaussianElimination[0, 0], 5),
                Math.Round(gaussianElimination[1, 2] / gaussianElimination[1, 1], 5)
            };
        }
    }
}
