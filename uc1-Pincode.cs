using System.Text.RegularExpressions;
namespace REXGEX_PATTERNS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Pincode ");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            string namepatterns = "^[5]{1}[0-9]{5}$"; 
            Regex regex = new Regex(namepatterns);  
            if(regex.IsMatch(name))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("valid Data " + Pincode);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Invalid Data " + Pincode);
            }
            
        }
    }
}
