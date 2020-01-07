using System.Threading.Tasks;
namespace Test
{
    public class TestAsyncAwaitWithComplete
    {
        public int counter;

        public async void Add1()
        {
            await Task.Factory.StartNew(()=>{
                
            });
        }

        public async void Add2()
        {
            await Task.Run(() =>
            {

            });
        }
    }
}