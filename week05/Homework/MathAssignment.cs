public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string texbookSection, string problem) : base(name, topic)
    {
        _textbookSection = texbookSection;
        _problems = problem;   
    }

    public string GetTextbookSection()
    {
        return _textbookSection;
    }

    public string GetProblem()
    {
        return _problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {GetTextbookSection()} Problem {GetProblem()}" ;
        
    }
}


// Add the attributes as private member variables. Make sure that you do not create new member variables for the ones you inherited from the base class.
// Create a constructor for your class that accepts all four parameters, have it call the base class constructor to set the base class attributes that way.
// Add the GetHomeworkList() method.
// Test your class by returning to the Main method and creating a new MathAssignment object and set its values. Make sure to test both the GetSummary() 
//and the GetHomeworkList() methods.
// Sample Output


// Roberto Rodriguez - Fractions
// Section 7.3 Problems 8-19