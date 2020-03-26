using System;

namespace RobotTest
{
    class Program
    {
        static void Main(string[] args)
        {

            //string topRigthCornerCoordsStr = Console.ReadLine();

            //string roverPosition = Console.ReadLine();

            // Initialise a rover
            Rover rv = new Rover(1, 2, Heading.N);

            string roverCommands = Console.ReadLine();

            char[] roverCommandsChars = roverCommands.ToCharArray();

            foreach (char c in roverCommandsChars)
            {
                switch (c)
                {
                    case 'M':
                        rv.Move();
                        break;
                    case 'L':
                        rv.RotateL();
                        break;
                    case 'R':
                        rv.RotateR();
                        break;
                }
            }

            Console.WriteLine($"{rv.Location.X}{rv.Location.Y}{rv.Heading}");
        }
    }
}
