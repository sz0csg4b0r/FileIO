namespace FileIO
{
    public class ReadFromFile
    {
        public List<List<string>> FileRead(string fileName, int itemCounter, char splitter, bool header)
        {
            List<List<string>> result = new List<List<string>>();
            try
            {
                string[] lines = File.ReadAllLines(fileName);
                if (header)
                {
                    lines = lines.Skip(1).ToArray();
                }
                foreach (string line in lines)
                {
                    string[] items = line.Split(splitter);

                    if (items.Length == itemCounter)
                    {
                        result.Add(new List<string>(items));
                    }
                    else
                    {
                        Console.WriteLine("A sor nem " +
                            "tartalmaz megfelelő szamú elemet");
                    }
                }
            }
            catch (FileNotFoundException error1)
            {
                Console.WriteLine("A fájl nem található: (error1)", error1);
            }
            catch (IOException error2)
            {
                Console.WriteLine("A fájl nem található: (error2)", error2);
            }
            catch (Exception error3)
            {
                Console.WriteLine("Váratlan hiba történt.: (error3)", error3);
            }
            return result;
        }
    }
}
