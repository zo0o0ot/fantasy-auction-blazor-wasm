using System;

namespace BlazorApp.Shared
{
    public class Owner
    {
        public int ID { get; set; }

        public string OwnerName { get; set; }

        // There may be more information here in the future, or at least a way to link different drafts to owners.
    }
}
