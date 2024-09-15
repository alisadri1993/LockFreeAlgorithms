namespace LockFreeAlgorithms.LockFreeTypes.DataStructures.MichaelScott;
public class MichaelScottQueueUsage
{
    public static void Use()
    {
        MichaelScottQueue<int> queue = new MichaelScottQueue<int>();
        Thread[] threads = new Thread[10];

        for (int i = 0; i < threads.Length; i++)
        {
            threads[i] = new Thread(() =>
            {
                for (int j = 0; j < 100; j++)
                {
                    queue.Enqueue(j);
                }
            });
            threads[i].Start();
        }

        foreach (Thread t in threads)
        {
            t.Join();
        }

        int result;
        while (queue.Dequeue(out result))
        {
            Console.WriteLine(result);
        }
    }
}
