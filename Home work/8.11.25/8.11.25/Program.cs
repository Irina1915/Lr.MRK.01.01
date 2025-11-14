using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._11._25
{
    internal class Program
    {
            static void Main(string[] args)
            {
                Human[] humans = new Human[50];
                Random random = new Random();

                for (int i = 0; i < 50; i++)
                {
                    humans[i].Name = "Human" + (i + 1);
                    humans[i].Age = random.Next(15, 17);
                    humans[i].Grade = random.Next(3, 5) + random.NextDouble();
                }

                HumanAnalyzerModule.HumanOrderByGrade(humans);

                Console.WriteLine("26 лучших аттестатов:");

                for (int i = 0; i < 26; i++)
                {
                    Console.WriteLine($"{i + 1}. {humans[i].Name} - {humans[i].Grade:F1} баллов, {humans[i].Age} лет");
                }
            }
    }
}
