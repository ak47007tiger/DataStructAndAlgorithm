namespace DataStructure
{
    public class ArrayQueueTest : BaseSolution
    {
        public void Test()
        {
            var queue = new ArrayQueue<int>(4);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            // println(queue.Capicity);
            // println(queue.Count);

            println(queue.Dequeue());
            queue.Enqueue(5);

            while (!queue.IsEmpty)
            {
                println(queue.Dequeue());
            }
        }
    }
}