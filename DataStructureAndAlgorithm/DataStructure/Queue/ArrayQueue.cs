using System;

namespace DataStructure
{
    /// <summary>
    /// 用数组实现队列
    /// 用2个index标记开始合结束
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ArrayQueue<T>
    {
        private int mCapicity;
        private int mStartIndex;
        private int mEndIndex;
        private int mCount;
        private T[] mArray;

        public ArrayQueue(int capicity)
        {
            mCapicity = capicity;
            mArray = new T[capicity];
        }

        public int Count
        {
            get
            {
                return mCount;
            }
        }

        public bool IsFull
        {
            get
            {
                return mCount == mCapicity;
            }
        }

        public int Capicity
        {
            get { return mCapicity; }
        }

        public bool IsEmpty
        {
            get
            {
                return mCount == 0;
            }
        }

        public void Clear()
        {
            mStartIndex = 0;
            mEndIndex = 0;
            mCount = 0;
            mCapicity = 0;
            mArray = null;
        }

        public void Enqueue(T e)
        {
            //队列满了
            if (IsFull)
            {
                throw new Exception("queue is full");
            }

            mArray[mEndIndex] = e;
            mCount++;

            //计算下一个位置
            mEndIndex++;
            if (mEndIndex == mCapicity)
            {
                mEndIndex = 0;
            }
        }

        public T Dequeue()
        {
            //队列空
            if (IsEmpty)
            {
                throw new Exception("queue is empty");
            }

            var r = mArray[mStartIndex];

            //计算下一次取元素的index
            //取出元素后增加start
            mStartIndex++;
            //到达尾部，开始循环，下一次从头开始取
            if (mStartIndex == mCapicity)
            {
                mStartIndex = 0;
            }
            mCount--;
            return r;
        }

    }

}
