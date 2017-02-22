namespace ZadanieDrugie
{
    class Sortowanie : ISortBabTablicy
    {
        public void SortowanieBabelkowe(int[] a)
        {
            int n = a.Length;

            while (n > 0)
            {
                for (int i = 0; i < n - 1; i++)
                {
                    if (a[i] > a[i + 1])
                    {
                        Zamien(ref a[i], ref a[i + 1]);
                    }
                }
                n--;
            }
        }
        public void Zamien(ref int n, ref int m)
        {
            int temp = n;
            n = m;
            m = temp;
        }
    }
}
