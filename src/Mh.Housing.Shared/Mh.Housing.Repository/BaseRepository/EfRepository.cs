using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mh.Housing.Repository.BaseRepository
{
    public class EfRepository<TEntity>
    {
        public PanPuContext _context;
        public EfRepository(string connectionString)
        {
            _context = new PanPuContext(connectionString);
        } 
    }
}
