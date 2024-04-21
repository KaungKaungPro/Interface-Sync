using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncInterFace
{
    public interface ISyncable
    {
        string ItemType();
        string Encode();
    }
}
