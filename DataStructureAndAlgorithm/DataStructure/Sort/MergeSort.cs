namespace DataStructure {

  public class MergeSort {

    public int[] Sort(int[] array) {
      return Sort(array,0, array.Length);
    }

    public int[] Sort(int[] array, int from, int to) {
      if (from < to) {
        var mid = (from + to) / 2;
        Sort(array, from, mid);
        Sort(array, mid + 1, to);
        Merge(array, from, mid, to);
      }
      return array;
    }

    public void Merge(int[] array, int from, int mid, int to) {
      var tempArray = new int[to - from];
      
    }

  }

}