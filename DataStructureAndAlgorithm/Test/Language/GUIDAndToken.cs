using System;

using DataStructure;

namespace Test
{
  public class GUIDAndToken : BaseSolution
  {
    public void TestGUID()
    {
      Guid guid = Guid.NewGuid();
      string v = guid.ToString();
      string v1 = Convert.ToBase64String(guid.ToByteArray());

      println(v);
      println(v1);
    }
  }
}
