using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncInterFace
{
    public class Contact : ISyncable
    {
        private string name;
        private string mobile;
        private string email;

        public Contact(string name, string mobile, string email)
        {
            this.name = name;
            this.mobile = mobile;
            this.email = email;
        }

        public string ItemType()
        {
            return "Contact";
        }

        public string Encode()
        {
            return string.Format("{0}|{1}|{2}", name, mobile, email);
        }

        public static void Decode(string str)
        {
            string[] strArray = str.Split("|");

            if (strArray.Length != 3)
            {
                Console.WriteLine("Cannot decode the information for Contact");
                return;
            }

            Console.WriteLine("Name : {0}", strArray[0]);
            Console.WriteLine("Mobile : {0}", strArray[1]);
            Console.WriteLine("Email : {0}", strArray[2]);
        }
    }

}
