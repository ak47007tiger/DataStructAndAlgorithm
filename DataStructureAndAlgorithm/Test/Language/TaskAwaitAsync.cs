using System;
using System.Threading;
using System.Threading.Tasks;

namespace Test
{
    public class TaskAwaitAsync
    {

        public async void TestWhile(){
            PrintThread("before while");
            int cnt = 6;
            while(true){
                PrintThread("in while");
                await FakeWork(1000);
                PrintThread("after await in while");
                cnt--;
                if(cnt == 0){
                    return;
                }
            }
        }

        public void PrintThread(string prefix){
            Console.WriteLine($"{prefix} thread is : {Thread.CurrentThread.ManagedThreadId}");
        }

        public async Task FakeWork(int consume){
            await Task.Run(()=>{
                Thread.Sleep(consume);
            });
            // await Task.Factory.StartNew(()=>{
            //     Thread.Sleep(consume);
            // });
        }

        public void TestMain()
        {
            Console.WriteLine("我是主线程，线程ID：{0}", Thread.CurrentThread.ManagedThreadId);
            // TestAsync();
            TestAsync();
            Console.ReadLine();
        }

        async Task TestAsync()
        {
            TestVoid();
            // await TestVoid();

            Console.WriteLine("调用GetReturnResult()之前，线程ID：{0}。当前时间：{1}", Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString("yyyy-MM-dd hh:MM:ss"));
            // var name = GetReturnResult();
            Console.WriteLine("调用GetReturnResult()之后，线程ID：{0}。当前时间：{1}", Thread.CurrentThread.ManagedThreadId, DateTime.Now.ToString("yyyy-MM-dd hh:MM:ss"));
            var result = await GetReturnResult();
            // Console.WriteLine("得到GetReturnResult()方法的结果：{0}。当前时间：{1}", await name, DateTime.Now.ToString("yyyy-MM-dd hh:MM:ss"));
            Console.WriteLine("得到GetReturnResult()方法的结果：{0}。当前时间：{1}", result, DateTime.Now.ToString("yyyy-MM-dd hh:MM:ss"));
        }

        async Task<string> GetReturnResult()
        {
            Console.WriteLine("执行Task.Run之前, 线程ID：{0}", Thread.CurrentThread.ManagedThreadId);
            return await Task.Run(() =>
            {
                Thread.Sleep(3000);
                Console.WriteLine("GetReturnResult()方法里面线程ID: {0}", Thread.CurrentThread.ManagedThreadId);
                return "我是返回值";
            });
        }

        async Task<int> ComputeValue()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(1);
                return 0;
            });
        }

        async void TestVoid()
        {
            Console.WriteLine("TestVoid 1()方法里面线程ID: {0}", Thread.CurrentThread.ManagedThreadId);

            await Task.Run(() =>
            {
                Thread.Sleep(2000);
                Console.WriteLine("TestVoid Run()方法里面线程ID: {0}", Thread.CurrentThread.ManagedThreadId);
                return "我是返回值";
            });

            Console.WriteLine("TestVoid 2()方法里面线程ID: {0}", Thread.CurrentThread.ManagedThreadId);
        }

    }


}