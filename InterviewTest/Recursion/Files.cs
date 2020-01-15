using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InterviewTest.Recursion
{
    public static class Files
    {
        public static List<string> GetFiles(string directoryPath, ref List<string> FileList)
        {
            try
            {
                foreach (string s in Directory.GetFileSystemEntries(directoryPath))
                {
                    FileAttributes attr = File.GetAttributes(s);
                    if (attr.HasFlag(FileAttributes.Directory))
                    {
                        GetFiles(s, ref FileList);
                    }
                    else
                    {
                        Console.WriteLine("Found file: " + s);
                        FileList.Add(s);
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception("Unexpected exception: " + e.Message);
            }
            return FileList;
        }
    }
}
