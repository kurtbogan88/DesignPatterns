using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MememtoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Person
    {
        private string _name;
        private string _address;
        private int _id;
        private string _phone;
        private DateTime _lastEdit;

        public int Id { get { return _id; } set { _id = value; SetLasEdited();  } }
        public string Name { get { return _name; } set { _name = value; SetLasEdited(); } }
        public string Address { get { return _address; } set { _address = value; SetLasEdited(); } }
        public string Phone { get { return _phone; } set { _phone = value; SetLasEdited(); } }


        private void SetLasEdited()
        {
            _lastEdit = DateTime.Now;
        }
    }


}
