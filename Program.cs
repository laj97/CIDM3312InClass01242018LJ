using System;

namespace SonOfNicknameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string [,] nicknames = new string [10, 2];

            //Row 1, column 1
            nicknames[0,0] = "Dude";
            //Row 1, column 2
            nicknames[0,1] = "Jones";

            //Row 2, column 1
            nicknames[1,0] = "Snappy";
            //Row 2, column 2
            nicknames[1,1] = "Firecracker";
            
            
            Console.WriteLine("Please enter your name: ");

            string name = Console.ReadLine();

            //For first and last name
            //string[] nameparts = name.split(new char ['  ']);

            //for(int i = 0; i < nameparts.Length; i++)
            {
                Console.WriteLine(nameparts[i]);
            }

            char[] nameparts = name.ToCharArray();

            for(int i = 0; i < nameparts.Length; i++)
            {

            }
        }
    }
}
