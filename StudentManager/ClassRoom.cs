using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager
{
    class ClassRoom
    {
       private string _idclass;
       private string _nameclass;
       
       public ClassRoom()
        {

        }

        public ClassRoom(string idclass, string nameclass)
        {
            _idclass = idclass;
            _nameclass = nameclass;
        }

        public string Idclass { get => _idclass; set => _idclass = value; }
        public string Nameclass { get => _nameclass; set => _nameclass = value; }

    }
}
