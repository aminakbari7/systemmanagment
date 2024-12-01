using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appdll.context
{
    public class UnitOfWork : IDisposable
    {
        private dbappEntities db=new dbappEntities();
        private IRepositoryPersons RepositoryPersons;
        public IRepositoryPersons RepositoryPersons()
        {
            if(RepositoryPersons==null)
            {
                RepositoryPersons = new IRepositoryPersons(db);
            }
            return RepositoryPersons;

        }
        public void Dispose()
        {
            
           db.Dispose();
        }
    }
}
