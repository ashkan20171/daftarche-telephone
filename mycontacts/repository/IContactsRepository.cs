using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace mycontacts
{
    interface IContactsRepository
    {
        DataTable selectAll();
        DataTable selectRow(int contactId);
        bool insert(string name, string family, string mobile, string email, int age, string address);
        bool update(int contactId, string name, string family, string mobile, string email, int age, string address);

        bool delete(int contactId);

    }
}
