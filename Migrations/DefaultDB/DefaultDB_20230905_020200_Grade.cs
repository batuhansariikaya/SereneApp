using FluentMigrator;

namespace ExamAppSerene.Migrations.DefaultDB
{
    [Migration(20230905020200)]
    public class DefaultDB_20230905_020200_Grade : AutoReversingMigration
    {
        public override void Up()
        {
            Create.Table("Grade").InSchema("exam")
                .WithColumn("GradeId").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("Code").AsString().NotNullable()
                .WithColumn("Name").AsString().NotNullable()
                .WithColumn("Capacity").AsInt16().Nullable()
                .WithColumn("Status").AsBoolean().NotNullable();
        }
    }
}
