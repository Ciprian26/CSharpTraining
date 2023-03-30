using static UtilsLibrary.ConsoleUtils;
using static UtilsLibrary.InputUtils;
using static UtilsLibrary.ArrayUtils;

namespace Homework4.Implementations.ArrayType
{
    public static class ProgramArray
    {
        public static void Run()
        {
            ParticipantArrayManager participantsArray = new ParticipantArrayManager();
            int selectedAction, position, score, id;

            SetUpArrayWithDummyData(participantsArray);

            do
            {
                SetConsoleColor(ConsoleColor.Green);
                Console.WriteLine("\n*=====* PARTICIPANT ARRAY *=====*");
                participantsArray.DisplayParticipantsArray();

                DisplayOptionMenu();
                Console.WriteLine("\nEnter action number: ");
                selectedAction = int.Parse(Console.ReadLine());

                switch (selectedAction)
                {
                    case 1:
                        Console.WriteLine("Enter new participant score.");
                        score = GetNumberInRange(1, 10);

                        participantsArray.AddParticipant(new Participant(score));
                        break;
                    case 2:
                        Console.WriteLine("Enter participant position: ");
                        position = GetNumber();

                        Console.WriteLine("Enter participant score.");
                        score = GetNumberInRange(1, 10);

                        participantsArray.AddParticipantToPosition(new Participant(score), position);
                        break;
                    case 3:
                        Console.WriteLine("Enter participant position for deletion: ");
                        position = GetNumber();

                        participantsArray.DeleteParticipantFromPosition(position);
                        break;
                    case 4:
                        Console.WriteLine("Enter participant ID: ");
                        id = GetNumber();

                        Console.WriteLine("Enter participant new score.");
                        score = GetNumberInRange(1, 10);

                        participantsArray.ChangeParticipantScoreById(id, score);
                        break;
                    case 5:
                        Console.WriteLine("Enter score.");
                        score = GetNumberInRange(1, 10);

                        DisplayArray(participantsArray.GetParticipantsBelowScore(score));
                        break;
                    case 6:
                        DisplayArray(participantsArray.SortParticipantsArrayAscending());
                        break;
                    case 7:
                        Console.WriteLine("Enter score.");
                        score = GetNumberInRange(1, 10);

                        DisplayArray(participantsArray.SortParticipantsArrayAscending(participantsArray.GetParticipantsAboveScore(score)));
                        break;
                    case 8:
                        int startingPosition, endPosition;

                        Console.WriteLine("Enter starting position");
                        startingPosition = GetNumber();

                        Console.WriteLine("Enter ending position");
                        endPosition = GetNumber();

                        Console.WriteLine($"Average score from position {startingPosition} to {endPosition} is "
                            + participantsArray.CalculateAverageScoreInInterval(startingPosition, endPosition).ToString("F2"));
                        break;
                }
            } while (selectedAction != 0);
        }

        public static void DisplayOptionMenu()
        {
            SetConsoleColor(ConsoleColor.Yellow);
            Console.WriteLine("Select an option:\n" +
                  "1. Add a new participant with score to the end of the array.\n" +
                  "2. Add a new participant with score to a position given in the array.\n" +
                  "3. Delete a participant from a given position.\n" +
                  "4. Modify the score of a participant by identification number.\n" +
                  "5. Print all participants that have a score less that a given score.\n" +
                  "6. Print all the participants in ascending order by score.\n" +
                  "7. Print all the participants with a score bigger than a given score in ascending order by score.\n" +
                  "8. Calculate the arithmetic mean of the scores for a given interval.\n" +
                  "0. Exit.");

            SetConsoleColor(ConsoleColor.White);
        }

        public static void SetUpArrayWithDummyData(ParticipantArrayManager participantArray)
        {
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                participantArray.AddParticipant(new Participant(random.Next(1, 11)));
            }
        }
    }
}
