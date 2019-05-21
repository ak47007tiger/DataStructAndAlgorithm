using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace DataStructure.Toolkit
{

  public static class MathEx
  {

    public static int Max(int[] array)
    {
      var val = array[0];
      for (var i = 1; i < array.Length; i++)
      {
        val = System.Math.Max(val, array[i]);
      }
      return val;
    }

    public static int Min(int[] array)
    {
      var val = array[0];
      for (var i = 1; i < array.Length; i++)
      {
        val = System.Math.Min(val, array[i]);
      }
      return val;
    }

  }

}