using static UtilsLibrary.ArrayUtils;

namespace Homework4.Implementations.ArrayType {
    public class ParticipantArrayManager {
        private Participant[] participantsArray = new Participant[0];
        private int currentArrayLength = 0;

        public void DisplayParticipantsArray()
        {
            DisplayArray(participantsArray);
        }

        private void UpdateParticipantsArray(Participant[] newParticipantsArray)
        {
            participantsArray = newParticipantsArray;
        }

        public void AddParticipant(Participant participant)
        {
            currentArrayLength++;
            Participant[] newParticipantsArray = new Participant[currentArrayLength];

            Array.Copy(participantsArray, newParticipantsArray, participantsArray.Length);
            newParticipantsArray[currentArrayLength - 1] = participant;

            UpdateParticipantsArray(newParticipantsArray);
            Console.WriteLine("Added new participant at the end of array");
        }

        public void AddParticipantToPosition(Participant participant, int position)
        {
            currentArrayLength++;
            Participant[] newParticipantsArray = new Participant[currentArrayLength];

            Array.Copy(participantsArray, 0, newParticipantsArray, 0, position - 1);
            newParticipantsArray[position - 1] = participant;
            Array.Copy(participantsArray, position - 1, newParticipantsArray, position, currentArrayLength - position);

            UpdateParticipantsArray(newParticipantsArray);
            Console.WriteLine($"Added new participant on position {position} with score {participant.GetScore()}");
        }

        public void DeleteParticipantFromPosition(int position)
        {
            for (int i = position - 1; i < participantsArray.Length - 1; i++)
            {
                participantsArray[i] = participantsArray[i + 1];
            }
            currentArrayLength--;
            Array.Resize(ref participantsArray, currentArrayLength);
            Console.WriteLine($"Deleted participant from position {position}");
        }

        public void ChangeParticipantScoreById(int id, int newScore)
        {
            foreach (Participant participant in participantsArray)
            {
                if (participant.GetId() == id)
                {
                    Console.WriteLine($"Changed participant with ID {id} score from {participant.GetScore()} to {newScore}");
                    participant.SetScore(newScore);
                }
            }
        }

        public Participant[] GetParticipantsBelowScore(int score)
        {
            Participant[] participantsBelowScoreArray = new Participant[currentArrayLength];
            int position = 0;
            foreach (Participant participant in participantsArray)
            {
                if (participant.GetScore() < score)
                {
                    participantsBelowScoreArray[position] = participant;
                    position++;
                }
            }
            Array.Resize(ref participantsBelowScoreArray, position);
            return participantsBelowScoreArray;
        }

        public Participant[] GetParticipantsAboveScore(int score)
        {
            Participant[] participantsAboveScoreArray = new Participant[currentArrayLength];
            int position = 0;
            foreach (Participant participant in participantsArray)
            {
                if (participant.GetScore() > score)
                {
                    participantsAboveScoreArray[position] = participant;
                    position++;
                }
            }
            Array.Resize(ref participantsAboveScoreArray, position);
            return participantsAboveScoreArray;
        }

        public Participant[] SortParticipantsArrayAscending(Participant[] participantArrayToSort = null)
        {
            if (participantArrayToSort == null)
            {
                participantArrayToSort = participantsArray;
            }

            Participant[] participantsAscending = new Participant[participantArrayToSort.Length];
            Array.Copy(participantArrayToSort, participantsAscending, participantArrayToSort.Length);

            Array.Sort(participantsAscending, (participant, nextParticipant) => participant.GetScore().CompareTo(nextParticipant.GetScore()));
            return participantsAscending;
        }

        public float CalculateAverageScoreInInterval(int startingPosition, int endingPosition)
        {
            float sum = 0;
            int counter = 0;

            for (int i = startingPosition - 1; i < endingPosition; i++)
            {
                sum = sum + participantsArray[i].GetScore();
                counter++;
            }
            return sum / counter;
        }

        //Sort method without copying to another Array
        public void SortParticipantsByScore()
        {
            int[] index = new int[participantsArray.Length];
            for (int i = 0; i < participantsArray.Length; i++)
            {
                index[i] = i;
            }

            for (int i = 0; i < participantsArray.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < participantsArray.Length; j++)
                {
                    if (participantsArray[index[min]].GetScore() > participantsArray[index[j]].GetScore())
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    int temp = index[min];
                    index[min] = index[i];
                    index[i] = temp;
                }
            }

            for (int i = 0; i < participantsArray.Length; i++)
            {
                Console.Write($"{i + 1}. {participantsArray[index[i]]}\n");
            }
        }

        //Add method with doubling array size
        public void AddParticipantWithDoubleSize(Participant participant)
        {
            if (currentArrayLength == participantsArray.Length)
            {
                int newLength = participantsArray.Length == 0 ? 1 : participantsArray.Length * 2;
                Participant[] newArray = new Participant[newLength];
                Array.Copy(participantsArray, newArray, currentArrayLength);
                participantsArray = newArray;
            }

            participantsArray[currentArrayLength++] = participant;
        }
    }
}