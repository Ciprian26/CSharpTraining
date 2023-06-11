namespace dotNet_Part3.FileManager
{
    public class PathUtils
    {
        private static readonly string path = "C:\\Users\\Ciprian\\source\\repos\\CSharpTraining\\dotNet Part3\\FileManager\\";
        private static readonly string inputFileName = "inputFile.txt";
        private static readonly string outputFileName = "outputFile.txt";

        public static string GetInputFilePath()
        {
            return path + inputFileName;
        }

        public static string GetOutputFilePath()
        {
            return path + outputFileName;
        }
    }
}
