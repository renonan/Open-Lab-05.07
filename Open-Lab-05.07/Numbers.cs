using System;
using System.Linq;

namespace Open_Lab_05._07
{
    public class Numbers
    {
        public int[] RemoveSmallest(int[] nums)
        {
            var numbersList = nums.ToList();
            numbersList.Remove(nums.Min());
            return numbersList.ToArray();
        }
    }
}
