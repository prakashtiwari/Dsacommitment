namespace ProblemSolution.MaxInWindow
{
    public class MaxWindow
    {
        public List<int> SlidingMaximum(List<int> A, int B)
        {
            List<int> ans = new List<int>();
            List<int> Qi = new List<int>();
            int i;
            for (i = 0; i < B; ++i)
            {
                //Creating the first window.
                while (Qi.Count != 0 && A[i] >= A[Qi[Qi.Count - 1]]) //If current number is greater than previous numbers, renove all previous number.
                {
                    Console.WriteLine($"Qi is: {Qi[Qi.Count - 1]}");
                    Qi.RemoveAt(Qi.Count - 1);
                }
                Qi.Insert(Qi.Count, i);
            }
            for (; i < A.Count; ++i)
            {
                ans.Add(A[Qi[0]]);
                // removes the elements not in range
                while ((Qi.Count != 0) && Qi[0] <= i - B)
                {
                    Qi.RemoveAt(0);
                }
                // removes the elements lesser than A[i]
                while ((Qi.Count != 0) && A[i] >= A[Qi[Qi.Count - 1]])
                {
                    Qi.RemoveAt(Qi.Count - 1);
                }
                Qi.Insert(Qi.Count, i);
            }
            ans.Add(A[Qi[0]]);
            return ans;
        }

    }
}
