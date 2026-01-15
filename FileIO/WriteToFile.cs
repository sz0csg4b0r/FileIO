namespace FileIO
{
    public class WriteToFile
    {
        public void FileWrite(string fileName, List<string> data)
        {
            File.WriteAllLines(fileName, data);

            //Most már  jó? 
            //akármi #4
        }
    }
}