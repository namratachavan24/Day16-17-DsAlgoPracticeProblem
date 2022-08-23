namespace DataStructureAlgorithm
{
    class Program
    {
        public static void Main(String[] args)
        {
            MergeSort mergeSort = new MergeSort();
            //mergeSort.MergeArray();
            Palindrom palindrom = new Palindrom();
            palindrom.CheckPalindrome(12);

            PrimeNumber primeNumber = new PrimeNumber();
            primeNumber.PrimeNumber1();

            BinarySearch binarySearch = new BinarySearch();
            binarySearch.binarySearch1();

            int[] a = { 2, 5, 4, 9, 8 };
            int n = a.Length;

            BinarySearchWord sort = new BinarySearchWord();
            sort.CreateSorted();

        }
    }
}
