using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncInterFace
{
    public class Task : ISyncable
    {
        private string desc;
        private uint day;
        private uint month;
        private uint year;
        private bool isDone;

        public Task(string desc, uint day, uint month, uint year)
        {
            this.desc = desc;
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public void SetDone(bool isDone)
        {
            this.isDone = isDone;
        }

        public string ItemType()
        {
            return "Task";
        }

        public string Encode()
        {
            return string.Format("{0}|{1}|{2}|{3}|{4}", desc, day, month, year, isDone ? "1" : "0");
        }

        public static void Decode(string str)
        {
            string[] strArray = str.Split("|");

            if(strArray.Length != 5)
            {
                Console.WriteLine("Input does not satisfy the requirement needed for decoding");
                return; //stop the method here
            }
            Console.WriteLine("Desc : {0}", strArray[0]);
            Console.WriteLine("Day : {0}", strArray[1]);
            Console.WriteLine("Month : {0}", strArray[2]);
            Console.WriteLine("Year : {0}", strArray[3]);
            Console.WriteLine("IsDone : {0}", strArray[4] == "1"? "Done" : "Not Done");

        }
    }
}
