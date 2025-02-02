public class PromptGenerator
{
    public List<string> _prompts  = new List<string>();
    public string RandomPrompt()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was something you learned today?");
        _prompts.Add("How did you make someone else smile?");
        _prompts.Add("Who did you bless today?");
        _prompts.Add("What was something fun I did today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("One funny story that happened today?");
        _prompts.Add("What challenge did I overcome?");

        
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
        
    }
}