using System.Text.RegularExpressions;
namespace RegexPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter MobileNumber");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            string namepatterns = "^[0-9]{2}[][0-9]{10}$";
            Regex regex = new Regex(namepatterns);
            if (regex.IsMatch(name))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("valid MobileNumber " + name);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid MobileNumber " + name);
            }
        }
    }
}


