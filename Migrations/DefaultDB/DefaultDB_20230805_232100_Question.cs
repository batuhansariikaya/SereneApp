using FluentMigrator;

namespace ExamAppSerene.Migrations.DefaultDB
{
    [Migration(20230805232100)]
    public class DefaultDB_20230805_232100_Question : AutoReversingMigration
    {
        public override void Up()
        {

            Create.Table("Question").InSchema("exam")
                .WithColumn("QuestionId").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("QuestionTitle").AsString().NotNullable()
                .WithColumn("OptionA").AsString().Nullable()
                .WithColumn("OptionB").AsString().Nullable()
                .WithColumn("OptionC").AsString().Nullable()
                .WithColumn("OptionD").AsString().Nullable()
                .WithColumn("AnswerKey").AsInt32().Nullable()
                .WithColumn("Status").AsBoolean().NotNullable()
                .WithColumn("CreatedDate").AsDateTime().NotNullable();
            Alter.Table("Question").InSchema("exam")
                .AddColumn("ExamId").AsInt32().Nullable()
                .ForeignKey("FK_Question_ExamId", "exam", "Exam", "ExamId");
        }
    }
}
