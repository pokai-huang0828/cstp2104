using Assignment3.Entities;

namespace Assignment3
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
