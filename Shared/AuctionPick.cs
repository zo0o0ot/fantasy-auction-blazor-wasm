using System;

namespace BlazorApp.Shared
{
    public class AuctionPick
    {
        public int PickNumber { get; set; }

        public Owner Suggester { get; set; }

        public Player SelectedPlayer { get; set; }

        public int WinningBid { get; set; }

        public Owner WinningBidder { get; set; }

        public double PointsPerDollar { 
            get 
            {
                if (SelectedPlayer.Stats.Count > 0 && WinningBid > 0)
                {
                    return (double)SelectedPlayer.Stats[0].stat / WinningBid;
                }
                else
                {
                    return 0.0;
                }
            }
        }
        
    }
}
