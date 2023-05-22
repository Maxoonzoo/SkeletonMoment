namespace practiceTask
{
    class program
    {
    public static void Main()
        {
            int a = 1;
            int b = 1;
            int c = 1;
            int[] nums = new int[40];
            nums[0] = a;
            nums[1] = b;
            for (int i = 2; i < 40; i++)
            {
                c = a + b;
                nums[i] = c;
                a = b;
                b = c;
            }
            Console.WriteLine(string.Join(", ", nums));
        }
    }
}