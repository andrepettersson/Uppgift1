using System.Reflection.Metadata.Ecma335;

namespace Uppgift1
{
public class Teacher : PersonalInfo, IReadInfo
{
public string KnowledgeInfo { get; set; } = "";
public List<Course> Courses { get; set; } = new List<Course>();
public DateTime EmploymentDate { get; set; } 
public string TeacherInfo()
{
string courseInfo = "Matematik";

    if (Courses.Count > 0)
    {
    courseInfo = ""; 

    foreach (var course in Courses)
    {
    if (courseInfo.Length > 0)
    {
    courseInfo += ", ";
    }
    courseInfo += course.Title;
    }
    }

    return $"{Info()}, Kunskap inom: {KnowledgeInfo}, Blev Anställd: {EmploymentDate.ToShortDateString()}, Kurs: {courseInfo}";
    }
    public string Read()
    {
        return TeacherInfo();
    }
    
    }
}




