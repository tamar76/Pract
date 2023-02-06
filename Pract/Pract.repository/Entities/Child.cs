using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pract.Repository.Entities
{
    public class Child
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("ParentId")]
        public int Parent { get; set; }
        public DateTime BirthDate { get; set; }
        public User ParentId { get; set;}
    }
}
