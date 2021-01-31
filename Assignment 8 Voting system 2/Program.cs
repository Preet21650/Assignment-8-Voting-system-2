using System;

namespace Assignment_8_Voting_system_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Vote[] votes = new Vote[1000000];

            Console.WriteLine(Vote.GetVoteTotal());
            CastVotes(votes);

        }


        static void CastVotes(Vote[] votes)
        {
            int i = 0;
            bool Voted = false;
            while (Voted == false)
            {
                Console.WriteLine("Please enter name");
                string VoterName = Console.ReadLine();
                Console.WriteLine("1: for communists, 2: democrats, 3; for fascists 0: to Exit");
                string VotedInput = Console.ReadLine();
                int VoteNumber = Convert.ToInt32(VotedInput);
                if (VoteNumber == 1)
                {
                    votes[i] = new Vote(VoterName, "communists");
                    i++;
                }
                else if (VoteNumber == 2)
                {
                    votes[i] = new Vote(VoterName, "democrats");
                    i++;
                }
                else if (VoteNumber == 3)
                {
                    votes[i] = new Vote(VoterName, "facists");
                    i++;
                }
                else if (VoteNumber == 0)
                {
                    Voted = true;
                    Console.WriteLine("You have exited the voting system ");
                }
                else
                {
                    Console.WriteLine("Please enter 0,1,2 or 3");
                }
            }


        }
        static int[] CountVotes(Vote[] votes)
        {
            int[] partyVotes = new int[3];


            for (int i = 0; i < votes.Length; i++)
            {
                if (votes[i] != null && votes[i].GetVotedParty() == "Democrats")
                {
                    partyVotes[0] = partyVotes[0] + 1;
                }
                else if (votes[i] != null && votes[i].GetVotedParty() == "Communists")
                {
                    partyVotes[1] = partyVotes[1] + 1;
                }
                else if (votes[i] != null && votes[i].GetVotedParty() == "Facists")
                {
                    partyVotes[2] = partyVotes[2] + 1;
                }

            }
            return partyVotes;


        }
        static string GetHighestVotes(Vote[] votes)
        {
            String HighestVotes = "";
            int DemocratsVotes = CountVotes(votes)[0];
            int CommunistsVotes = CountVotes(votes)[1];
            int FacistsVotes = CountVotes(votes)[2];
            if (DemocratsVotes > CommunistsVotes && DemocratsVotes > FacistsVotes)
            {
                HighestVotes = "Democrats";
            }
            else if (CommunistsVotes > DemocratsVotes && CommunistsVotes > FacistsVotes)
            {
                HighestVotes = "Communists";
            }
            else if (FacistsVotes > DemocratsVotes && FacistsVotes > CommunistsVotes)
            {
                HighestVotes = "Facists";
            }
            return HighestVotes;
        }
    }
}
       
    
