namespace DataStructure
{
    public class BubbleSort
    {

        public int[] Sort(int[] array)
        {
            for (var i = 0; i < array.Length - 1; i++)
            {
                for (var j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }

        public int[] Sort(int[] array, int start, int end)
        {

            return array;
        }
    }
}