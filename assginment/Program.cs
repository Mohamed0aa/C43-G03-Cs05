namespace assginment
{
    internal class Program
    {
        #region q3
        //static int sumsub(int a,int b,out int c,out int d)
        //{

        //    c= a + b;
        //    d = a - b;
        //    return 0;
        //}
        #endregion

        #region q4
        //static void sumDigit(int n)
        //{
        //    int sum = 0;
        //    while (n != 0)
        //    {
        //        sum += (n % 10);
        //        n /= 10;
        //    }
        //    Console.WriteLine(sum);
        //}
        #endregion

        #region q5
        //static bool isPrime(int n)
        //{
        //    for (int i = 2; i < n; i++)
        //    {
        //        if (n % 2 == 0) return false;
        //    }
        //    return true;
        //}
        #endregion

        #region q6
        //static int min_max(ref int[] arr, ref int c, ref int d)
        //{
        //    Array.Sort(arr);
        //    c = arr[0];
        //    d = arr[arr.Length - 1];
        //    return 0;
        //}
        #endregion
        static void Main(string[] args)
        {
            #region q1 : Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            //by value : it sent copy of values to function and not affect out of function
            //by refrence: it sent actual data to function to modifiy it  and affect out of function
            #endregion

            #region q2 : Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.
            //by value : it sent the pointer  of value which point on actual data and make paramter equale it so it affect on main value
            //by refrence:it  share pointer and main value to function 
            //by refrence: it sent actual data to function to modifiy it  and affect out of function
            #endregion

            #region q3 : Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers
            //int n=int.Parse(Console.ReadLine()), m= int.Parse(Console.ReadLine());
            //int sum, sub;
            //sumsub(n,m,out sum,out sub);
            //Console.WriteLine($"sum = {sum}\n sub = {sub}");
            #endregion

            #region q4 : Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            //int n=int.Parse(Console.ReadLine());
            //sumDigit(n);
            #endregion

            #region q5 :
            //int n=int.Parse(Console.ReadLine());
            //Console.WriteLine(isPrime(n));
            #endregion

            #region q6 : Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //int[] arr = { 1, 2, 3, 4, 5, 6 };
            //int min=0, max=0;
            //min_max(ref arr, ref min, ref max);
            //Console.WriteLine($"min = {min}  max = {max}");

            #endregion


        }
    }
}
