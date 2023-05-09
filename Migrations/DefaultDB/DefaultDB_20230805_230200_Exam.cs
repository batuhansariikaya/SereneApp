using FluentMigrator;

namespace ExamAppSerene.Migrations.DefaultDB
{
    [Migration(20230805230200)]
    public class DefaultDB_20230805_230200_Exam : AutoReversingMigration
    {
        public override void Up()
        {
            
            Create.Table("Exam").InSchema("exam")
                .WithColumn("ExamId").AsInt32().NotNullable().PrimaryKey().Identity()
                .WithColumn("Name").AsString().NotNullable()
                .WithColumn("Description").AsString().Nullable()
                .WithColumn("Time").AsInt32().Nullable()
                .WithColumn("Status").AsBoolean().NotNullable()
                .WithColumn("CreatedDate").AsDateTime().NotNullable();
        }
    }
}
