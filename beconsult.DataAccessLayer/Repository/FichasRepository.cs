using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beconsult.DataAccessLayer
{
    public class FichasRepository: IFichas
    {
        List<Ficha> lisFichas = new()
        {
            new Ficha{Id=1, Nombre="Franklin", Nombre1="Alfredo", Apellido="Duque", Apellido1="Ramirez"},
            new Ficha{Id=2, Nombre="Emily", Nombre1="Daliana", Apellido="Duque", Apellido1="Barrios"},
            new Ficha{Id=3, Nombre="Katiuska", Nombre1="Carolina", Apellido="Duque", Apellido1="Barrios"},
        };

        public List<Ficha> GetAllFichas()
        {
            return lisFichas;
        }

        public Ficha GetFicha(int id)
        {
            return lisFichas.FirstOrDefault(x => x.Id == id);
        }
    }
}
