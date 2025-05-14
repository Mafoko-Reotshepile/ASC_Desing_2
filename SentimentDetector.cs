namespace ASC_Desing_2
{
    public class SentimentDetector
    {
        public string DetectMood(string input)
        {
            if (input.Contains("angry") || input.Contains("upset"))
                return "I'm sorry you're feeling that way. Let me help.";
            if (input.Contains("happy") || input.Contains("great"))
                return "That's great to hear!";
            return null;
        }
    }
}
