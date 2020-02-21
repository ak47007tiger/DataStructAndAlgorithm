namespace DataStructure.Test
{

    public class IEA{
        public static explicit operator IEB(IEA b){
            return new IEB();
        }
    }

    public class IEB{
        public static implicit operator IEA(IEB b){
            return new IEA();
        }

        // public static explicit operator IEA(IEB b){
        //     return new IEA();
        // }
    }

    public class TestImplictAndExplict : BaseSolution
    {
        float val;

        public static implicit operator TestImplictAndExplict(int val){
            var a = new TestImplictAndExplict();
            a.val = val + 10;
            return a;
        }

        public static implicit operator int(TestImplictAndExplict a){
            return (int)(a.val - 10);
        }

        public static implicit operator TestImplictAndExplict(float val){
            var a = new TestImplictAndExplict();
            a.val = val + 20;
            return a;
        }

        // public static implicit operator float(A a){
        //     return a.val - 20;
        // }

        public static explicit operator float(TestImplictAndExplict a){
            return a.val - 10;
        }

        public static void Test(){
            TestImplictAndExplict aIns = 10;

            int intV = aIns;

            TestImplictAndExplict bIns = 20f;

            float fVal = bIns;

            println(fVal);


            IEA iea = new IEA();

            IEB ieb = new IEB();

            iea = ieb;
        }
    }
}