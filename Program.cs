using System.Net.NetworkInformation;

namespace SyncInterFace
{
    public class Program
    {
        static void Main(string[] args)
        {
            SyncEngine engine = new SyncEngine();
            engine.Add(new Task("Go to meet ghi", 2, 3, 2024));
            engine.Add(new Contact("Go to DEF", "86213633", "thet@.com"));

            Task task = new Task("Go to meet abc", 3, 3, 2024);
            task.SetDone(true);
            engine.Add(task);

            engine.DecodeSync();

        }
    }
}
