﻿namespace DojoTemplateConsoleApp.Extensions
{
    public static class LiftExtensions
    {
        public static bool CallerOnWay(this ILift lift, Passenger? caller)
        {
            if (caller is null)
            {
                return false;
            }

            var callerAbove = caller.Origin >= lift.CurrentFloor;

            if (lift.Direction is Direction.Up && callerAbove
                || lift.Direction is Direction.Down && !callerAbove)
            {
                return true;
            }

            return false;
        }

        public static bool GoingSameDirection(this ILift lift, Passenger? caller)
        {
            if (caller is null)
            {
                return false;
            }

            return lift.Direction == caller.Direction;
        }
    }
}
