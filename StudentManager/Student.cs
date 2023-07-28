using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    class Student
    {
        private string _id;
        private string _name;
        private string _sex;
        private DateTime _date;
        private string _address;
        private string _phonenumber;

        public Student()
        {

        }

        public Student(string id, string name, string sex, DateTime date, string address, string phonenumber)
        {
            _id = id;
            _name = name;
            _sex = sex;
            _date = date;
            _address = address;
            _phonenumber = phonenumber;
        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Sex { get => _sex; set => _sex = value; }
        public DateTime Date{ get => _date; set => _date = value; }
        public string Address { get => _address; set => _address = value; }
        public string Phonenumber { get => _phonenumber; set => _phonenumber = value; }


    }
}
