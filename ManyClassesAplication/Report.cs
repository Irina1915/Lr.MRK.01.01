using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyClassesAplication
{
    public class Report
    {
        private List<ReportRow> rows_ = new List<ReportRow>();
        public void AddRecord(ReportRow row)
        {
            rows_.Add(row);
        }
        public string ConvertReportToString(ReportRow row)
        {
            return row.Product + "; " + row.Quantity + "; " + row.Price;
        }
        public string ConvertAllToString()
        {
            if (rows_.Count == 0)
                return "Отчет пуст";
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Продукт; Количество; Цена");
            foreach (ReportRow row in rows_)
            {
                sb.AppendLine(ConvertReportToString(row));
            }
            return sb.ToString();
        }
        public override string ToString()
        {
            return ConvertAllToString();
        }
        public void CalculateSum()
        {
            double sum = 0;
            foreach (ReportRow row in rows_)
            {
                sum += row.Quantity * row.Price;
            }
            Console.WriteLine("Сумма: " + sum + "руб.");
        }
    }

}
