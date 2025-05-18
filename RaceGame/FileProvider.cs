namespace Race
{
    public static class FileProvider
    {
        public static void CreateFile(string path)
        {
            if (!File.Exists(path))                
                File.Create(path).Close();                
        }
        public static bool Exists(string path) { return File.Exists(path);}
        public static void WriteData(string path, string data)
        {
            if (string.IsNullOrWhiteSpace(path) || string.IsNullOrWhiteSpace(data)) return;

            try
            {
                using (var sw = new StreamWriter(path, false))
                {
                    sw.WriteLine(data);
                }
            }
            catch { }
        } 
        public static string ReadAll(string path)
        {
            CreateFile(path);
            try
            {
                using (var sr = new StreamReader(path))
                {
                    return sr.ReadToEnd();
                }
            }
            catch { }
            return null;
        }
    }
}
