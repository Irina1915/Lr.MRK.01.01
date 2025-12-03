using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2._1
{
    // Это как "правило" - все кто дает данные должны иметь метод "ПолучитьДанные"
    public interface IDataService
    {
        string FetchData(string resourceId);
    }
}
