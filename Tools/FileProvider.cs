namespace Tools
{
    public static class FileProvider
    {
        
        private static object _locker = new object();   
            
        public static void WriteDataToFile(string text, string directory)
        {
            lock (_locker)
            {
                string path = $@"{directory}\File_{DateTime.Now:yyyy-MM-dd}.txt";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(path));
                }
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLine(text);
                    writer.Close();
                }
            }
        }

        public static string[] ReadDataFromFile(string path)
        {
            lock (_locker)
            {
                string[] lines = File.ReadAllLines(path);
                return lines;
            }
        }       
    }
}
