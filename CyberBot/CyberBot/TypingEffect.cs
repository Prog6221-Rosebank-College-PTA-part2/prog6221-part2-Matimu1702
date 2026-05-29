using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberBot
{
    internal class TypingEffect
    {
        public static async Task<string> Show(string message)
        {
            await Task.Delay(500); // simulate typing delay
            return message;
        }
    }
}
    

