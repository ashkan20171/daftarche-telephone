using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace mycontacts
{
    class ContactsRepository : IContactsRepository
    {

        private string ConnectionString = "Data Source=.;Initial Catalog=Contact_DB;Integrated security=true ";
        public bool delete(int contactId)
        {
            throw new NotImplementedException();
        }

        public bool insert(string name, string family, string mobile, string email, int age, string address)
        {
            throw new NotImplementedException();
        }
        public DataTable selectRow(int contactId)
        {
            throw new NotImplementedException();
        }
        public DataTable selectAll()
        {
            string query = "select * from MyContacts";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public bool update(int contactId, string name, string family, string mobile, string email, int age, string address)
        {
            throw new NotImplementedException();
        }
    }
}
