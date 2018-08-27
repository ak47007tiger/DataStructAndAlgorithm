using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Main.Toolkit {
  class Converter {
    public int ToInteger(int[] array) {
      int r = 0;
      for (int i = 0; i < 31; i++)
        r += (array[i] << i);
      if (array[31] == 1)
        return -r;
      return r;
    }

    public int[] ToArray(int x) {
      int[] array = new int[32];
      for (int i = 0; i < 32; i++)
        array[i] = (x >> i) & 0x1;
      return array;
    }

    public int[] Reverse(int[] array, int low, int high) {
      int temp = array[low];
      while (low < high) {
        temp = array[low];
        array[low] = array[high];
        array[high] = temp;
        low++;
        high--;
      }
      return array;
    }
  }
}