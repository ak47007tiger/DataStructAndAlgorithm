namespace DataStructure.Test
{
  public class TestLanguage
  {

  }

  /// <summary>
  /// what is default(class)
  /// </summary>
  public class TestClassDefault : BaseSolution
  {
    public void Test()
    {
      var defVal = default(TestClassDefault);
      println(defVal == null);
      println(defVal);
    }
  }


  public struct SomeData
  {
    public float a;
    public string b;
  }

  /// <summary>
  /// 验证传引用能不能改变struct的成员变量的值
  /// </summary>
  public class TestStructRef : BaseSolution
  {
    public void Output(ref SomeData data)
    {
      SomeData sd = new SomeData();
      sd.a = 1;
      sd.b = "hello";
      data = sd;
    }

    public void Test()
    {
      SomeData sd = new SomeData();
      sd.a = 0;
      sd.b = "b";
      Output(ref sd);
      println(sd.b);
    }
  }

}