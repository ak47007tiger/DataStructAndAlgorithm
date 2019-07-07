namespace DataStructure
{
  public class InsertionSort
  {
    /*
    形象的说法：
    从后往前排序，过程像是拿一张扑克牌放到手里最后一个位置，然后排序手里的牌

    抽象的说法：
    认为第一张是排好序的，从后面没有排序的数据中拿第一个出来插入到排好序的序列里
     */
    public int[] Sort(int[] array)
    {
      for (int i = 1; i < array.Length; i++)
      {
        //从没有排序的区域拿第一个
        int temp = array[i];
        //和已经排好序的区域从后往前比较
        for (int j = i - 1; j >= 0; j--)
        {
          //如果拿来的值比较小，交换，直到所有比该值大的数都往后移动了一个位置，要插入的数已经放入第一个空位上
          if (array[j] > temp)
          {
            array[j + 1] = array[j];
            array[j] = temp;
          }
          //已经排序的区域找不到更大的数值，此时该数已经找到自己的位置
          else
            break;
        }
      }
      return array;
    }
  }

}