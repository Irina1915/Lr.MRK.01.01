using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lr2new
{
    internal class SearchingModule
    {
        static public int FindIndexKatalog(string userQuery, string[] katalog)
        {
            for (int index = 0; index < katalog.Length; ++index)
            {
                string valueKatalog = katalog[index].ToLower();
                if (valueKatalog == userQuery.ToLower())
                {
                    return index;
                }
            }

            return -1;
        }
        static public (List<string>, List<int>) FindAllTovarsByKatalog(int indexkatalog,
                                                             List<string>[] allKatalog,
                                                             List<int>[] counts)
        {
            List<string> TovarsByKatalog = new List<string>();
            List<int> countsByKatalog = new List<int>();

            TovarsByKatalog = allKatalog[indexkatalog];
            countsByKatalog = counts[indexkatalog];

            return (TovarsByKatalog, countsByKatalog);
        }
    }
}
