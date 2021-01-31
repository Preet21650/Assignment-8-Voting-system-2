using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_8_Voting_system_2
{
    class Vote
    {
        private string VoterName;
        private string PartyName;
        private DateTime TimeVoted;
        public static int TotalVotes;

        public Vote(string VoterName,string PartyName)
        {
            this.VoterName = VoterName;
            this.PartyName = PartyName;
            TotalVotes++;
        }

        public string GetVotedParty()
        {
            return PartyName;
        }

        public static int GetVoteTotal()
        {
            return TotalVotes;
        }

        

    }
}
