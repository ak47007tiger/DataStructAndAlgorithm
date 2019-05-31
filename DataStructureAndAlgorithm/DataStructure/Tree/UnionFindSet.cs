namespace DataStructure
{

  /*
  并查集的rank合并
  1 初始 rank都为0
  2 合并导致rank不同
  3 rank越大越容易成为father
  作用
  减少寻找祖先的时间
  如果没有路径压缩 按照rank合并的优化作用就体现出来了
   */

  public class UnionFindSet
  {
    private int[] fathers;
    private int[] ranks;
    public void Init(int[] array)
    {
      this.fathers = array;
      ranks = new int[array.Length];
    }

    public void Union(int x, int y)
    {
      //也可以反过来
      fathers[GetFather(y)] = GetFather(x);
    }

    public void RankUnion(int x, int y)
    {
      int fx = GetFather(x);
      int fy = GetFather(y);
      if (ranks[x] > ranks[y])
      {

        fathers[fy] = fx;
      }
      else
      {
        fathers[fx] = fy;
        if (ranks[fx] == ranks[fy])
        {
          ranks[fy]++;
        }
      }
    }

    public bool Same(int x, int y)
    {
      return GetFather(x) == GetFather(y);
    }

    public int GetFather(int x)
    {
      if (fathers[x] == x)
      {
        return x;
      }
      var father = GetFather(fathers[x]);
      //路径压缩 使下一次更快的找到x的father
      fathers[x] = father;
      return father;
    }

    public int GetFatherNoRecusive(int x)
    {
      //找祖先
      var p = x;
      while (p != fathers[p])
      {
        p = fathers[p];
      }
      //对那条链上的节点，改其father为p
      /*
      找到一个上层节点 找到其当前父节点 更换父节点
       */
      var p2 = x;
      int temp;
      while (p2 != p)
      {
        temp = fathers[p2];
        fathers[p2] = p;
        p2 = temp;
      }
      return p;
    }

  }

}
