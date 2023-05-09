using Serenity.ComponentModel;
using System;
using System.ComponentModel;

namespace ExamAppSerene.School.Columns;

[ColumnsScript("School.Question")]
[BasedOnRow(typeof(QuestionRow), CheckNames = true)]
public class QuestionColumns
{
    [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
    public int QuestionId { get; set; }
    [EditLink]
    public string QuestionTitle { get; set; }
    public string OptionA { get; set; }
    public string OptionB { get; set; }
    public string OptionC { get; set; }
    public string OptionD { get; set; }
    public int AnswerKey { get; set; }
    public bool Status { get; set; }
    public DateTime CreatedDate { get; set; }
    public string ExamName { get; set; }
}