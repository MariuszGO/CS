namespace CS
{
    

    internal class Program
    {
        public const int n = 5; //wielkosc tablicy

        static void Main(string[] args)
        {
            
            /*
            int tmp = 0;
            int[] t1 = { 12, 3545, 343 };
            int[] t2 = new int[100];
            int[] t = new int[n];
            Random l = new Random();

            for (int i = 0; i < n; i++)
            {
                t[i] = l.Next(10,78);
                Console.Write(t[i] + " ");
            }

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n-1; j++)
                {
                    if (t[j] > t[j + 1])
                    {
                        tmp = t[j];
                        t[j]= t[j+1];
                        t[j+1]= tmp;
                    }
                } 
            }

            Console.WriteLine(" ");
            for (int i = 0; i < n; i++)
            {
             
                Console.Write(t[i] + " ");
            }


*/

            int[,] tab = new int[n, n]; //tablica dwuwymiarowa
            Random ll = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    tab[i, j] = ll.Next(100, 888);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(" [" + i + ","+ j +"] = " + tab[i, j]);
                }
                Console.WriteLine();
            }



        }
    }
}