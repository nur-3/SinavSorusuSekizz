using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SınavSekizinciSoru
{
    class Program
    {
        static int[] dizi;

        static void Main(string[] args)
        {

            Console.WriteLine("kaç sayı istiyorsun?");
            int n = Int32.Parse(Console.ReadLine());
            Random rnd = new Random();
            int size = 0;

            for(int i=0;i<=n;i++){
              
                if(size<=n){
                   size= resize(size);

                 dizi = new int[size];  
                }

                dizi[i]=rnd.Next(0,50);

            }

            for (int j = n - 1; j >= 0; j--)
            {
                Console.WriteLine(dizi[j]);
                Console.Read();
            }


        }
      static int resize(int s){
          s = s+1;
          return s;
     }

    }
}
