namespace CS
{
    

    internal class Program
    {
        public const int n = 10; //wielkosc tablicy

        static void Main(string[] args)
        {
            int[] t1 = { 12, 3545, 343 };
            int[] t2 = new int[100];
            int[] t = new int[n];
            Random l = new Random();

            for (int i = 0; i < n; i++)
            {
                t[i] = l.Next(10,78);
                Console.Write(t[i] + " ");
            }
            
 
        
        }
    }
}