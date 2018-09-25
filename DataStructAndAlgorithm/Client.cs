using System;
using System.Collections;
using System.Collections.Generic;
using DataStruct.Toolkit;
using LeetCode.Easy;
using LeetCode.Hard;
using LeetCode.Medium;
using NiuKeWang;

namespace DataStruct {
  public class Client : BaseSolution {
    public static void Work(string[] args) {
      var root = BinaryTreeToolkit.BuildBinarySearchTree(new int[]{
        5,3,2,4,7,6,8
      });
      new BreadthFirstTravelTree().Travel1(root);
      Console.ReadKey();
    }
  }
}