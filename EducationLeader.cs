namespace Uppgift1;

public class EducationLeader : Teacher, IReadInfo
{
 
    public string EducationLeaderInfo()
    {
        return base.Info() + $", Anställdes: {EmploymentDate.ToShortDateString()}";
    }

    public new string Read()
    {
        return EducationLeaderInfo();
    }
   
}
