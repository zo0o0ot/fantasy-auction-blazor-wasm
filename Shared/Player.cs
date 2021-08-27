using System;

namespace BlazorApp.Shared
{
    public class Player
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Position { get; set; }

        public bool PlayerSelected { get; set; } 

        // This is my initial thought on how to store the appropriate data, I want to store the name of the stat and the value of the stat. 
        // Example: {"Potential Points", 81},
        // {"Number of Prospects", 6}
        public Dictionary<string, int> Stats { get; set; } 

        
    }
}
