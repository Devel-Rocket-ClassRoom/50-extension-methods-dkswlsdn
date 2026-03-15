using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Shuffle
{
    public static void ShuffleList<T>(this IList<T> list)
    {
        Random random = new Random();

        for (int i = list.Count - 1; i >= 1; i--)
        {
            int num = random.Next(i - 1);
            T temp = list[i];
            list[i] = list[num];
            list[num] = temp;
        }
    }
}
