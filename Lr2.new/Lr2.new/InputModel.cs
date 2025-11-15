using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr2new
{
    internal class InputModel
    {
        public (List<string>[], List<int>[]) InputTovarsByCenre()
        {
            List<string>[] tovarsByKategoria = new List<string>[2];
            List<int>[] counts = new List<int>[2];

            //Заполняем товар по категориям (НУЛЕВОЙ ИНДЕКС)
            tovarsByKategoria[0].Add("");
            counts[0].Add(3);

            tovarsByKategoria[0].Add("");
            counts[0].Add(2);

            tovarsByKategoria[0].Add("");
            counts[0].Add(1);

            tovarsByKategoria[0].Add("");
            counts[0].Add(0);

            return (tovarsByKategoria, counts);
        }

        private static object GetApplicantsBySpecialties()
        {
            return applicantsBySpecialties;
        }
    }
}
