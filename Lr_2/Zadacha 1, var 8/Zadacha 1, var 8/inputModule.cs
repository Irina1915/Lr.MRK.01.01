using System.Collections.Generic;

namespace Zadacha_1__var_8
{
    public class inputModule
    {
        public (List<string>[], List<int>[] ) InputApplicantsByCenre()
        {
            List<string>[] applicantsBySpecialties = new List<string>[3];
            List<int>[] counts = new List<int>[3];

            //Заполняем абитуриентов по специальности программирование (НУЛЕВОЙ ИНДЕКС)
            applicantsBySpecialties[0].Add("Берёзкин Егор");
            counts[0].Add(4);

            applicantsBySpecialties[0].Add("Берёзкин Егор");
            counts[0].Add(4);

            applicantsBySpecialties[0].Add("Берёзкин Егор");
            counts[0].Add(4);

            applicantsBySpecialties[0].Add("Берёзкин Егор");
            counts[0].Add(4);

            applicantsBySpecialties[0].Add("Берёзкин Егор");
            counts[0].Add(4);

            return (applicantsBySpecialties, counts);
        }
    }
}
