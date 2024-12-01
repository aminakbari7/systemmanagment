using appdll.context;
using appdll.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appdll.Services
{
    public class RepositoryPersons : IRepositoryPersons
    {
        dbappEntities db;
        public RepositoryPersons(dbappEntities entities)
        {
            db = entities;

        }
        public async Task<bool> deleteAsync(int id)
        {

            try
            {
             Task.Run(()=>  db.delete_person(id));
                return true;
 
            }
            catch(Exception)
            {
                return false;
            }
        }

        public async Task<List<vwpersons>> GetAllPersonsAsync()
        {
            try
            {
               return await Task.Run(() => db.vwpersons.ToList());
               

            }
            catch (Exception)
            {
                return null;
            }
        }

        public Task<List<find_person_Result>> GetPersonsAsync(string search)
        {
            throw new NotImplementedException();
        }

        public Task<bool> insertAsync(string name, string family, string codm, string phone, string address)
        {
            throw new NotImplementedException();
        }

        public Task<bool> updateAsync(int id, string name, string family, string codm, string phone, string address)
        {
            throw new NotImplementedException();
        }
    }
}
