namespace UtilsLibrary {
    public static class ListUtils {
        public static void DisplayList<T>(List<T> listToDisplay)
        {
            int elementNumber = 1;

            foreach (T element in listToDisplay)
            {
                Console.WriteLine($"{elementNumber}. {element}");
                elementNumber++;
            }
        }
    }
}
