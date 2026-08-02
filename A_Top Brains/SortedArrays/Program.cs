using System.Collections.Generic;
using System.Security.Cryptography;
public class GenericMergeTwoArray<T>{

    public void PrintMerge(T [] arr, T [] arr1)
    {
        HashSet<T> sorted = new HashSet<T>();
        foreach(var i in arr)
        {
            sorted.Add(i);
        }
        foreach(var i in arr1)
        {
            sorted.Add(i);
        }
        T [] j = sorted.ToArray();
        Array.Sort(j);
        foreach(var i in j)
        {
            Console.WriteLine(i);
        }
        
    }
}
public class Program
{
    public static void Main()
    {
        int []arr = {12,43,56,76};
        int []arr1 = {1,2,3,56};
        GenericMergeTwoArray<int> g = new GenericMergeTwoArray<int>();
        g.PrintMerge(arr1,arr);
    }
}