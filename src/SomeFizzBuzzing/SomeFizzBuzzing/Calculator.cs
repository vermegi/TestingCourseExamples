using System.Collections.Generic;
using System.Linq;

namespace SomeFizzBuzzing
{
    public class Calculator
    {
        private readonly List<int> _numbers = new List<int>();

        public void EnterNumber(int number)
        {
            _numbers.Add(number);
        }

        public int Add()
        {
            return _numbers.Sum();
        }
    }
}