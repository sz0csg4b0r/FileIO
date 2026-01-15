namespace FileIO
{
    public class WriteToFile
    {
        public void FileWrite(string fileName, List<string> data)
        {
            File.WriteAllLines(fileName, data);
            //Ez csak egy teszt sor.
            //Most akkor mehet a push a mainbe???
            // Nem pusholunk mainbe!! 
        }
    }
}