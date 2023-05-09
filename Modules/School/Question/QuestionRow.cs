using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace ExamAppSerene.School;

[ConnectionKey("Default"), Module("School"), TableName("[exam].[Question]")]
[DisplayName("Question"), InstanceName("Question")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class QuestionRow : Row<QuestionRow.RowFields>, IIdRow, INameRow
{
    const string jExam = nameof(jExam);

    [DisplayName("Question Id"), Identity, IdProperty]
    public int? QuestionId
    {
        get => fields.QuestionId[this];
        set => fields.QuestionId[this] = value;
    }

    [DisplayName("Question Title"), Size(255), NotNull, QuickSearch, NameProperty]
    public string QuestionTitle
    {
        get => fields.QuestionTitle[this];
        set => fields.QuestionTitle[this] = value;
    }

    [DisplayName("Option A"), Size(255)]
    public string OptionA
    {
        get => fields.OptionA[this];
        set => fields.OptionA[this] = value;
    }

    [DisplayName("Option B"), Size(255)]
    public string OptionB
    {
        get => fields.OptionB[this];
        set => fields.OptionB[this] = value;
    }

    [DisplayName("Option C"), Size(255)]
    public string OptionC
    {
        get => fields.OptionC[this];
        set => fields.OptionC[this] = value;
    }

    [DisplayName("Option D"), Size(255)]
    public string OptionD
    {
        get => fields.OptionD[this];
        set => fields.OptionD[this] = value;
    }

    [DisplayName("Answer Key")]
    public int? AnswerKey
    {
        get => fields.AnswerKey[this];
        set => fields.AnswerKey[this] = value;
    }

    [DisplayName("Status"), NotNull]
    public bool? Status
    {
        get => fields.Status[this];
        set => fields.Status[this] = value;
    }

    [DisplayName("Created Date"), NotNull]
    public DateTime? CreatedDate
    {
        get => fields.CreatedDate[this];
        set => fields.CreatedDate[this] = value;
    }

    [DisplayName("Exam"), ForeignKey("[exam].[Exam]", "ExamId"), LeftJoin(jExam), TextualField(nameof(ExamName))]
    [LookupEditor("School.Exam")]
    public int? ExamId
    {
        get => fields.ExamId[this];
        set => fields.ExamId[this] = value;
    }

    [DisplayName("Exam Name"), Expression($"{jExam}.[Name]")]
    public string ExamName
    {
        get => fields.ExamName[this];
        set => fields.ExamName[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field QuestionId;
        public StringField QuestionTitle;
        public StringField OptionA;
        public StringField OptionB;
        public StringField OptionC;
        public StringField OptionD;
        public Int32Field AnswerKey;
        public BooleanField Status;
        public DateTimeField CreatedDate;
        public Int32Field ExamId;

        public StringField ExamName;
    }
}