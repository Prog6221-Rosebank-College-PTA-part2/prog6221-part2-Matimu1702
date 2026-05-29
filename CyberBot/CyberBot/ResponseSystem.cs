using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberBot
{
    internal class ResponseSystem
    {
        private static Random rand = new Random();

        public static string GetResponse(string input)
        {
            if (input.Contains("password"))
            {
                string[] responses = {
                    "Use strong passwords with at least 12 characters.",
                    "Avoid reusing the same password across sites.",
                    "Consider using a password manager."
                };
                return responses[rand.Next(responses.Length)];
            }

            if (input.Contains("phishing"))
            {
                string[] responses = {
                    "Phishing tricks users into giving sensitive information.",
                    "Always check the sender’s email address carefully.",
                    "Don’t click suspicious links in emails."
                };
                return responses[rand.Next(responses.Length)];
            }

            if (input.Contains("safe browsing"))
            {
                return "Use HTTPS websites and avoid suspicious links.";
            }

            switch (input)
            {
                case "how are you":
                    return "I'm just a bot, but I'm here to help you stay safe online!";
                case "purpose":
                    return "My purpose is to educate you about online security.";
                default:
                    return "I didn't quite understand that. Could you rephrase?";
            }
        }
    }
}
    

