using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject.Logic
{
    public class Section
    {
        public int MaxSpeed { get; set; }
        public int Length { get; set; }

        public Section(int speed, int length)
        {
            MaxSpeed = speed;
            Length = length;
        }
    }
}
