public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    public string GetRandomPrompt()
    {
        Random rd = new Random();
        int randomIndexQuestion = rd.Next(0, _prompts.Count);

        _prompts.Add("What did I learn today that helped me grow as a person?");
        _prompts.Add("Who did I help today, and how did it make me feel?");
        _prompts.Add("What moment of the day made me feel most grateful?");
        _prompts.Add("What made me laugh or smile today?");
        _prompts.Add("What can I improve tomorrow to be a better version of myself?");
        
        string selectedQuestion = _prompts[randomIndexQuestion];
        
        return selectedQuestion;
    } 
}