using System;
using System.Text;

public class Job
{
    public string Company { get; set; }
    public string JobTitle { get; set; }
    public int StartYear { get; set; }
    public int EndYear { get; set; }

    public override string ToString()
    {
        return $"{JobTitle} ({Company}) {StartYear}-{EndYear}";
    }
}

public class Resume
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public List<Job> Jobs { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(Name);
        sb.AppendLine(Email);
        sb.AppendLine(PhoneNumber);
        foreach (Job job in Jobs)
        {
            sb.AppendLine(job.ToString());
        }
        return sb.ToString();
    }
}
