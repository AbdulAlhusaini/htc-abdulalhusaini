using System;
using System.Collections.Generic;

namespace htc_abdulalhusaini
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MadLibs. Would you like to begin? Yes or No");
            string Response = Console.ReadLine();
            if (Response == "Yes" || Response == "yes") {
                madLib();
            }
            if (Response == "No" || Response == "no") {
                Environment.Exit(0);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Congratulations on completing the MadLib! Would you like to try another?");
            string ResponseThree = Console.ReadLine();
            if (ResponseThree == "Yes" || ResponseThree == "yes") {
                madLib2();
            }
            if (ResponseThree == "No" || ResponseThree == "no") {
                Environment.Exit(0);
            }
        }






























        public static void madLib()
        {
            List<string> items = new List<string>();
            Console.WriteLine("Choose a color");
            string color = Console.ReadLine();
            items.Add(color);
            Console.WriteLine("Choose a superlative that ends in -est");
            string superlative = Console.ReadLine();
            items.Add(superlative);
            Console.WriteLine("Choose an adjetive");
            string adjetive1 = Console.ReadLine();
            items.Add(adjetive1);
            Console.WriteLine("Choose a plural body part");
            string pluralBodyPart = Console.ReadLine();
            items.Add(pluralBodyPart);
            Console.WriteLine("Choose a singular body part");
            string singularBodyPart = Console.ReadLine();
            items.Add(singularBodyPart);
            Console.WriteLine("Choose a noun");
            string noun = Console.ReadLine();
            items.Add(noun);
            Console.WriteLine("Choose an animal in its plural form");
            string animal = Console.ReadLine();
            items.Add(animal);
            Console.WriteLine("Choose another adjetive");
            string adjetive2 = Console.ReadLine();
            items.Add(adjetive2);
            Console.WriteLine("Choose a third adjetive");
            string adjetive3 = Console.ReadLine();
            items.Add(adjetive3);
            Console.WriteLine("Choose a fourth adjetive");
            string adjetive4 = Console.ReadLine();
            items.Add(adjetive4); 
            Console.WriteLine("Your completed MadLib is: ");
            Console.WriteLine(" ");
            Console.WriteLine("The " + color + " Dragon is the " + superlative + " Dragon of all.");
            Console.WriteLine("It has " + adjetive1 + pluralBodyPart + " and a " + singularBodyPart + " shaped like a " + noun);
            Console.WriteLine("It loves to eat " + animal + " although it will feast on nearly anything");
            Console.WriteLine("It is " + adjetive2 + " and " + adjetive3);
            Console.WriteLine("You must be " + adjetive4 + "around it, or you may end up as it`s meal!");
            Console.WriteLine(" ");

            Console.WriteLine("Would you like a list of all the items you used in the order you entered them?");
            string ResponseTwo = Console.ReadLine();
            if (ResponseTwo == "Yes" || ResponseTwo == "yes") {
                foreach (string element in items) {
                Console.Write(element + ", ");
            }
            Console.Write("totaling 10 items.");
            if (ResponseTwo == "No" || ResponseTwo == "no") {
                Environment.Exit(0);
            }
        }

    }





        public static void madLib2() {
            List<string> items2 = new List<string>();
            Console.WriteLine("Choose a noun");
            string noun = Console.ReadLine();
            items2.Add(noun);
            Console.WriteLine("Choose a plural noun");
            string pluralNoun = Console.ReadLine();
            items2.Add(pluralNoun);
            Console.WriteLine("Choose another noun");
            string noun2 = Console.ReadLine();
            items2.Add(noun2);
            Console.WriteLine("Choose a place");
            string place = Console.ReadLine();
            items2.Add(place);
            Console.WriteLine("Choose an adjective");
            string adjetive = Console.ReadLine();
            items2.Add(adjetive);
            Console.WriteLine("Choose a third noun");
            string noun3 = Console.ReadLine();
            items2.Add(noun3);
            Console.WriteLine("Your completed MadLib is: ");
            Console.WriteLine(" ");
            Console.WriteLine("Be kind to your " + noun + "-footed " + pluralNoun);
            Console.WriteLine("For a duck may be somebody`s " + noun2 + ",");
            Console.WriteLine("Be kind to your " + pluralNoun + " in " + place);
            Console.WriteLine("Where the weather is always " + adjetive);
            Console.WriteLine("You may think that this is the " + noun3);
            Console.WriteLine("Well it is.");
            Console.WriteLine(" ");

            Console.WriteLine("Would you like a list of all the items you used in the order you entered them?");
            string ResponseFour = Console.ReadLine();
            if (ResponseFour == "Yes" || ResponseFour == "yes") {
                foreach (string element in items2) {
                Console.Write(element + ", ");
            }
            Console.Write("totaling 6 items.");
            if (ResponseFour == "No" || ResponseFour == "no") {
                Environment.Exit(0);
            }
            }

        }
    }
}

