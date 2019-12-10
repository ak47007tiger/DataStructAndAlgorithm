using System.IO;
using System.Collections.Generic;
using System;
namespace Test
{
    public class TestDictionary{
        public void Test(){
            Dictionary<int,int> idToVal = new Dictionary<int, int>();
            idToVal.Add(1,1);
            idToVal[3] = 3;

            var id0v = idToVal[0];
            idToVal.Remove(2);

            Console.WriteLine(id0v);
        }
    }
}