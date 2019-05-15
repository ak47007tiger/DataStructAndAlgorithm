namespace DataStructure
{
  public class InsertionSort
  {
    /*
    从后往前，像是拿一张扑克牌放到手里排序手里的牌
    认为第一张是排好序的，从后面那数值插入到排好序的序列里
     */
    public int[] Sort(int[] array)
    {
      for (int i = 1; i < array.Length; i++)
      {
        int temp = array[i];
        for (int j = i - 1; j >= 0; j--)
        {
          if (array[j] > temp)
          {
            array[j + 1] = array[j];
            array[j] = temp;
          }
          else
            break;
        }
      }
      return array;
    }
  }

}