namespace DataStructure.Practice
{
    public class StringFormatParamCnt : BaseSolution
    {
        enum CType
        {
            //大括号外
            outC = 0,
            //{
            left,
            //大括号中间
            middle,
            //}
            right,
        }

        public void Test()
        {
            println(ComputeParamCnt("hello"));
            println(ComputeParamCnt("hello {0}"));
            println(ComputeParamCnt("hello {0}{{"));
            println(ComputeParamCnt("hello {{{0}abc12{1} {3}/{4}"));
        }

        public static int ComputeParamCnt(string content)
        {
            var cnt = 0;
            var s = CType.outC;
            for (var i = 0; i < content.Length; i++)
            {
                var c = content[i];
                switch (s)
                {
                    case CType.outC:
                        switch (c)
                        {
                            case '{':
                                s = CType.left;
                                break;
                            case '}':
                                s = CType.right;
                                break;
                        }
                        break;
                    case CType.left:
                        switch (c)
                        {
                            case '{':
                                break;
                            case '}':
                                //{}这样的当直接展示的内容
                                s = CType.outC;
                                break;
                            default:
                                s = CType.middle;
                                break;
                        }
                        break;
                    case CType.middle:
                        switch (c)
                        {
                            case '{':
                                break;
                            case '}':
                                cnt++;
                                s = CType.right;
                                break;
                            default:
                                //这里如果出现非数字应报错
                                break;
                        }
                        break;
                    case CType.right:
                        switch (c)
                        {
                            case '{':
                                s = CType.left;
                                break;
                            case '}':
                                s = CType.outC;
                                break;
                            default:
                                s = CType.outC;
                                break;
                        }
                        break;
                }

            }
            return cnt;
        }
    }
}