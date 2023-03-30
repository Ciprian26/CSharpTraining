namespace UtilsLibrary {
    public static class ArrayUtils {
        public static void DisplayArray<T>(T[] array)
        {
            int elementNumber = 1;

            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{elementNumber}. {array[i]}");
                elementNumber++;
            }
        }
    }
}
