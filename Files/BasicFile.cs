using System;
using System.IO;
using System.Linq;

namespace DataStructure.Files
{
    public class BasicFile
    {
        private BasicFile()
        {

        }

        public static BasicFile getInstance()
        {
            if(file == null)
            {
                return new BasicFile();
            }
            return file;
        }

        public void createFile(String filePath)
        {
            FilePath = filePath;
            if (fileAlreadyExists())
            {
                throw new Exception("File Already exists");
            }

        }

        private bool fileAlreadyExists()
        {
            return System.IO.File.Exists(FilePath);
        }

        public void findAndDisplayUniqueWordFrequency(String filePath)
        {
            try
            {
                String[] readBuffer = File.ReadAllBytes(filePath).Select(x => x.ToString()).ToArray();
                foreach (String b in readBuffer)
                {
                    Console.Write(b);
                }
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("You are unauthorized to access {0}, please change permission", filePath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        private string FilePath { get; set; }
        private static BasicFile  file { get; set; }
    }
}
