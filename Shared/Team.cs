using System;
using System.Collections.Generic; 

namespace BlazorApp.Shared
{
    public class Team
    {
        public string Name { get; set; }

        public Owner TeamOwner { get; set; }

        public int Budget { get; set; }

        // This is my initial thought on how to store the team roster. Basically, create a Dictionary with unique strings for each position, and a player object.  
        // This may change at some point in the future if I don't want to have unique position names like SEC1 and SEC2 and just want to have two SEC positions.
        public Dictionary<string, Player> Roster { get; set; } 
    }
}
