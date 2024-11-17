using Microsoft.EntityFrameworkCore;
using MMBlog.EFCore.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMBlog.EFCore.Context
{
    public class MBlogDbContext : DbContext
    {
        public DbSet<Page3CheckBox> _page3CheckBoxes { get; set; }
        public DbSet<Page6AllQAs> _page6AllQAs { get; set; }
        public DbSet<MusicList> _musicList { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LAPTOP-3HH2461E;Database=MBlogDb;Trusted_Connection=true;Trustservercertificate=true");
        }
    }
}
