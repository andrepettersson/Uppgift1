using System.Dynamic;

namespace Uppgift1;

public class Student : PersonalInfo
{
public int StudentInfo { get; set; }

    public string AddStudentInfo()
    {
        return base.Info() + $"";
    }
}