using System;
using System.Collections.Generic;
using System.Text;

namespace Lab13
{
    class Rocky : Player
    {
        public Rocky(string name): base(name)
        {

        }
        public override string GetRPS()
        {
            return Enum.Rock.ToString();//it always returns rock 
        }
    }





















}
