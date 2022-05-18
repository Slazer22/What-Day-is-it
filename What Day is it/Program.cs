using System;
using System.Text;


namespace Weekdays;

class ExerciseTwo
{
    public static void Main(string[] args)
    {
        char letter;
        Console.WriteLine("Please enter a letter");
        letter = Convert.ToChar(Console.ReadLine());

        switch(letter)
        {
            case 'A':
                Console.WriteLine("Today is Monday");
                break;

            case 'B':
                Console.WriteLine("Today is Tuesday");
                break;

            case 'C':
                Console.WriteLine("Today is Wednesday");
                break;

            case 'D':
                Console.WriteLine("Today is Thursday");
                break;

            case 'E':
                Console.WriteLine("Today is Friday! Wooohoooo");
                break;

            case 'F':
                Console.WriteLine("Today is Saturday! Good i can work out now");
                break;

            case 'G':
                Console.WriteLine("Today is Sunday! Time to go worship the lord");
                break;


            default:
                Console.WriteLine("Try again. Out of the Domain");
                break;



            
        }
    }
}

