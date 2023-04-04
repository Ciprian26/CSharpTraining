using static UtilsLibrary.ListUtils;

namespace Homework4.Implementations.ListType
{
    public class ParticipantListManager
    {
        private readonly List<Participant> participantsList = new List<Participant>();

        public void DisplayParticipantList()
        {
            DisplayList(participantsList);
        }

        public void AddParticipant(Participant participant)
        {
            if (participant.GetId() == 0)
            {
                Console.WriteLine("Invalid participant data.");
            }
            else
            {
                participantsList.Add(participant);
                Console.WriteLine("New Participant added to the end of list.");
            }
        }

        public void AddParticipantToPosition(Participant participant, int position)
        {
            participantsList.Insert(position - 1, participant);
            Console.WriteLine($"New Participant was added to position {position}");
        }

        public void DeleteParticipantByPosition(int position)
        {
            participantsList.RemoveAt(position - 1);
            Console.WriteLine($"Participant was removed from position {position}");
        }

        public void ChangeParticipantScoreById(int id, int newScore)
        {
            if (newScore < 0 || newScore > 10)
            {
                Console.WriteLine("Invalid score. Score must be in range 1 - 10.");
            }
            else
            {
                foreach (Participant participant in participantsList)
                {
                    if (participant.GetId() == id)
                    {
                        Console.WriteLine($"Changed participant with ID {participant.GetId()} score from {participant.GetScore()} to {newScore}");
                        participant.SetScore(newScore);
                    }
                }
            }
        }

        public List<Participant> GetParticipantsBelowScore(int score)
        {
            List<Participant> participantsBelowScore = new List<Participant>();

            Console.WriteLine($"Participants with score lower than {score} are: ");

            foreach (Participant participant in participantsList)
            {
                if (participant.GetScore() < score)
                {
                    participantsBelowScore.Add(participant);
                }
            }
            return participantsBelowScore;
        }

        public List<Participant> SortParticipantsAscendingByScore(List<Participant> participantList = null)
        {
            if(participantList == null)
            {
                participantList = participantsList;
            }

            List<Participant> participantListAscending = new List<Participant>(participantList);

            participantListAscending.Sort((participant, nextParticipant) => participant.GetScore().CompareTo(nextParticipant.GetScore()));

            return participantListAscending;
        }

        public List<Participant> SortParticipantsWithBiggerScoreAscending(int score)
        {
            List<Participant> participantsWithBiggerScore = new List<Participant>();

            foreach (Participant participant in participantsList)
            {
                if (participant.GetScore() > score)
                {
                    participantsWithBiggerScore.Add(participant);
                }
            }

            return SortParticipantsAscendingByScore(participantsWithBiggerScore);
        }

        public float CalculateAverageScoreInInterval(int startingPosition, int endPosition)
        {
            float sum = 0;
            int counter = 0;

            if (startingPosition > 0 || endPosition <= participantsList.Count)
            {
                for (int i = startingPosition - 1; i < endPosition; i++)
                {
                    sum = sum + participantsList[i].GetScore();
                    counter++;
                }
                return sum / counter;
            }
            else
            {
                Console.WriteLine($"Invalid input. Interval can start from 0 to {participantsList.Count}");
                return 0;
            }
        }
    }
}
