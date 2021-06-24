using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

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
                String readBuffer = Encoding.Default.GetString(File.ReadAllBytes(filePath));
                List<String> texts = readBuffer.Split(" ").ToList();
                Dictionary<String, int> uniqueTexts = new Dictionary<string, int>();

                foreach (var text in texts)
                {
                    if (!uniqueTexts.ContainsKey(text))
                    {
                        for (int i = 0; i < texts.Count; i++)
                        {
                            if(text == texts[i])
                            {
                                uniqueTexts[text]++;
                                texts.RemoveAt(i);
                            }
                        }
                    } else
                    {
                        uniqueTexts.Add(text, 1);
                    }
                }

                for (int i = 0; i < uniqueTexts.Count; i++)
                {
                    Console.Write(uniqueTexts.Values);
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
