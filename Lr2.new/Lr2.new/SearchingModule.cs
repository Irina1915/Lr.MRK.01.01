using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lr2new
{
    public class SearchingModule
    {
        static public int FindIndexGenre(string userQuery, string[] genres)
        {
            for(int index = 0; index < genres.Length; index++)
            {
                string valueGenre = genres[index];
                if(valueGenre == userQuery)
                {
                    return index;
                }
            }

            return -1;
        }

        static public (List<string>, List<int>) FindAllTovarsByCenre(int indexGenre, List<string>[] allTovars, List<int>[] counts)
        {
            List<string> tovarsByGenre = new List<string>();
            List<int> countsByGenre = new List<int>();

            tovarsByGenre = allTovars[indexGenre];
            countsByGenre = counts[indexGenre];

            return (tovarsByGenre, countsByGenre);
        }
    }
}
