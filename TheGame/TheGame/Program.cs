using System;

namespace TheGame
{
    class Program
    {
        static void Main(string[] args)
        {
                
            Console.WriteLine("Welcome to The Land of the Dragons.");
            Console.WriteLine("You can do many things but the main thing is to stop the King Dragon and\nend his plan to return the undead army.");

            int direction = 0;
            int playerHealth;
            int enemyHealth;

            string[] name = new string[1];
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("Now whats you're name fella");
                name[i] = Console.ReadLine();
            }
            Console.WriteLine("Welcome {0}", name);
            Console.WriteLine("Now Let me introduce my self my name is Valdier I'm a wizard that lives in the\nsliver tower in the middle of the land");

            Console.WriteLine("        |            |         ");
            Console.WriteLine("        |            |         ");
            Console.WriteLine("        |            |         ");
            Console.WriteLine("        |            |         ");
            Console.WriteLine("---------            ----------");
            Console.WriteLine("               O               ");
            Console.WriteLine("             - | -             ");
            Console.WriteLine("              | |              "); 
            Console.WriteLine("---------            ----------");
            Console.WriteLine("        |            |         ");
            Console.WriteLine("        |            |         ");
            Console.WriteLine("        |            |         ");
            Console.WriteLine("        |            |         ");

            Console.WriteLine("Now choice a direction that you want to go enter\n1 - Straight \n2 - Left \n3 - Right \n4 - Behind");
            
            direction = Convert.ToInt32(Console.ReadLine());

            if (direction == 1)
            {
                Console.WriteLine("        |     O      |         ");
                Console.WriteLine("        |    -|-     |         ");
                Console.WriteLine("        |    | |     |         ");
                Console.WriteLine("        |            |         ");
                Console.WriteLine("---------            ----------");
                Console.WriteLine("                               ");
                Console.WriteLine("                               ");
                Console.WriteLine("                               ");
                Console.WriteLine("---------            ----------");
                Console.WriteLine("        |            |         ");
                Console.WriteLine("        |            |         ");
                Console.WriteLine("        |            |         ");
                Console.WriteLine("        |            |         ");

                Console.WriteLine("You choose to move foward to explore what lies infront of you in the path");

            }
            else if (direction == 2)
            {
                Console.WriteLine("        |            |         ");
                Console.WriteLine("        |            |         ");
                Console.WriteLine("        |            |         ");
                Console.WriteLine("        |            |         ");
                Console.WriteLine("---------            ----------");
                Console.WriteLine("   O                           ");
                Console.WriteLine(" - | -                         ");
                Console.WriteLine("  | |                          ");
                Console.WriteLine("---------            ----------");
                Console.WriteLine("        |            |         ");
                Console.WriteLine("        |            |         ");
                Console.WriteLine("        |            |         ");
                Console.WriteLine("        |            |         ");

                Console.WriteLine("You choose to walk down the left path this one is a gravel and wet and mushy mud");
            }
            else if (direction == 3)
            {
                Console.WriteLine("        |            |         ");
                Console.WriteLine("        |            |         ");
                Console.WriteLine("        |            |         ");
                Console.WriteLine("        |            |         ");
                Console.WriteLine("---------            ----------");
                Console.WriteLine("                         O     ");
                Console.WriteLine("                        -|-    ");
                Console.WriteLine("                        | |    ");
                Console.WriteLine("---------            ----------");
                Console.WriteLine("        |            |         ");
                Console.WriteLine("        |            |         ");
                Console.WriteLine("        |            |         ");
                Console.WriteLine("        |            |         ");

                Console.WriteLine("You choose to walk to the right, this path is pretty nice it's calm \nbreeze brushing through you're hair.");
            }
            else if (direction == 4)
            {
                Console.WriteLine("        |            |         ");
                Console.WriteLine("        |            |         ");
                Console.WriteLine("        |            |         ");
                Console.WriteLine("        |            |         ");
                Console.WriteLine("---------            ----------");
                Console.WriteLine("                               ");
                Console.WriteLine("                               ");
                Console.WriteLine("                               ");
                Console.WriteLine("---------            ----------");
                Console.WriteLine("        |     O      |         ");
                Console.WriteLine("        |    -|-     |         ");
                Console.WriteLine("        |    | |     |         ");
                Console.WriteLine("        |            |         ");

                Console.WriteLine("You choose to turn around explore the path behind you,\nNow this path is dark it has strange noises coming from deep down the path,\nthe entrence is covered in old dying trees");
            }

        }
    }
}
