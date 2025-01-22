using System;

class Program
{
    static void Main(string[] args)
    {
        Resume appNameOne = new Resume();
        appNameOne._personName = "Jake Farm";







        Job firstJob = new Job();
        firstJob._jobTitle = "OPD Worker";
        firstJob._jobCompany = "Walmart";
        firstJob._startYear = 2022;
        firstJob._endYear = 2023;

        Job secondJob = new Job();
        secondJob._jobTitle = "Programmer";
        secondJob._jobCompany = "Google";
        secondJob._startYear = 2025;
        secondJob._endYear = 2030;

        appNameOne.JobList();
        firstJob.JobDisplay();
        secondJob.JobDisplay();
        
        
    }
}