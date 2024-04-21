using System;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncInterFace
{
    public class SyncEngine
    {
        private List<ISyncable> calenderTypes;

        public SyncEngine()
        {
            calenderTypes = new List<ISyncable>();
        }
        public void Add(ISyncable syncable)
        {
            
            calenderTypes.Add(syncable);
        }

        public void DecodeSync()
        {
            foreach(ISyncable syncable in calenderTypes)
            {
                if(syncable is Task)
                {
                    Console.WriteLine("Decoding Task");
                    Task.Decode(syncable.Encode());
                    Console.WriteLine();
                }

                else if(syncable is Contact)
                {
                    Console.WriteLine("Decoding Contact");
                    Contact.Decode(syncable.Encode());
                    Console.WriteLine();
                }

                else
                {
                    Console.WriteLine("Cannot decode");
                }

            }
        }
    }

}
