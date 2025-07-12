using System.Collections.Immutable;

namespace Assigment3CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            ////Q1 : 1. Write a program that prints an identity matrix using for loop,
            ////in other words takes a value n from the user and shows the identity table of size n * n.
            //Console.WriteLine("Pls Enter the size of Matrix");
            //int size = int.Parse(Console.ReadLine());
            //int[,] IdentityMatrix = new int[size, size];
            //for (int r =0;r<size;r++)
            //{
            //    for(int j =0;j<size;j++ )
            //    {
            //        if (r == j)
            //            IdentityMatrix[r, j] = 1;
            //        else
            //            IdentityMatrix[r, j] = 0;

            //    }
            //}
            //Console.WriteLine($"TheIdentityMatrix {size}*{size}:");
            //for (int r = 0; r < size; r++)
            //{
            //    for (int j = 0; j < size; j++)
            //    {
            //        Console.Write(IdentityMatrix[r, j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Q2
            ////Q2:2. Write a program in C# Sharp to find the sum of all elements of the array.
            //Console.WriteLine("Pls Enter the size of Array");
            //int size = int.Parse(Console.ReadLine());
            //Console.WriteLine("Pls Enter the elements of Array");
            //int[] arr = new int[size];
            //int sum = 0;
            //for (int i = 0; i < size; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //    sum += arr[i];
            //}
            //Console.WriteLine($"The sum of all elements of the array is: {sum}");

            #endregion

            #region Q3
            ////Q3: Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
            //Console.WriteLine("Pls Enter the size of Array");
            //int size = int.Parse(Console.ReadLine());
            //Console.WriteLine("Pls Enter the elements of Array1");
            //int[] arr1 = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    arr1[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Pls Enter the elements of Array2");
            //int[] arr2 = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    arr2[i] = int.Parse(Console.ReadLine());
            //}
            //int[] mergedArray = new int[size * 2];
            //arr1.CopyTo(mergedArray, 0);
            //arr2.CopyTo(mergedArray, size);
            //Console.WriteLine("TheMergedArray : ");
            //Console.Write("{");
            //for (int i = 0; i < mergedArray.Length; i++)
            //{

            //    Console.Write($"{mergedArray[i]} ");
            //    if (i < mergedArray.Length - 1)
            //        Console.Write(" ,");
            //}
            //Console.Write("}");
            //Console.WriteLine();
            //Array.Sort(mergedArray);
            //Console.WriteLine("TheSortedArray : ");
            //Console.Write("{");
            //for (int i = 0; i < mergedArray.Length; i++)
            //{

            //    Console.Write($"{mergedArray[i]} ");
            //    if (i < mergedArray.Length - 1)
            //        Console.Write(" ,");
            //}
            //Console.Write("}");

            #endregion

            #region Q4
            ////Q4: Write a program in C# Sharp to count the frequency of each element of an array.
            //Console.WriteLine("Pls Enter the size of Array");
            //int size = int.Parse(Console.ReadLine());
            //Console.WriteLine("Pls Enter the elements of Array1");
            //int[] arr = new int[size];
            //bool[] clacindx = new bool[size];
            //for (int i = 0; i < size; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //    clacindx[i] = false;
            //}

            //for (int i = 0; i < size; i++)
            //{
            //    if (clacindx[i]) continue;
            //   int count = 1;
            //    for (int j = i + 1; j < size; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            count++;
            //            clacindx[j] = true;
            //        }
            //    }
            //   Console.WriteLine($"countof {arr[i]} = {count}");
            //}


            #endregion

            #region Q5
            ////Q5:Write a program in C# Sharp to find maximum and minimum element in an array
            //Console.WriteLine("Pls Enter the size of Array");
            //int size = int.Parse(Console.ReadLine());
            //Console.WriteLine("Pls Enter the elements of Array1");
            //int[] arr = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}
            //int Max = arr[0];
            //int Min = arr[0];
            //for(int i = 0; i < size; i++)
            //{
            //    if(arr[i]>Max)
            //        Max = arr[i];

            //    if (arr[i] < Min)
            //        Min = arr[i];
            //}
            //Console.WriteLine($"MaxElement : {Max} , MinElement : {Min}");

            #endregion

            #region Q6
            ////Q6:Write a program in C# Sharp to find the second largest element in an array.
            //Console.WriteLine("Pls Enter the size of Array");
            //int size = int.Parse(Console.ReadLine());
            //Console.WriteLine("Pls Enter the elements of Array1");
            //int[] arr = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    arr[i] = int.Parse(Console.ReadLine());
            //}

            //int Max = arr[0];
            //int SecondMax = arr[0];
            //for(int i =0;i<size;i++)
            //{
            //    if (arr[i]>Max)
            //    {
            //        SecondMax =Max;
            //        Max= arr[i];
            //    }
            //    if (arr[i]> SecondMax && arr[i] != Max)
            //    {
            //        SecondMax = arr[i];
            //    }
            //}
            //Console.WriteLine($"MaxElement : {Max} , SecondMaxElement : {SecondMax}");
            #endregion


        }
    }
}
