using Serenity.ComponentModel;

namespace ExamAppSerene.School.Forms;

[FormScript("School.Grade")]
[BasedOnRow(typeof(GradeRow), CheckNames = true)]
public class GradeForm
{
    public string Code { get; set; }
    public string Name { get; set; }
    public short Capacity { get; set; }
    public bool Status { get; set; }
}