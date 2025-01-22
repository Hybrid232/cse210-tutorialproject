public class Resume
{
    //First Name
    public string _personName;
    //List of Jobs
    public void JobList()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine("Jobs:");


        List<Resume> resumes = new List<Resume>();

        foreach (Resume r in resumes)
        {
            r.JobList();

        }


    }


}