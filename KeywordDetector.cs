using System.Collections.Generic;

namespace ASC_Desing_2
{
    public class KeywordDetector
    {
        private Dictionary<string, string> topics = new Dictionary<string, string>()
        {
            { "password", "Use passwords of 12+ characters for better security." },
            { "phishing", "Phishing is a scam to trick you into giving personal info." },
            { "https", "Always check for 'https' to ensure the site is secure." },
            { "cybercrime", "Cybercrime includes identity theft, fraud, and hacking." },
            { "cybersecurity", "Cybersecurity protects devices, networks and data." }
        };

        public string Detect(string input)
        {
            foreach (var pair in topics)
            {
                if (input.ToLower().Contains(pair.Key))
                    return pair.Value;
            }
            return null;
        }
    }
}
