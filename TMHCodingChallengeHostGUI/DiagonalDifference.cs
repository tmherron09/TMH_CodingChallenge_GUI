using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMHCodingChallengeHostGUI
{
    public class DiagonalDifference
    {
        private List<List<int>> _arr;
        private Random rng;
        // Hard coded defaults based on HackerRank.
        private int upperLimit = 100;
        private int lowerLimit = -100;


        public List<List<int>> Arr
        {
            get => _arr;
        }

        public int UpperLimit
        {
            get => upperLimit;
            set
            {
                if (value <= lowerLimit)
                {
                    throw new Exception("Upper Limit must be larger than Lower Limit.");
                }
                else
                {
                    upperLimit = value;
                }
            }
        }
        public int LowerLimit
        {
            get => lowerLimit;
            set
            {
                if (value >= upperLimit)
                {
                    throw new Exception("Lower Limit must be less than the Upper Limit.");
                }
                else
                {
                    lowerLimit = value;
                }
            }
        }

        public Random Rng
        {
            get
            {
                if (rng == null)
                {
                    rng = new Random(DateTime.Now.Day + DateTime.Now.Hour + DateTime.Now.Second);
                }
                return rng;
            }
        }

        public int InputLength
        {
            get
            {
                return _arr.Count;
            }
        }


        // Default With HackerRank Example
        public DiagonalDifference()
        {
            List<int> innerOne = new List<int>() { 11, 2, 4 };
            List<int> innerTwo = new List<int>() { 14, 5, 6 };
            List<int> innerThree = new List<int>() { 10, 8, -12 };
            _arr = new List<List<int>>() { innerOne, innerTwo, innerThree };
        }

        public DiagonalDifference(List<List<int>> arr)
        {
            _arr = arr;
        }

        // Random Creation with N set
        // TODO: Put negative check in UI code.
        public DiagonalDifference(int n)
        {
            _arr = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                _arr.Add(GenerateListOfInt(n));
            }
        }

        public DiagonalDifference(int n, int lowerLimit, int upperLimit)
        {
            LowerLimit = lowerLimit;
            UpperLimit = UpperLimit;
            _arr = new List<List<int>>();
            for (int i = 0; i < n; i++)
            {
                _arr.Add(GenerateListOfInt(n));
            }
        }

        public List<int> GenerateListOfInt(int n)
        {
            List<int> arrInt = new List<int>();
            for (int i = 0; i < n; i++)
            {
                arrInt.Add(Rng.Next(lowerLimit, upperLimit + 1));
            }
            return arrInt;
        }


        // Based on the HackRank provided Function
        public int DiagonalDifferenceResult(List<List<int>> arr)
        {

            int row = 0;
            int leftToRight = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                leftToRight += arr[i][row];
                row++;
            }

            int rightToLeft = 0;
            row = 0;

            for (int i = arr.Count - 1; i >= 0; i--)
            {
                rightToLeft += arr[i][row];
                row++;
            }

            Console.WriteLine(rightToLeft);

            int result = Math.Abs(leftToRight - rightToLeft);

            return result;

        }

        public int DiagonalDifferenceResult() => DiagonalDifferenceResult(_arr);

        

        // Second attempt at different approach.
        // WIP
        //public int DiagonalDifferenceResultMethod2(List<List<int>> arr)
        //{

        //    int ltr = 0;
        //    int rtl = 0;

        //    for (int i = 0; i < arr.Count; i++)
        //    {
        //        ltr += arr[i][i];
        //        rtl += arr[arr.Count - (i + 1)][arr.Count - (i + 1)];
        //    }

        //    return (ltr - rtl) >= 0 ? ltr - rtl : (ltr - rtl) * -1;

        //}
    }
}
