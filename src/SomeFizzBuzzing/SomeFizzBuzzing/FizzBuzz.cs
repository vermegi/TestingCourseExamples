using System;

namespace SomeFizzBuzzing
{
    public class FizzBuzz
    {
        public string GiveAnswer(int i)
        {
            if (i <= 0)
                throw new ApplicationException();

            if (i % 3 == 0 && i % 5 == 0)
                return "FizzBuzz";
            if (i % 3 == 0)
                return "Fizz";
            if (i % 5 == 0)
                return "Buzz";
            return i.ToString();
        }
    }
}
