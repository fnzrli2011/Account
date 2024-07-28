using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson15
{
    public class StudentNotFound : Exception
    {
        public StudentNotFound()
        {

        }

        public StudentNotFound(string? message) : base(message)
        {
            
        }
    }
}