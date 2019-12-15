using System;
using System.Collections.Generic;

namespace Test
{
    public class TestDelegate
    {
        Delegate mSrc;
        // Delegate mSrc = (Action)(()=>{});
        public void AddItem(Action action)
        {
            mSrc = Delegate.Combine(mSrc, action);
        }

        public void AddItem<T>(Action<T> action)
        {
            mSrc = Delegate.Combine(mSrc, action);
        }

        public void Remove(Action action)
        {
            if(mSrc == null){
                Console.WriteLine("remove empty delegates");
                return;
            }
            mSrc = Delegate.Remove(mSrc, action);
        }

        public void Remove<T>(Action<T> action)
        {
            if(mSrc == null){
                Console.WriteLine("remove empty delegates");
                return;
            }
            mSrc = Delegate.Remove(mSrc, action);
        }

        public void Call(params object[] param)
        {
            if (null == mSrc)
            {
                Console.WriteLine("call empty delegates");
                return;
            }
            mSrc.DynamicInvoke(param);
            // var action = mSrc as Action;
            // action();
        }

        public void Action1()
        {
            Console.WriteLine("Action1");
        }

        public void Action2(int a)
        {
            Console.WriteLine("Action2");
        }

        public void Test()
        {
            Call();
            AddItem(Action1);
            Call();
            Remove(Action1);
            Call();
            Console.WriteLine("step 1 complete!");

            AddItem<int>(Action2);
            Call();
            Remove<int>(Action2);
        }
    }

    public class TestMessageSystem{
        public void Test(){
            // MessageSystem.Instance.Add(0,Action1);   
            // MessageSystem.Instance.Add<int>(1,Action2);

            MessageSystem.Instance.Dispatch(0);
            MessageSystem.Instance.Dispatch(1,1);
        }

        public void Action1()
        {
            Console.WriteLine("Action1");
        }

        public void Action2(int a)
        {
            Console.WriteLine("Action2: " + a);
        }
    }

    class Handler
    {
        private Delegate mDelegate;

        private HashSet<Delegate> mDelegates = new HashSet<Delegate>();

        public Handler()
        {
        }

        public Handler(int type)
        {
            EvtType = type;
        }

        public int EvtType { get; set; }

        public void Add(Delegate d)
        {
            if (mDelegates.Contains(d))
            {
                return;
            }

            mDelegates.Add(d);
            mDelegate = Delegate.Combine(mDelegate, d);
        }

        public void Remove(Delegate d)
        {
            if (mDelegates.Remove(d))
            {
                mDelegate = Delegate.Remove(mDelegate, d);
            }
        }

        public Delegate GetDelegate()
        {
            return mDelegate;
        }

        public void Call(params object[] objs)
        {
            if (null != mDelegate)
            {
                mDelegate.DynamicInvoke(objs);
            }
        }
    }

    public class MessageSystem : Singleton<MessageSystem>
    {
        Dictionary<int, Handler> mIdToDelegate = new Dictionary<int, Handler>();

        Handler GetOrCreateHandler(int type)
        {
            if (!mIdToDelegate.TryGetValue(type, out var handler))
            {
                handler = new Handler(type);
                mIdToDelegate.Add(type, handler);
            }

            return handler;
        }

        Handler GetHandler(int type)
        {
            if (mIdToDelegate.TryGetValue(type, out var handler))
            {
                return handler;
            }

            return null;
        }

        public void AddDelegate(int type, Delegate action)
        {
            GetOrCreateHandler(type).Add(action);
        }

        public void Add(int type, Action action)
        {
            AddDelegate(type, action);
        }

        public void Add<T>(int type, Action<T> action)
        {
            AddDelegate(type, action);
        }

        public void Add<T1, T2>(int type, Action<T1, T2> action)
        {
            AddDelegate(type, action);
        }

        public void Add<T1, T2, T3>(int type, Action<T1, T2, T3> action)
        {
            AddDelegate(type, action);
        }

        public void Add<T1, T2, T3, T4>(int type, Action<T1, T2, T3, T4> action)
        {
            AddDelegate(type, action);
        }

        public void Add<T1, T2, T3, T4, T5>(int type, Action<T1, T2, T3, T4, T5> action)
        {
            AddDelegate(type, action);
        }

        public void Dispatch(int type, params object[] paramArray)
        {
            var handler = GetHandler(type);
            if (null != handler)
            {
                handler.Call(paramArray);
            }
        }

        // public void Dispatch<T>(int type, T t)
        // {
        // }

        // public void Dispatch<T1, T2>(int type, T1 t1, T2 t2)
        // {
        // }

        // public void Dispatch<T1, T2, T3>(int type, T1 t1, T2 t2, T3 t3)
        // {
        // }

        // public void Dispatch<T1, T2, T3, T4>(int type, T1 t1, T2 t2, T3 t3, T4 t4)
        // {
        // }

        // public void Dispatch<T1, T2, T3, T4, T5>(int type, T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        // {
        // }
    }
}