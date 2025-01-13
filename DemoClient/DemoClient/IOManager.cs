using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClient
{
    public class IOManager
    {
        public void Write(string path,string content)
        {
            StreamWriter writer = new StreamWriter(path);
            writer.Write(content);
            writer.Close();
        }

        public string Read(string path)
        {
            if (!File.Exists(path))
                return "";
            return File.ReadAllText(path);
        }
    }
}
