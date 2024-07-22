namespace L1_Task1;

class Program
{

    //step 1 Define number
    //step 2 loop and make a rolling count
    //step 3 avg it out by nums.Length
    //step 4 print to screen
    
    static void Main(string[] args)
    {
        double RollingCount;
        double[] nums = {45.3,67.5,-45.6,20.34,-22.0,45.6};
        Console.WriteLine("Hello, World!");
        Loop(nums,RollingCount);
        double avg = nums.Length / RollingCount;

    }
    static double[] Loop(double[] nums,double RollingCount)
    {
        {      
            //double[] numsloop = nums;

            double RollingCount = 0;
            foreach (double i in nums)
            {
                RollingCount += nums[i];
            }
            //while (i = 0; i != nums.Length; i++;)
            //{
            //    rollingcount += nums[i];
            //}
        }
        return RollingCount;
        //void nums;
    }
}
