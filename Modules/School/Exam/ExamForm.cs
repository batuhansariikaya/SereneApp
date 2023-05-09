using Serenity.ComponentModel;
using System;

namespace ExamAppSerene.School.Forms;

[FormScript("School.Exam")]
[BasedOnRow(typeof(ExamRow), CheckNames = true)]
public class ExamForm
{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Time { get; set; }
    public bool Status { get; set; }
    public DateTime CreatedDate { get; set; }
}