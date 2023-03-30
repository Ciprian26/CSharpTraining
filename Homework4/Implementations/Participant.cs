namespace Homework4.Implementations {
    public class Participant {
        private static int nextId = 1;
        private readonly int id;
        private int score;

        readonly Random random = new Random();

        public Participant()
        {
            id = nextId++;
            score = random.Next(1, 11);
        }

        public Participant(int score)
        {
            if (score < 1 || score > 10)
            {
                Console.WriteLine("Invalid score. Score must be in range 1 - 10.");
            }
            else
            {
                id = nextId++;
                this.score = score;
            }
        }

        public int GetId()
        {
            return id;
        }

        public int GetScore()
        {
            return score;
        }

        public void SetScore(int score)
        {
            this.score = score;
        }

        public override string ToString()
        {
            return $"ID: {id}, Score: {score}";
        }
    }
}
