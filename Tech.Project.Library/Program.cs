using System;

namespace RobotTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> commands = new List<string>();

            List<Rover> roverList = new List<Rover>();

            UserInputManager uim = new UserInputManager();

            int[] topRightCorner;

            while(true) {
                
                topRightCorner = uim.GetTopRightCoords();

                if(topRightCorner[0] != 0 && topRightCorner[1] != 0) {
                    break;
                }
                Console.WriteLine("User input error, need 2 positive integers seperated by space, they can't be both zero");
            }

            while(true) {

                Rover rv = uim.GetRover();

                if(rv != null) {
                    roverList.append(rv);
                    command = uim.GetCommand()
                    if(string.IsNullOrEmpty(command)){
                        break;
                    }
                } else {
                    Console.WriteLine("User input error, need 2 positive integers followed by any heading seperated by space, for example, '2 3 N'");
                }
            }
            int counter = 0;
            foreach (rover in roverList) {
                rover.ExecuteCommand(commands[counter]);
                rover.Output();
                counter++;
            }

            // Initialise a rover
            Rover rv = new Rover(1, 2, Heading.N);
        }

    }
}
