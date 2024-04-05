using System;

class HelloWorld {
    static void Main()
    {
        int[] nums = new int[] {1,2,3,4};
        Array.Sort(nums);
        bool result = false;
        int count = 1; 
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1])
            {
                count++;
            }
            else
            {
                count = 1; 
            }

            if (count >= 2) 
            {
                result = true;
            }
        }
        Console.WriteLine(result);
    }
}