using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiredBrainCoffee.StorageApp.Entities
{
    public class Organisation : EntityBase
    {

        public string? Name { get; set; }

        public override string ToString() => $"Id: {Id}, Name: {Name} ";
    }
}
