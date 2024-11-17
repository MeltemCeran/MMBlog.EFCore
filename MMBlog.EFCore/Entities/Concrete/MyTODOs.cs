using MMBlog.EFCore.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMBlog.EFCore.Entities.Concrete
{
    public class MyTODOs : BaseEntity
    {
        //Tüm todolar checkbox olsun. o yüzden prop var. kaç todo bitirmişim sorgu. Başka sorgularda çıkar.
        public string toDoName { get; set; }
        public bool isUrgent { get; set; } //acil mi? uzunvadeli kısavadeli
        public bool? isDone { get; set; }

        //bunlar böyle paket olarak gelsin.
    }
}
