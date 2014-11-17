using System;

namespace SomeProject
{
    public class FizzBuzz
    {
        private readonly IAmAConsole _theConsole;

        public FizzBuzz(IAmAConsole theConsole)
        {
            _theConsole = theConsole;
        }

        public void GiveAnswer(int i)
        {
            var hasWritten = false;
            if (i%3 == 0)
            {
                _theConsole.Write("Fizz");
                hasWritten = true;
            }
            if (i%5 == 0)
            {
                _theConsole.Write("Buzz");
                hasWritten = true;
            }

            if (! hasWritten)
                _theConsole.Write(i.ToString());

            _theConsole.WriteLine();
        }
    }
}
