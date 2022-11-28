using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinningRoomApp.model
{
    internal interface DAOEntity<T>
    {
        public T find(int id);

        public void save(T entity);

        public void delete(int id);
    }
}
