using System;

namespace NumberOfDiscIntersections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = {1, 5, 2, 1, 4, 0};
            Console.WriteLine(solution(A));
        }
        public static int solution(int[] A)
        {
            //create pairs at each point to the right and to the left
            //sort the pairs
            //if pair at right is greater than pairs at left that is an intersection count
            //return -1 if intersecting points>10,000,000
            long[][] pairs = new long[2][];
            int count = 0;
            pairs[0] = new long[A.Length];
            pairs[1] = new long[A.Length];
            for (long i = 0; i < A.Length; i++)
            {
                pairs[0][i] = i - A[i];
                pairs[1][i] = i + A[i];
            }
            Array.Sort(pairs[0], pairs[1]);
            for (long i = 0; i < A.Length; i++)
            {
                for (long j = i + 1; j < A.Length; j++)
                {
                    if (pairs[1][i] >= pairs[0][j]) count++;
                }
                if (count > 10000000) return -1;
            }

            return count;
        }
    }
}
