namespace m1
{
    class Pierwsze
    {
        private const int N = 1000;
        private int[] pierwsze = new int[N];
        private int[] liczby = new int[N*N];
        public Pierwsze()
        {
            for(int i = 0; i < N*; i++)
                liczby[i] = 1;
            int ile = 0;
            int n = 2;
            while (ile < N)
            {
                if (czyPierwsza(n))
                {
                    pierwsze[ile] = n; 
                    ile++;

                }
                n++;
            }
        }
        public bool czyPierwsza(int n)
        {
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0)
                    return false;
            return true;
        }
        public int zwroc(int n)
        {
            return pierwsze[n];
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Pierwsze p = new Pierwsze();
            for(int i=0; i<=10; i++)
                Console.WriteLine(p.zwroc(i));

            Console.WriteLine(p.czyPierwsza(134534));
            
        }
    }
}
