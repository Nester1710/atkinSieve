using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace atkinSieve
{
    public class Sieve
    {
        public static List<int> Atkin(List<int> PrimeNumbers, int limit)
        {
            bool flag = false;
            int num = limit;
            while (!flag)
            {
                bool[] is_prime = new bool[limit + 1];
                int n;
                int sqr_lim = (int)Math.Sqrt(limit);
                for (int i = 0; i <= limit; i++) is_prime[i] = false;
                if (limit > 2)
                    is_prime[2] = true;
                if (limit > 3)
                    is_prime[3] = true;
                if (limit > 5)
                    is_prime[5] = true;
                for (int x = 1; 4 * x * x < limit; x++)
                {
                    for (int y = 1; 4 * x * x + y * y < limit; y += 2)
                    {
                        int g = 4 * x * x + y * y;
                        int rem = g % 60;
                        if (rem == 1 || rem == 13 || rem == 17 || rem == 29 || rem == 37 || rem == 41 || rem ==
                       49 || rem == 53)
                        {
                            is_prime[g] = !is_prime[g];
                        }
                    }
                }
                for (int x = 1; 3 * x * x < limit; x += 2)
                {
                    for (int y = 2; 3 * x * x + y * y < limit; y += 2)
                    {
                        int g = 3 * x * x + y * y;
                        int rem = g % 60;
                        if (rem == 7 || rem == 19 || rem == 31 || rem == 43)
                        {
                            is_prime[g] = !is_prime[g];
                        }
                    }
                }
                for (int x = 1; 2 * x * x < limit; x++)
                {
                    for (int y = x - 1; y > 0; y -= 2)
                    {
                        int g = 3 * x * x - y * y;
                        if (g >= limit) continue;
                        int rem = g % 60;
                        if (rem == 11 || rem == 23 || rem == 47 || rem == 59)
                        {
                            is_prime[g] = !is_prime[g];
                        }
                    }
                }
                for (int i = 5; i <= sqr_lim; i++)
                {
                    if (is_prime[i])
                    {
                        n = i * i;
                        for (int j = n; j <= limit; j += n)
                        {
                            is_prime[j] = false;
                        }
                    }
                }
                for (int i = 2; i <= limit; i++)
                {
                    if (is_prime[i])
                    {
                        PrimeNumbers.Add(i);
                    }
                }
                if (PrimeNumbers.Count == num)
                {
                    flag = true;
                }
                else
                {
                    PrimeNumbers.Clear();
                    limit++;
                }
            }
            return PrimeNumbers;
        }
    }
}
