namespace remove_element
{

    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[index++] = nums[i];
                }
            }
            return index;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

           
            int[] nums = { 3, 2, 2, 3, 4, 3, 5 };
            int val = 3;

           
            int newLength = solution.RemoveElement(nums, val);

            
            Console.Write("Array after removing elements equal to " + val + ": ");
            for (int i = 0; i < newLength; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine($"\nNew length: {newLength}");
        }
    }
}
