using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._11._25
{
    internal class Functions
    {
        static public double CalcSaleCost(Sale_of_phones Phone) // Стоимость проданных телефонов
        {
            double salePrice = Phone.Quantity * Phone.Price;
            return salePrice;
        }
        static public double FindSalesPrice(List<Sale_of_phones> Phone, DateTime startDate, DateTime endDate)
        {
            double salesPrice = 0;
            foreach (Sale_of_phones sale in Phone)
            {
                if (sale.Date >= startDate && sale.Date <= endDate)
                {
                    salesPrice += Functions.CalcSaleCost(sale);
                }
            }
            return salesPrice;
        }
        static private Dictionary<string, int> PrepareSalesCountByPhone(List<Sale_of_phones> Phone)
        {
            Dictionary<string, int> result = new Dictionary<string, int>();
            foreach (Sale_of_phones sale in Phone)
            {
                string phone = sale.PhoneModel;
                if (result.ContainsKey(phone))
                {
                    result[phone] += sale.Quantity;
                }
                else
                {
                    result.Add(phone, sale.Quantity);
                }
            }
            return result;
        }
        static public string FindBestPhoneModel(List<Sale_of_phones> Phone)
        {
            if (Phone.Count == 0)
            {
                return string.Empty;
            }
            Dictionary<string, int> countSalesByPhone = PrepareSalesCountByPhone(Phone);
            string result = string.Empty;
            int maxCount = countSalesByPhone.Values.First();
            foreach (string phone in countSalesByPhone.Keys)
            {
                int currentCountPhone = countSalesByPhone[phone];
                if (currentCountPhone > maxCount)
                {
                    maxCount = currentCountPhone;
                    result = phone;
                }
            }
            return result;
        }
        static public string FindWorstPhoneModel(List<Sale_of_phones> Phone)
        {
            if (Phone.Count == 0)
            {
                return string.Empty;
            }
            Dictionary<string, int> countSalesByPhone = PrepareSalesCountByPhone(Phone);
            string result = string.Empty;
            int minCount = countSalesByPhone.Values.First();
            foreach (string phone in countSalesByPhone.Keys)
            {
                int currentCountPhone = countSalesByPhone[phone];
                if (currentCountPhone < minCount)
                {
                    minCount = currentCountPhone;
                    result = phone;
                }
            }
            return result;
        }
        static public string[] FindProfitablePhones(List<Sale_of_phones> Phone)
        {
            // Создаем словарь для хранения общей выручки по каждой модели
            Dictionary<string, double> revenueByPhone = new Dictionary<string, double>();
            foreach (Sale_of_phones sale in Phone)
            {
                string phoneModel = sale.PhoneModel;
                double revenue = sale.Revenue;
                if (revenueByPhone.ContainsKey(phoneModel))
                {
                    revenueByPhone[phoneModel] += revenue;
                }
                else
                {
                    revenueByPhone.Add(phoneModel, revenue);
                }
            }
            // Сортируем модели по убыванию выручки и берем две лучшие
            IOrderedEnumerable<KeyValuePair<string, double>> sortedPhones = revenueByPhone.OrderByDescending(x => x.Value);
            KeyValuePair<string, double>[] topPhones = sortedPhones.Take(2).ToArray();
            string[] result = new string[2];
            if (topPhones.Length >= 1)
                result[0] = topPhones[0].Key;
            if (topPhones.Length >= 2)
                result[1] = topPhones[1].Key;
            return result;
        }
    }
}
