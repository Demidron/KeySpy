using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamHooks.Interfaces
{
    public interface ISender
    {
        Task SendString(string text);
    }
}
