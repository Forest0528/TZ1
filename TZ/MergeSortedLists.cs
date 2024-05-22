using System;
using System.Collections.Generic;

public class MergeSortedLists
{
    public static List<int> MergeAndSortDescending(List<int> list1, List<int> list2)
    {
        int i = list1.Count - 1;
        int j = list2.Count - 1;
        List<int> result = new List<int>();

        while (i >= 0 && j >= 0)
        {
            if (list1[i] > list2[j])
            {
                result.Add(list1[i]);
                i--;
            }
            else
            {
                result.Add(list2[j]);
                j--;
            }
        }

        while (i >= 0)
        {
            result.Add(list1[i]);
            i--;
        }

        while (j >= 0)
        {
            result.Add(list2[j]);
            j--;
        }

        return result;
    }

    public static void Main()
    {
        List<int> list1 = new List<int> { 1, 3, 5, 7 };
        List<int> list2 = new List<int> { 2, 4, 6, 8 };

        List<int> result = MergeAndSortDescending(list1, list2);

        Console.WriteLine("Сортировщик, который выдаёт список по убыванию: ");
        foreach (int num in result)
        {
            Console.Write(num + " ");
        }
    }
}
