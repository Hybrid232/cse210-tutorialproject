public class WritingAssignment : Assignment
{
    private string _title;



    public WritingAssignment(string studentName, string topic, string bookTitle) 
    : base(studentName, topic)
    {
        _title = bookTitle;
    }
    
    public string GetWritingInfo()
    {
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }


}