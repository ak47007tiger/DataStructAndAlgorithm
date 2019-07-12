using System.Collections.Generic;
namespace DataStructure
{
  // class T12{
  //   public int v;
  //   public T12(int val){
  //     v = val;
  //   }
  // }
  public class LinkedUndigraphTest : BaseSolution
  {
    public void Test1()
    {
      // var set = new HashSet<int>(new int[]{1,2,3});
      var set = new HashSet<string>(new[] { "1", "2", "3" });
      // var set = new HashSet<T12>(new []{new T12(1),new T12(2),new T12(3)});
      var enumerator = set.GetEnumerator();
      println(enumerator.Current == null);
      while (enumerator.MoveNext())
      {
        println(enumerator.Current);
      }
    }

    public void Test()
    {
      var graph = new LinkedUndigraph();
      graph.Create(new int[][]{
        new int[]{1,2},
        new int[]{1,3},
        new int[]{1,4},

        new int[]{2,3},
        new int[]{2,5},

        new int[]{3,4},

        new int[]{4,5},
        });
      
      graph.Print();

      println("-----------------------");

      graph.Add(1,5);
      graph.Add(1,6);
      graph.Add(7,8);

      graph.Print();
    }
  }
}