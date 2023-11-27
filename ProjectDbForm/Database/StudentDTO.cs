using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Database
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
    }
}
