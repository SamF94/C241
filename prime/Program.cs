using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime numbers less than or equal to 1000...");

            List<int> primes = new List<int>();

            for (int n = 0; n <= 1000; n++)
            {
                if(isPrime(n)) primes.Add(n);
            }

            foreach(int i in primes)
            {
                Console.WriteLine(i);
                Console.Read();
            }
            

        }

        public static Boolean isPrime(int number)
        {
            for (int i = 2; i < number; i++){
                if(number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
