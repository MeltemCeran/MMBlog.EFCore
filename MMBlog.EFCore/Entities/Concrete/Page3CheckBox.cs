using MMBlog.EFCore.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMBlog.EFCore.Entities.Concrete
{
    public class Page3CheckBox : BaseEntity
    {
        public string cBoxName { get; set; }
        public int Counter { get; set; } //ne kadar tıklandı?
    }
}
