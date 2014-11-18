using System;

namespace SomeFizzBuzzing
{
    public class RealWriter : IWriteStuff
    {
        public void Write(string amessage)
        {
            Console.Write(amessage);
        }

        public void WriteLine()
        {
            Console.WriteLine();
        }
    }

    public class FizzBuzz2
    {
        private readonly IWriteStuff _writer;

        public FizzBuzz2(IWriteStuff writer)
        {
            _writer = writer;
        }

        public void GiveAnswer(int i)
        {
            if (i <= 0)
                throw new ApplicationException();

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

            if (!hasWritten)
                _writer.Write(i.ToString());

            _writer.WriteLine();
        }
    }
}