using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheOldRobot
{
    public interface IRobotCommand
    {
         void Run(Robot robot);
    }

    public class OnCommand : IRobotCommand
    {
        public void Run(Robot robot) => robot.IsPowered = true;
    }
    public class OffCommand : IRobotCommand
    {
        public void Run(Robot robot) => robot.IsPowered = false;
    }

    public class NorthCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            if (robot.IsPowered) robot.Y++;
        }
    }
    public class SouthCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            if (robot.IsPowered) robot.Y--;
        }
    }
    public class WestCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            if (robot.IsPowered) robot.X--;
        }
    }
    public class EastCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            if (robot.IsPowered) robot.X++;
        }
    }
}
