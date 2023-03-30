using static UtilsLibrary.ListUtils;
using static UtilsLibrary.InputUtils;
using static UtilsLibrary.ConsoleUtils;

namespace Homework4.Implementations.ListType {
    public static class ProgramList {
        public static void Run()
        {
            ParticipantListManager participantsList = new ParticipantListManager();
            int selectedAction, position, score, id;

            SetUpListWithDummyData(participantsList);

            do
            {
                SetConsoleColor(ConsoleColor.Green);
                Console.WriteLine("\n*=====* PARTICIPANT LIST *=====*");
                participantsList.DisplayParticipantList();

                DisplayOptionMenu();
                Console.WriteLine("\nEnter action number: ");
                selectedAction = int.Parse(Console.ReadLine());

                switch (selectedAction)
                {
                    case 1:
                        Console.WriteLine("Enter new participant score: ");
                        participantsList.AddParticipant(new Participant(int.Parse(Console.ReadLine())));
                        break;
                    case 2:
                        Console.WriteLine("Enter participant position: ");
                        position = GetNumber();

                        Console.WriteLine("Enter participant score.");
                        score = GetNumberInRange(1, 10);

                        participantsList.AddParticipantToPosition(new Participant(score), position);
                        break;
                    case 3:
                        Console.WriteLine("Enter participant position for deletion: ");
                        position = GetNumber();

                        participantsList.DeleteParticipantByPosition(position);
                        break;
                    case 4:
                        Console.WriteLine("Enter participant ID: ");
                        id = GetNumber();

                        Console.WriteLine("Enter participant new score.");
                        score = GetNumberInRange(1, 10);

                        participantsList.ChangeParticipantScoreById(id, score);
                        break;
                    case 5:
                        Console.WriteLine("Enter score.");
                        score = GetNumberInRange(1, 10);

                        DisplayList(participantsList.GetParticipantsBelowScore(score));
                        break;
                    case 6:
                        DisplayList(participantsList.SortParticipantsAscendingByScore());
                        break;
                    case 7:
                        Console.WriteLine("Enter score.");
                        score = GetNumberInRange(1, 10);

                        DisplayList(participantsList.SortParticipantsWithBiggerScoreAscending(score));
                        break;
                    case 8:
                        int startingPosition, endPosition;

                        Console.WriteLine("Enter starting position");
                        startingPosition = GetNumber();

                        Console.WriteLine("Enter ending position");
                        endPosition = GetNumber();

                        Console.WriteLine($"Average score from position {startingPosition} to {endPosition} is "
                            + participantsList.CalculateAverageScoreInInterval(startingPosition, endPosition).ToString("F2"));
                        break;
                }
            } while (selectedAction != 0);
        }

        public static void DisplayOptionMenu()
        {
            SetConsoleColor(ConsoleColor.Yellow);
            Console.WriteLine("Select an option:\n" +
                  "1. Add a new participant with score to the end of the list.\n" +
                  "2. Add a new participant with score to a position given in the list.\n" +
                  "3. Delete a participant from a given position.\n" +
                  "4. Modify the score of a participant by identification number.\n" +
                  "5. Print all participants that have a score less that a given score.\n" +
                  "6. Print all the participants in ascending order by score.\n" +
                  "7. Print all the participants with a score bigger than a given score in ascending order by score.\n" +
                  "8. Calculate the arithmetic mean of the scores for a given interval.\n" +
                  "0. Exit.");

            SetConsoleColor(ConsoleColor.White);
        }

        public static void SetUpListWithDummyData(ParticipantListManager participantList)
        {
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                participantList.AddParticipant(new Participant(random.Next(1, 11)));
            }
        }
    }
}
