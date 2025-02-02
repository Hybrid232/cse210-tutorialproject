public class Resume
{
    //First Name
    public string _personName;
    public List<Job> _resumes = new List<Job>();
    //List of Jobs
    public void JobList()
    {
        Console.WriteLine($"Name: {_personName}");
        
        Console.WriteLine("Jobs:");

        foreach (Job r in _resumes)
        {
            r.JobDisplay();

        }
    }

    


}