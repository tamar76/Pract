using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract.common.DTO_s
{
    public class ChildDTO
    {  public int Id { get; set; }    
        public string Name { get; set; }
        [ForeignKey("ParentId")]
        public int Parent { get; set; }
        public DateTime BirthDate { get; set; }
        public UserDTO ParentId { get; set; }
    }
}
