public class Job 
{
    //Job Title
    public string _jobTitle;
    //Job Company
    public string _jobCompany;
    //Start Year
    public int _startYear;
    //End Year
    public int _endYear;

    public void JobDisplay()
    {
        Console.WriteLine($"{_jobTitle} ({_jobCompany}) {_startYear}-{_endYear}");


    }

}