using System.Text.RegularExpressions;
namespace RegexPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter LastName");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            string namepatterns = "^[A-Z][a-zA-Z]{2,}$";
            Regex regex = new Regex(namepatterns);
            if (regex.IsMatch(name))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("valid data " + name);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid data " + name);
            }
        }
    }
}


