using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5
{
    public class Person
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = "";
        public string Middlename { get; set; } = "";
        public string Surname { get; set; } = "";
        public DateTime BirthDate { get; set; } = DateTime.Today;
        public string Passport { get; set; } = "0000-000000";
        public string Phone { get; set; } = "8-(000)-123-12-12";


    }
}
