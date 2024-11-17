using MMBlog.EFCore.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMBlog.EFCore.Entities.Concrete
{
    public class Page6AllQAs : BaseEntity
    {
        public string questionName { get; set; } //Burda bi normalizasyan gerekebilir questionNameler çok tekrar edecek çünkü.
        public string answerName { get; set; }
    }
}
