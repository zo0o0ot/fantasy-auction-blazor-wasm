using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api
{
    public interface IOwnerData
    {
        Task<Owner> AddOwner(Owner Owner);
        Task<bool> DeleteOwner(int id);
        Task<IEnumerable<Owner>> GetOwners();
        Task<Owner> UpdateOwner(Owner Owner);
    }

    public class OwnerData : IOwnerData
    {
        private readonly List<Owner> Owners = new List<Owner>
        {
            new Owner
            {
                Id = 10,
                OwnerName = "Ross",
            },
            new Owner
            {
                Id = 20,
                OwnerName = "Jawad"
            },
            new Owner
            {
                Id = 30,
                OwnerName = "Jared"
            },
            new Owner
            {
                Id = 40,
                OwnerName = "Tilo"
            }
        };

        private int GetRandomInt()
        {
            var random = new Random();
            return random.Next(100, 1000);
        }

        public Task<Owner> AddOwner(Owner Owner)
        {
            Owner.Id = GetRandomInt();
            Owners.Add(Owner);
            return Task.FromResult(Owner);
        }

        public Task<Owner> UpdateOwner(Owner Owner)
        {
            var index = Owners.FindIndex(p => p.Id == Owner.Id);
            Owners[index] = Owner;
            return Task.FromResult(Owner);
        }

        public Task<bool> DeleteOwner(int id)
        {
            var index = Owners.FindIndex(p => p.Id == id);
            Owners.RemoveAt(index);
            return Task.FromResult(true);
        }

        public Task<IEnumerable<Owner>> GetOwners()
        {
            return Task.FromResult(Owners.AsEnumerable());
        }
    }
}