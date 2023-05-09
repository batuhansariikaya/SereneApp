using Serenity.ComponentModel;
using System.ComponentModel;

namespace ExamAppSerene.School.Columns;

[ColumnsScript("School.Grade")]
[BasedOnRow(typeof(GradeRow), CheckNames = true)]
public class GradeColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int GradeId { get; set; }
    [EditLink]
    public string Code { get; set; }
    public string Name { get; set; }
    public short Capacity { get; set; }
    public bool Status { get; set; }
}