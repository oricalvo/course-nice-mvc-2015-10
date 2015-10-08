using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace AddressBook.BL
{
    public class Helpers
    {
        internal static void EnsureDirectory(string filePath)
        {
            string dirPath = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }
        }
    }
}
