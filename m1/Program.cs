namespace m1
{
    class Pierwsze
    {
        private const int N = 1000;
        private int[] pierwsze = new int[N];
        private int[] liczby = new int[N];
        public Pierwsze()
        {
            
            sitoErastotenesa();
            /*
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
            */
        }
        private void sitoErastotenesa()
        {
            int n = 0;
            for (int i = 0; i < N; i++)
                liczby[i] = 1;
            liczby[0] = liczby[1] = 0;
            for(int i = 2; i < N; i++)
            {
                if (liczby[i] == 0)
                    continue;
                // i jest liczbą pierwszą!
                pierwsze[n++] = i;

                for(int j = i*2; j< N; j=j+i)
                    liczby[j] = 0;
            }

        }
        public bool czyPierwsza(int n)
        {
            return liczby[n] == 1 ? true : false;
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

            Console.WriteLine(p.czyPierwsza(134));
            
        }
    }
}
