using Serenity.ComponentModel;
using System;

namespace ExamAppSerene.School.Forms;

[FormScript("School.Question")]
[BasedOnRow(typeof(QuestionRow), CheckNames = true)]
public class QuestionForm
{
    public string QuestionTitle { get; set; }
    public string OptionA { get; set; }
    public string OptionB { get; set; }
    public string OptionC { get; set; }
    public string OptionD { get; set; }
    public int AnswerKey { get; set; }
    public bool Status { get; set; }
    public DateTime CreatedDate { get; set; }
    public int ExamId { get; set; }
}