using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DatasetService.Interfaces
{
    public interface IFetchData<T>
    {
        Task<T> GetDataFromWeb();

        Task<int> InsertBulkData(T lstData);
    }
}
