using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{

    class Program
    {

        static void Main(string[] args)
        {
            /*Calculates the area and perimeter of a room given the user's entered dimensions 
              then ask user if they want to calculate another room or quit.*/
            do
            {
                //Request the user to enter the length.
                double Length;
                Console.WriteLine("Please enter the length of the room: ");
                Length = double.Parse(Console.ReadLine());

                //Request the user to enter the width.
                double Width;
                Console.WriteLine("Please enter the width of the room:");
                Width = double.Parse(Console.ReadLine());

                /*Calculates the area of the room by multiplying the length by the width then 
                *prints the result to the console.*/
                double Area = (Length * Width);
                Console.WriteLine("The area of the room {0}", Area);

                /*Calculates the perimeter of the room by adding all sides of the room then
                *printsthe result to the console*/
                double Perimeter = (2 * Length + 2 * Width);
                Console.WriteLine("The perimeter of the room {0}", Perimeter);


                /*If the Perimeter is greater than 0, cosole asks user to continue by entering
                *'y' or 'n'.  If y then console starts from the beginning if n then console can 
                *exit at by the user entering any key*/
                if (Perimeter > 0)
                {
                    char yes;

                    Console.WriteLine("Continue? (y/n): ");
                    yes = char.Parse(Console.ReadLine());

                    if (yes == 'y')
                    {
                        continue;
                    }
                    else if (yes != 'y')
                    {
                        return;
                    }
                }

            }
            while (true);


        }

    }
}