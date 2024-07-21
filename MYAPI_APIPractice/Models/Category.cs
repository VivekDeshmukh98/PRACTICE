using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MYAPI_APIPractice.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //one to many Relationship
        public ICollection<Product> Products { get; set; }
    }
}
