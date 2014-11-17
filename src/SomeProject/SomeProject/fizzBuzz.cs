using System;

namespace SomeProject
{
    public class FizzBuzz
    {
        public void GiveAnswer(int i)
        {
            var hasWritten = false;
            if (i%3 == 0)
            {
                Console.Write("Fizz");
                hasWritten = true;
            }
            if (i%5 == 0)
            {
                Console.Write("Buzz");
                hasWritten = true;
            }

            if (! hasWritten)
                Console.Write(i);

            Console.WriteLine();
        }
    }
}
