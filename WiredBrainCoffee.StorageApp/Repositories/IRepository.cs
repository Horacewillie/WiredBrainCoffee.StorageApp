using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repositories
{
    //An abstraction
    public interface IRepository<T> where T : IEntityBase
    {
        void Add(T item);

        void Remove(T item);

        void Save();

        T GetById(int id);

        T CreateItem();
    }
}
