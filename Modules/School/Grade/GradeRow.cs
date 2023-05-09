using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace ExamAppSerene.School;

[ConnectionKey("Default"), Module("School"), TableName("[exam].[Grade]")]
[DisplayName("Grade"), InstanceName("Grade")]
[ReadPermission("Administration:General")]
[ModifyPermission("Administration:General")]
public sealed class GradeRow : Row<GradeRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Grade Id"), Identity, IdProperty]
    public int? GradeId
    {
        get => fields.GradeId[this];
        set => fields.GradeId[this] = value;
    }

    [DisplayName("Code"), Size(255), NotNull, QuickSearch, NameProperty]
    public string Code
    {
        get => fields.Code[this];
        set => fields.Code[this] = value;
    }

    [DisplayName("Name"), Size(255), NotNull]
    public string Name
    {
        get => fields.Name[this];
        set => fields.Name[this] = value;
    }

    [DisplayName("Capacity")]
    public short? Capacity
    {
        get => fields.Capacity[this];
        set => fields.Capacity[this] = value;
    }

    [DisplayName("Status"), NotNull]
    public bool? Status
    {
        get => fields.Status[this];
        set => fields.Status[this] = value;
    }

    public class RowFields : RowFieldsBase
    {
        public Int32Field GradeId;
        public StringField Code;
        public StringField Name;
        public Int16Field Capacity;
        public BooleanField Status;

    }
}