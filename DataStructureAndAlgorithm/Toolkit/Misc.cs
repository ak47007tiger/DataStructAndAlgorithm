namespace DataStructure.Toolkit
{
  public class Misc
  {

    /// <summary>
    /// 
    /// /// </summary>
    /// <param name="c"></param>
    /// <returns></returns>
    public static bool IsChinese(char c)
    {
      return 0x4e00 <= c && c <= 0x9fbb;
    }
  }
}