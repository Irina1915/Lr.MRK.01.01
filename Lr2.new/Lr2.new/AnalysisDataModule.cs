using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lr2new
{
    internal class AnalysisDataModule
    {
        public void SortTovars(List<string> tovars, List<int> counts)
        {
            for (int i = 0; i < counts.Count; ++i)
            {
                for(int j = 0; j < counts.Count - 1; ++j)
                {
                    bool condition = counts[j + 1] > counts[j];
                    if (condition)
                    {
                        int temp_counts = counts[j];
                        counts[j] = counts[j + 1];
                        counts[j + 1] = temp_counts;

                        string temp_tovars = tovars[j];
                        tovars[j] = tovars[j + 1];
                        tovars[j + 1] = temp_tovars;
                    }
                }
            } 
        }

        public double CalculateAverage(List<int> counts)
        {
            int sum = 0;
            foreach (int count in counts)
            {
                sum += count;
            }

            return sum / counts.Count;
        }
    }
}
