using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = ExamAppSerene.School.GradeRow;

namespace ExamAppSerene.School;

public interface IGradeDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class GradeDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IGradeDeleteHandler
{
    public GradeDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}