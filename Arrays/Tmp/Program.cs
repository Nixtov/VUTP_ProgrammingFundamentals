using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Tmp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    foreach (string f in Directory.GetFiles(d, "*.xml"))
                    {
                        string extension = Path.GetExtension(f);
                        if (extension != null && (extension.Equals(".xml")))
                        {
                            fileList.Add(f);
                        }
                    }
                    DirSearch(d);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return fileList;
        }
    }
}
