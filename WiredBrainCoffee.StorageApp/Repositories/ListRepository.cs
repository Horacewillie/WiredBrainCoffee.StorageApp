using System;
using System.Collections.Generic;
using System.Linq;
using WiredBrainCoffee.StorageApp.Entities;

namespace WiredBrainCoffee.StorageApp.Repositories
{
    //A value or reference type can implement and interface
    public class ListRepository<T> : IRepository<T> where T :  IEntityBase, new()
    {
        //public Tkey? Key { get; set; } A generic class can have more than one paramter.
        private readonly List<T> _items;

        public ListRepository()
        {
            _items = new();
        }

        //The type must have a parameterless constructor, to ensure this add the new constraint
        public T CreateItem()
        {
            return new T();
        }

        //Its directly not possible to access
        //the property on a Generic class except by using Type Constraints

        public T GetById(int id)
        {
            //return default;
            //return null; //Because T can be either a reference or value type, and a value type cannot be nullable
                         //we need to be explicit about the type or return default instead of null
            return _items.Single(item => item.Id == id);
        }

        public void Add(T item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);
        }

        public void Remove(T item)
        {
            _items.Remove(item);
        }


        public void Save()
        {
            foreach (T item in _items)
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                Console.WriteLine(item.ToString());
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            }
        }
    }

}
