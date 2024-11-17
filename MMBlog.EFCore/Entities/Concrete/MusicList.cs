using MMBlog.EFCore.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMBlog.EFCore.Entities.Concrete
{
    public class MusicList : BaseEntity
    {
        //TODO:
        /*
         Sitede her sayfaya müzik ekleme butonu koyabilirim ve hangi sayfadan olursa olsun eklenen müzikler bu tabloda toplansın.
        */

        public string? SongName { get; set; }
        public string? Artist { get; set; }
        public string Link { get; set; }

        // sınıfları tek tek oluşturup migration atmayı unuttum. olsun. hallederiz. 
    }
}
