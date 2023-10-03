namespace CS
{
    

    internal class Program
    {
        public const int n = 10000; //wielkosc tablicy

        static void Main(string[] args)
        {/*
            // int tab[100];  //język C i C++ 
            int[] tablica = new int[10];

            //tablica[0] = 85;

            Random r = new Random();

            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = r.Next(0,10);
                Console.Write(tablica[i] + " ");
            }

            */


            //zakres 0 do 10
            /*
            int tmp = 0;
            
            
            int[] t = new int[n];
            Random l = new Random();
            int zl=0;

            for (int i = 0; i < n; i++)
            {
                t[i] = l.Next(10,78);
                Console.Write(t[i] + " ");
            }

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n-1; j++)
                {
                    zl++;
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
            Console.Write("złożoność: " + zl);

            */

            int[,] a = new int[n, n]; //tablica dwuwymiarowa
            int[,] b = new int[n, n]; //tablica dwuwymiarowa
            int[,] c = new int[n, n];

            Random ll = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = ll.Next(10, 30);
                    b[i, j] = ll.Next(10, 30);

                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
               //     Console.Write(" [" + i + ","+ j +"] = " + a[i, j]);
                }
          //      Console.WriteLine();
            }
            

          //  Console.WriteLine("********************************");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                 //   Console.Write(" [" + i + "," + j + "] = " + b[i, j]);
                }
              //  Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        c[i, j] = c[i, j] + a[i, k] * b[k, j];

                    }


                }
            }

                    Console.WriteLine("********************************");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                   // c[i, j] = a[i, j] + b[i, j]; //dodawanie
              //      Console.Write(" [" + i + "," + j + "] = " + c[i, j]);
                }
            //    Console.WriteLine();
            }
            

        }
    }
}