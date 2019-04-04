using System;
using System.Collections.Generic;
using System.Linq;

namespace Utilities
{
    public static class DictUtil
    {
        public static Dictionary<String, String> ShuffleDict(Dictionary<String, String> dict)
        {
            List<int> poses = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < dict.Count; i++)
            {
                int currNum = -1;
                do
                {
                    currNum = rnd.Next(0, dict.Count);
                } while (poses.Contains(currNum));
                poses.Add(currNum);
            }
            Dictionary<String, String> randomizedDict = new Dictionary<String, String>();
            foreach (int num in poses)
            {
                randomizedDict.Add(dict.Keys.ToList<String>()[num], dict.Values.ToList<String>()[num]);
            }
            return randomizedDict;
        }
    }
}
