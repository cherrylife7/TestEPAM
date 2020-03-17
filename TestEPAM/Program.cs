namespace TestEPAM
{
    class Program
    {
        static void Main()
        {
            //Sorting
            var arr = Functions.SortIntArray(new int[] { 9, 5, 1, 345, 78, 0, 12, 8, 2, 4 });

            //Checking whether the number is in the array
            bool hasInt = Functions.Contains(arr, 7);

            //Unique words only
            Functions.FindUniqueWords("EPAM is a big company represented by many big offices across the globe with significant presense in big Eastern European, such as countries including offices in Russia, Bulgaria, Ukraine, Russia, Ukraine, Czechia.");

            ulong fact = Functions.Factorial(20);
            
        }
    }
}
