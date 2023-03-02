using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract.common.DTO_s
{
    public  class UserDTO
    {
        public int Id { get; set; }
        public string Identity { get; set; }
        public string ParentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string MaleOrFemale { get; set; }
        public string  HMO { get; set; }
    }

}
