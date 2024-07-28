using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson15
{
    public class GroupNotFound : Exception
    {
        public GroupNotFound()
        {
        }

        public GroupNotFound(string? message) : base(message)
        {

        }       
    }
}