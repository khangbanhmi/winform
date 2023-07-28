using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    class Subject
    {
        private string _idsub;
        private string _namesub;

        public Subject()
        {

        }

        public Subject(string idsub, string namesub)
        {
            _idsub = idsub;
            _namesub = namesub;
        }

        public string Idsub { get => _idsub; set => _idsub = value; }
        public string Namesub { get => _namesub; set => _namesub = value; }

    }
}
