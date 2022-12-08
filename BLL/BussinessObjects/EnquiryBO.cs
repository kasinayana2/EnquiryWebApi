using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BussinessObjects
{
    public class EnquiryBO
    {
        public int Id { get; set; }

        public string FristName { get; set; }

        public string LastName { get; set; }

        public int? Age { get; set; }

        public string Address { get; set; }
    }
}
