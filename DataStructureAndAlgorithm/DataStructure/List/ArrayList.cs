namespace DataStructure
{
  /*
  顺序表，一种常见的顺序存储结构
   */
  public class ArrayList<T>
  {
    private T[] memory;
    private int _size;

    public ArrayList(int capacity)
    {
      memory = new T[capacity];
      _size = 0;
    }

    public void Add(T val)
    {
      memory[Size()] = val;
      _size++;
    }

    public void Add(int index, T val)
    {
      for (var i = Size(); i > index; i--)
      {
        Set(i, Get(i - 1));
      }
      Set(index, val);
      _size++;
    }

    public int IndexOf(T val)
    {
      for (var i = 0; i < Size(); i++)
      {
        if (Get(i).Equals(val))
        {
          return i;
        }
      }
      return -1;
    }

    public void Remove(T val)
    {
      RemoveAt(IndexOf(val));
    }

    public void RemoveAt(int index)
    {
      for (var i = index + 1; i < Size(); i++)
      {
        Set(i - 1, memory[i]);
      }
      _size--;
    }

    public T this [int i]
    {
      get { return Get(i); }
      // set { Set(i, value); }
    }

    public T Get(int index)
    {
      return memory[index];
    }

    public void Set(int index, T val)
    {
      memory[index] = val;
    }

    public int Size()
    {
      return _size;
    }

    public bool IsEmpty()
    {
      return Size() == 0;
    }

    public void Clear()
    {
      _size = 0;
    }
  }
}
