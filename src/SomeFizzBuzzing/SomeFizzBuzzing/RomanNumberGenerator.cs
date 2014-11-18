using System.Text;

namespace SomeFizzBuzzing
{
    public class RomanNumberGenerator
    {
        public string GenerateFor(int getal)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < getal; i++)
            {
                sb.Append("I");
            }
            return sb.ToString();
        }
    }
}