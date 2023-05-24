using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beconsult.DataAccessLayer
{
    public interface IFichas
    {
        List<Ficha> GetAllFichas();
        Ficha GetFicha(int id);
    }
}
