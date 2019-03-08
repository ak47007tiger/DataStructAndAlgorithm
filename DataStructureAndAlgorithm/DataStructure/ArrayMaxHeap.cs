using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure {

  public class ArrayMaxHeap {
    int[] array;
    int size;
    int maxSize;

    public void Build(int maxSize) {
      array = new int[maxSize];
      this.maxSize = maxSize;
      size = 0;
    }

    public int GetSize() {
      return size;
    }

    public int GetMaxSize() {
      return maxSize;
    }

    public void Insert(int value) {
      if (size == maxSize) {
        throw new Exception("size must <= max size");
      }
      array[size] = value;
      size++;
      Update(size - 1);
    }

    void Update(int index) {
      if (index == 0)return;
      if (index < 0)throw new ArgumentException("index must >= 0");
      if (array[index] > array[ParentIndex(index)]) {
        Swape(index, ParentIndex(index));
        Update(ParentIndex(index));
      }
    }

    public int LeftChildIndex(int index) {
      return index * 2 + 1;
    }

    public int RightChildIndex(int index) {
      return index * 2 + 2;
    }

    public int ParentIndex(int index) {
      return (index - 1) / 2;
    }

    public bool IsLeaf(int index) {
      return !IsInHeap(LeftChildIndex(index));
    }

    public bool IsInHeap(int index) {
      return 0 <= index && index < size;
    }

    private void Swape(int index1, int index2) {
      var temp = array[index1];
      array[index1] = array[index2];
      array[index2] = temp;
    }

    public int GetTop() {
      return array[0];
    }

    void Heapify(int index) {
      if (IsLeaf(index)) {
        return;
      }
      if (array[LeftChildIndex(index)] > array[RightChildIndex(index)]) {
        if (array[index] < array[LeftChildIndex(index)]) {
          Swape(index, LeftChildIndex(index));
          Heapify(LeftChildIndex(index));
        }
      } else if (array[index] < array[RightChildIndex(index)]) {
        Swape(index, RightChildIndex(index));
        Heapify(RightChildIndex(index));
      }

    }

    public int RemoveTop() {
      if (size == 0)throw new Exception("no element in heap");
      var top = array[0];
      array[0] = array[size - 1];
      size--;
      Heapify(0);
      return top;
    }

  }

}