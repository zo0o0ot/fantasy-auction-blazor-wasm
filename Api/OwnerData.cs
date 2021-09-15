using BlazorApp.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api
{
    public interface IOwnerData
    {
        Task<Owner> AddOwner(Owner Owner);
        Task<bool> DeleteOwner(int ID);
        Task<IEnumerable<Owner>> GetOwners();
        Task<Owner> UpdateOwner(Owner Owner);
    }

    public class OwnerData : IOwnerData
    {
        private readonly List<Owner> Owners = new List<Owner>
        {
            new Owner
            {
                ID = 10,
                OwnerName = "Ross",
            },
            new Owner
            {
                ID = 20,
                OwnerName = "Jawad"
            },
            new Owner
            {
                ID = 30,
                OwnerName = "Jared"
            },
            new Owner
            {
                ID = 40,
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
            Owner.ID = GetRandomInt();
            Owners.Add(Owner);
            return Task.FromResult(Owner);
        }

        public Task<Owner> UpdateOwner(Owner Owner)
        {
            var index = Owners.FindIndex(p => p.ID == Owner.ID);
            Owners[index] = Owner;
            return Task.FromResult(Owner);
        }

        public Task<bool> DeleteOwner(int ID)
        {
            var index = Owners.FindIndex(p => p.ID == ID);
            Owners.RemoveAt(index);
            return Task.FromResult(true);
        }

        public Task<IEnumerable<Owner>> GetOwners()
        {
            return Task.FromResult(Owners.AsEnumerable());
        }
    }
}