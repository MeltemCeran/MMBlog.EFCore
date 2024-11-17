using MMBlog.EFCore.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMBlog.EFCore.Entities.Concrete
{
    public class InstanceMerak : BaseEntity
    {
        public string MerakName { get; set; }
        public bool? IsSolved { get; set; } //Merak giderildi mi? 
    }
}
