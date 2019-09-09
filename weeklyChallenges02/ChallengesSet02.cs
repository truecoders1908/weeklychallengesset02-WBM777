using System;
using System.Collections.Generic;
using System.Linq;

namespace weeklyChallenges02
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            int x = 0;
            foreach (var item in vals)
            {
                x++;
            }
            if (x % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            
            
            if (numbers == null)
            {
                return 0;
            }
            else if (numbers.Count() == 0)
            {
                return 0;
            }
            else
            {
                return numbers.Max() + numbers.Min();
            }
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            
            if (str1.Length>str2.Length)
            {
                return str2.Length;
            }
            else
            {
                return str1.Length;
            }
           


        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                return numbers.Sum();

            }
        }

        public int SumEvens(int[] numbers)
        {
            List<int> x= new List<int>();
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                foreach (var item in numbers)
                {
                    if (item % 2 == 0)
                    {
                        x.Add(item);
                    }
                }

                return x.Sum();
            }
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers==null)
            {
                return false;
            }
            else if (numbers.Sum() % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            int x = 0;
            for (int i = 0; i < number; i++)
            {
                if (i % 2 != 0)
                {
                    x++;
                }
            }
            return x;
        }
    }
}
