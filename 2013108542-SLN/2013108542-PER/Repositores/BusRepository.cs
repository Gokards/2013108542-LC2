using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2013108542_PER.Repositores
{
    public class AsientoRepository : Repository<Asiento>, IAsientoRepository
    {
        public AsientoRepository(EnsambladoraDbContext context) : base(context)
        {

        }

    }
}
