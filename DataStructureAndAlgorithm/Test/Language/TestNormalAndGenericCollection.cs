using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using System;
using DataStructure;
using DataStructure.Toolkit;

namespace Test
{
    public class TestNormalAndGenericCollection
    {
        void T1()
        {
            var cnt = 100000;
            var dic = new Dictionary<int, string>();
            Printer.LogDuration(() =>
            {
                for (var i = 0; i < cnt; i++)
                {
                    dic.Add(i, i.ToString());
                }
            });

            Printer.LogDuration(() =>
            {
                for (var i = 0; i < cnt; i++)
                {
                    var s = dic[i];
                }
            });
        }

        void T2()
        {
            var cnt = 100000;
            var dic = new Hashtable();
            Printer.LogDuration(() =>
            {
                for (var i = 0; i < cnt; i++)
                {
                    dic.Add(i, i.ToString());
                }
            });

            Printer.LogDuration(() =>
            {
                for (var i = 0; i < cnt; i++)
                {
                    var s = dic[i];
                }
            });
        }

        public void Test()
        {
            T1();
            T2();
        }
    }
}