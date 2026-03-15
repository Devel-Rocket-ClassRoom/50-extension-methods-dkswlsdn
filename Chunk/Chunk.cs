using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class ChunkClass
{
    public static IEnumerable<IEnumerable<T>> Chunk<T>(this IEnumerable<T> list, int size)
    {
        List<T> tempList = list.ToList();

        int count = 0;
        bool isEnd = false;

        while (!isEnd)
        {
            List<T> temp = new List<T>();

            for (int i = size * count; i < size * count + size; i++)
            {
                if (tempList.Count == i)
                {
                    isEnd = true;
                    break;
                }

                temp.Add(tempList[i]);
            }

            yield return temp;

            count++;
        }

        yield break;
    }
}