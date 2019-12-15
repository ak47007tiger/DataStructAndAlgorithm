using System;
namespace Test
{
    public class TestCloneEntity : ICloneable
    {
        public string content;
        public TestTwoStringCompare field;
        
        /// <summary>
        /// 深拷贝
        /// 对每一个field进行内存层面的复制
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            TestCloneEntity testCloneEntity = new TestCloneEntity();
            testCloneEntity.content = string.Copy(this.content);
            field = new TestTwoStringCompare();
            return testCloneEntity;
        }
        
        /// <summary>
        /// 浅拷贝
        /// 仅拷贝引用
        /// </summary>
        /// <returns></returns>
        public object ShadowClone()
        {
            //调用系统提供的浅拷贝方法
            return MemberwiseClone();
        }

        /// <summary>
        /// 自己实现浅拷贝
        /// 同上面的方法一样效果
        /// 除了对象是重新创建的，field都是复制引用
        /// </summary>
        /// <returns></returns>
        public object ShadowClone2()
        {
            var newObj = new TestCloneEntity();
            newObj.content = this.content;
            newObj.field = this.field;
            return newObj;
        }
    }

    public class TestTwoStringCompare
    {
        public void Compare()
        {
            var s1 = "s1";
            var s1_1 = "s1";
            var s2 = string.Copy(s1);
            Console.WriteLine(s1 == "s1");
            Console.WriteLine(s1 == s1_1);
            Console.WriteLine(s1 == s2);
        }
    }
}