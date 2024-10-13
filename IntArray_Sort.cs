namespace sol
{
    class Sol
    {

        public static int[] exampleArr =
        {
            1, 9, 4, 2, 19, 12
        };

        public static int[] sortIntArray(int[] unsortedArray)
        {
            int flags = 0;
            int temp;
            for(int i = 0; i < unsortedArray.Length; i++)
            {
                if (unsortedArray[i] != unsortedArray.Length-1 && i != 0 && (unsortedArray[i - 1] > unsortedArray[i]))
                {
                    flags++;
                    temp = unsortedArray[i - 1];
                    unsortedArray[i - 1] = unsortedArray[i];
                    unsortedArray[i] = temp;
                }
            }
            if (flags == 0)
            {
                return unsortedArray;
            }
            else { return sortIntArray(unsortedArray); }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Unsorted array.\r\n");
            for (int i = 0; i < exampleArr.Length; i++) 
            {
                Console.Write(exampleArr[i]);
                if (i != exampleArr.Length-1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("\r\n\r\n\r\n");
            int[] sortedArr = sortIntArray(exampleArr);
            Console.WriteLine("Sorted array.\r\n");
            for (int i = 0; i < sortedArr.Length; i++)
            {
                Console.Write(sortedArr[i]);
                if (i != sortedArr.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("\r\n");
        }
    }
}