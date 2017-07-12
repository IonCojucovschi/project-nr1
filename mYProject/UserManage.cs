using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mYProject
{
    class UserManage:User
    {
        public int ID { get; set; }
        public String FullName { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }
        public UserManage(int? ID, String Name, int? Age, String Password) {
            int? a = null;
            int? b = null;
            if(a==ID | b== Age) { throw new Exception("Introduce every parametter for this Constructor!"); }
        }

    }
   interface User
    {
       int ID { get; set; }
        string FullName { get; set; }
        int Age { get; set; }
        string Password { get; set; }

    }











}
