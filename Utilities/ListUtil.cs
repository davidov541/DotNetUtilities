using System;
using System.Collections.Generic;

namespace Utilities
{
    public static class ListUtil
    {
        public static List<String> ShuffleList(List<String> list)
        {
            List<int> poses = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < list.Count; i++)
            {
                int currNum = -1;
                do
                {
                    currNum = rnd.Next(0, list.Count);
                } while (poses.Contains(currNum));
                poses.Add(currNum);
            }
            List<String> randomizedList = new List<string>();
            foreach (int num in poses)
            {
                randomizedList.Add(list[num]);
            }
            return randomizedList;
        }
    }
}
