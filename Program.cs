using System.ComponentModel.DataAnnotations;
using System.Net;

namespace c__oppgave_2;

class Program
{
    static void Main(string[] args)
    {


        DateTime currentTime = DateTime.Now;


        bool male = false;
        bool genderAns = false;
        bool bdayAns = false;
        bool parent = false;
        bool parentAns = false;

        Console.WriteLine("Input name:");
        string? name = Console.ReadLine();

        int bday = 0; //bday må ha en verdi for å få ny verdi fra input i try/catch loopen
        Console.WriteLine("Input date of birth using only numbers: (example: 12121992)");
        while (bdayAns == false)
        {
            try
            {

                bday = Convert.ToInt32(Console.ReadLine());

                bdayAns = true;
            }
            catch
            {
                Console.WriteLine("Please write 8 numerical digits");
            }

        }
        Console.WriteLine(bday); //teste bday TESTE BDAY
        Console.WriteLine("Input Height in cm:");
        double? height = Convert.ToDouble(Console.ReadLine());
        //GENDER
        while (genderAns == false)
        {
            Console.WriteLine("Input gender: male/female");
            string? gender = Console.ReadLine()?.ToLower().Trim();
            if (gender == "male" || gender == "man" || gender == "he")
            {
                male = true;
                genderAns = true;
            }
            else if (gender == "female" || gender == "woman" || gender == "she")
            {
                male = false;
                genderAns = true;
            }
            else
            {
                Console.WriteLine("Incorrect input, try again.");

            }
        }



        //COUNTRY
        Console.WriteLine("Input the country you live in:");
        string? country = Console.ReadLine();
        //PARENT
        while (parentAns == false)
        {
            Console.WriteLine("do you have any kids (y/n)");
            string? parentStr = Console.ReadLine()?.ToLower().Trim();// IKKEFERDIG
            if (parentStr == "y" || parentStr == "yes" || parentStr == "true")
            {
                parent = true;
                parentAns = true;
            }
            else if (parentStr == "n" || parentStr == "no" || parentStr == "false")
            {
                parent = false;
                parentAns = true;
            }
            else
            {
                Console.WriteLine("Incorrect input. Please input yes or no.");

            }
        }

        Console.WriteLine(name + bday + height + male + country + parent);
        //checks ved bruk av dictionary
        // var checkDict = new Dictionary<tuple<string, int>, string>();
        // checkDict.add(Tuple.Create(bday, ))

        bool morningTime = false;
        if (currentTime.Hour > 5 && currentTime.Hour < 15)
        {
            morningTime = true;
        }
        if (morningTime == true)
        {
            Console.WriteLine("hello morning");
        }
    }

}
