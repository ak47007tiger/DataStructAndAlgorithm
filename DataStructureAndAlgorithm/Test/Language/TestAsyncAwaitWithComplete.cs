using System.Threading;
using System.Threading.Tasks;
namespace Test
{
    /*
    线程a：
        异步调用1：调用方法1
        异步调用2：调用方法1
        方法1：根据变量走2个分支

    */
    public class TestAsyncAwaitWithComplete
    {
        public int counter;

        public async void WorkFunc1(){
            await Task.Factory.StartNew(()=>{
                Thread.Sleep(100);
            });
        }

        public async void WorkFunc2(){
            await Task.Factory.StartNew(()=>{
                Thread.Sleep(100);
            });
        }

        public async void Call(){
            await Task.Factory.StartNew(()=>{
                
            });
        }

        public async void Add1()
        {
            await Task.Factory.StartNew(()=>{
                counter += 1;
            });
        }

        public async void Minus1()
        {
            await Task.Run(() =>
            {
                counter -= 1;
            });
        }
    }
}