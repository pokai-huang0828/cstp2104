using Assignment2.Entities;

namespace Assignment2
{
    public static class RepairChecker
    {
        public static bool isRepairNeeded(this Vehicles vehicles)
        {
            if (vehicles.IsRepairNeeded)
            {
                return true;
            }
            return false;
        }
    }
}
