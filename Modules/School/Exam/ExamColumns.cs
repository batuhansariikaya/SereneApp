using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace ExamAppSerene.School.Columns;

[ColumnsScript("School.Exam")]
[BasedOnRow(typeof(ExamRow), CheckNames = true)]
public class ExamColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int ExamId { get; set; }
    [EditLink]
    public string Name { get; set; }
    public string Description { get; set; }
    public int Time { get; set; }
    public bool Status { get; set; }
    public DateTime CreatedDate { get; set; }
}