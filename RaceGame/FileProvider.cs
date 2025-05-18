namespace Race
{
    public static class FileProvider
    {
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
