using ExamHooks.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamHooks
{
    public class FileWriter : ISender
    {
        private readonly string filePath;

        public FileWriter(string filePath)
        {
            this.filePath = filePath;
        }

        public async Task SendString(string text)
        {  
            using (StreamWriter sw = File.AppendText(filePath))
            {
               await sw.WriteAsync(text);
            }
        }
    }
}
