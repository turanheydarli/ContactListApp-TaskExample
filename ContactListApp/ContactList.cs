using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListApp
{
    class ContactList
    {
        Dictionary<string, string> _contactList = new Dictionary<string, string>();

        public string GetNumber(string name)
        {
            return _contactList[name];
        }

        public void AddNumber(string name, string number)
        {
            _contactList.Add(number, name);
        }

        public void RemoveNumber(string name)
        {
            _contactList.Remove(name);
        }
    }
}
