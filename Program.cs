// See https://aka.ms/new-console-template for more information

List<long> arr = [1,5,2,4,3];

Result.miniMaxSum(arr);


class Result
{
    public static void miniMaxSum(List<long> arr)
    {
        arr.Sort();
        long minSum = arr.Take(4).Sum();
        long maxSum = arr.TakeLast(4).Sum();
        Console.WriteLine("{0} {1}", minSum, maxSum);
    }

}