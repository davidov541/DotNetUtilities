using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace DLLTestArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, String> testDict = new Dictionary<string, string>();
            testDict.Add("Test1", "Test1");
            testDict.Add("Test2", "Test2");
            testDict.Add("Test3", "Test3");
            testDict.Add("Test4", "Test4");
            testDict.Add("Test5", "Test5");
            DictUtil.ShuffleDict(testDict);
            Console.Write("Completed Successfully");
            Console.ReadLine();
        }
    }
}
