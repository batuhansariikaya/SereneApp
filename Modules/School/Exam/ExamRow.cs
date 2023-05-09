using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace ExamAppSerene.School;

[ConnectionKey("Default"), Module("School"), TableName("[exam].[Exam]")]
[DisplayName("Exam"), InstanceName("Exam")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
[LookupScript("School.Exam")]

public sealed class ExamRow : Row<ExamRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Exam Id"), Identity, IdProperty]
    public int? ExamId
    {
        get => fields.ExamId[this];
        set => fields.ExamId[this] = value;
    }

    [DisplayName("Name"), Size(255), NotNull, QuickSearch, NameProperty]
    public string Name
    {
        get => fields.Name[this];
        set => fields.Name[this] = value;
    }

    [DisplayName("Description"), Size(255), QuickSearch]
    public string Description
    {
        get => fields.Description[this];
        set => fields.Description[this] = value;
    }

    [DisplayName("Time")]
    public int? Time
    {
        get => fields.Time[this];
        set => fields.Time[this] = value;
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

    public class RowFields : RowFieldsBase
    {
        public Int32Field ExamId;
        public StringField Name;
        public StringField Description;
        public Int32Field Time;
        public BooleanField Status;
        public DateTimeField CreatedDate;

    }
}