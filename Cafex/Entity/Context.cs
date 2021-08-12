using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace Cafex.Entity
{
    public class Context : DbContext
    {
        public DbSet<Musteri> Musteris { get; set; }
    }
}
