public class Comment
{
    private string _name;
    private string _comment;

    public Comment(string userName, string comments)
    {
        _name = userName;
        _comment = comments;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetComment()
    {
        return _comment;
    }
}