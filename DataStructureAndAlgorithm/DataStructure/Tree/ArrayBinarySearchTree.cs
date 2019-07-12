using System;
namespace DataStructure
{
  /*
  数组实现的二叉查找树
  输入一个数组，获得一颗二叉查找树
  
  找parent 和 child index的数值规律
  0
  1,2
  3,4,5,6
  7,8,9,10,11,12,13,14
  15,16,17,18

  layer: 1,2,4,8
  次方：0,1,2,3

  得
  parent = (child - 1) / 2
  childRight = (parent + 1) * 2
  childLeft = (parent + 1) * 2 - 1

   */
  public class ArrayBinarySearchTree
  {
    TreeNode[] nodeArray;

    public ArrayBinarySearchTree(int[] values)
    {
      /*
      计算数组长度需要计算有多少层，然后把所有层的节点个数加起来
      假设每个节点除了根节点都是右孩子，极限情况，每层一个节点，这样计算出最多需要多大空间
       */
      nodeArray = new TreeNode[ComputeAllCount(values.Length)];
      for (var i = 0; i < values.Length; i++)
      {
        Insert(values[i]);
      }
    }

    public int Insert(int value)
    {
      return Insert(0, value);
    }

    public int Insert(int rootIndex, int value)
    {
      var node = nodeArray[rootIndex];
      if (nodeArray[rootIndex] == null)
      {
        nodeArray[rootIndex] = new TreeNode(value);
        return rootIndex;
      }

      if (value < nodeArray[rootIndex].val)
      {
        return Insert(GetLeftChildIndex(rootIndex), value);
      }
      else
      {
        return Insert(GetRightChildIndex(rootIndex), value);
      }
    }
    
    public TreeNode Find(int val)
    {
      return Find(0, val);
    }

    public TreeNode Find(int rootIndex, int value)
    {
      var node = nodeArray[rootIndex];
      if (node == null)
      {
        return null;
      }
      if(value == node.val){
        return node;
      }
      if (value < node.val)
      {
        return Find(GetLeftChildIndex(rootIndex), value);
      }
      else
      {
        return Find(GetRightChildIndex(rootIndex), value);
      }
    }

    public int FindIndex(int value){
      return FindIndex(0, value);
    }

    public int FindIndex(int rootIndex, int value){
      var node = nodeArray[rootIndex];
      if (node == null)
      {
        return -1;
      }
      if(value == node.val){
        return rootIndex;
      }
      if (value < node.val)
      {
        return FindIndex(GetLeftChildIndex(rootIndex), value);
      }
      else
      {
        return FindIndex(GetRightChildIndex(rootIndex), value);
      }
    }

    public static int GetLayerCount(int layer)
    {
      return (int)Math.Pow(2, layer - 1);
    }

    public static int ComputeAllCount(int layerCount)
    {
      var sum = 0;
      for (var i = 1; i <= layerCount; i++)
      {
        sum += GetLayerCount(i);
      }
      return sum;
    }

    public static int GetLeftChildIndex(int index)
    {
      return (index + 1) * 2 - 1;
    }

    public static int GetRightChildIndex(int index)
    {
      return (index + 1) * 2;
    }

    public static int GetParentIndex(int index)
    {
      return (index - 1) / 2;
    }
  }

}
