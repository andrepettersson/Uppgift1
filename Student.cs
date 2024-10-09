using System.Dynamic;

namespace Uppgift1;

public class Student : PersonalInfo, IReadInfo
{
public int StudentInfo { get; set; }

    public string AddStudentInfo()
    {
        return base.Info() + $"Student Info: {StudentInfo})";
    }

    public string Read()
    {
        return AddStudentInfo();
    }
}