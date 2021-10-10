using System;
using System.Collections.Generic;
using System.Linq;
using ThirdPartyTools;

namespace FileData
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                string[] read = Console.ReadLine().Split(' ');
                string prefix = read[0];
                string file = read[1];
                FileDetails fd = new FileDetails();

                if (prefix.In('-v', '--v', '/v', '--version'))
                {
                    Console.WriteLine(fd.Version(file));
                }
                else if (prefix.In('-s', '--s', '/s', '--size'))
                {
                    Console.WriteLine(fd.Size(file));
                }
                else
                {
                    Console.WriteLine("Enter correct values");
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex);
            }
            
        }
    }
}
