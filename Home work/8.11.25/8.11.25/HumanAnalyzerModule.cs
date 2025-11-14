using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._11._25
{
    internal class HumanAnalyzerModule
    {
        static public void HumanOrderByGrade(Human[] humans)
        {
            for (int i = 0; i < humans.Length; i++)
            {
                for (int j = i + 1; j < humans.Length; j++)
                {
                    if (humans[i].Grade < humans[j].Grade)
                    {
                        Human temp = humans[i];
                        humans[i] = humans[j];
                        humans[j] = temp;
                    }
                }
            }

        }
    }
}
