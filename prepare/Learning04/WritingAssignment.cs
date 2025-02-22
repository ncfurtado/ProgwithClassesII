class WritingAssignment : Assignment
{
    private string _title;
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {  
        _title = title;
    }
    public string GetHomeworkList()
    {   string studentName = GetSummary();
        return $"Title {_title} by {studentName}";
    }
}