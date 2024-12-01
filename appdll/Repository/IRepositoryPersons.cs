using appdll.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appdll.Repository
{
    public interface IRepositoryPersons
    {
       Task<List<vwpersons>> GetAllPersonsAsync();

       Task<List<find_person_Result>> GetPersonsAsync(string search);
        Task<bool> insertAsync( string name, string family, string codm, string phone, string address);
        Task<bool> updateAsync(int id,string name,string family,string codm,string phone,string address);
        Task<bool> deleteAsync(int id);


    }
}
