namespace KilkellyJA5;
/*
John Kilkelly
350439
COP 2360
Assignment 5: Reverse and Capitalize
*/

class Program
{
    static void Main(string[] args)
    {
        A5 revString = new A5(); //new instance of the A5 class
        string output = revString.ReverseCapitalize("xyz");
        Console.WriteLine($"The reversed and capitalized string is {output}.");

    }
}
    public class A5
    {
        public string ReverseCapitalize(string initialString)
        {
            char[] charArray = initialString.ToCharArray(); //create an array of the characters in the argument to the initialString parameter
            Array.Reverse(charArray); //reverse characters in the array
            string reverseString = new string(charArray).ToUpper(); //capitalize the (reversed) array
            return reverseString;
        }
    }