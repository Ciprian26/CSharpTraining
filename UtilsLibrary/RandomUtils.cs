namespace UtilsLibrary {
    public static class RandomUtils {
        private static Random random = new Random();
        public static int GetRandomNumberInRange(int rangeStart, int rangeEnd)
        {
            return random.Next(rangeStart, rangeEnd + 1);
        }
    }
}