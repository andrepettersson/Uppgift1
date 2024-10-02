namespace Uppgift1;

public class EducationLeader : Teacher
{
 
    public string EducationLeaderInfo()
    {
        return base.Info() + $", Anställdes: {EmploymentDate.ToShortDateString()}";
    }
   
}
