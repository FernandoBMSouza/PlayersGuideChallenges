using TheOldRobot;

Robot robot = new Robot();

for (int i = 0; i < robot.Commands.Length; i++)
{
    robot.Commands[i] = Console.ReadLine().ToLower() switch
    {
        "on" => new OnCommand(),
        "off" => new OffCommand(),
        "north" => new NorthCommand(),
        "south" => new SouthCommand(),
        "west" => new WestCommand(),
        "east" => new EastCommand(),
    };
}
Console.WriteLine();
robot.Run();

