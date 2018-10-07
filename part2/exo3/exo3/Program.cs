using System;

namespace exo3
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 34;
            string gender = "homme";
            if (age >= 18 && gender == "homme")
                Console.WriteLine("Vous êtes un homme et vous êtes majeur.");
            else if (age >= 18 && gender == "femme")
                Console.WriteLine("Vous êtes majeur et vous êtes une femme.");
            else if (age <= 18 && gender == "femme")
                Console.WriteLine("Vous êtes mineur et vous êtes une femme.");
            else if (age <= 18 && gender == "homme")
                Console.WriteLine("Vous êtes mineur et vous êtes une homme.");

        }
    }
}
