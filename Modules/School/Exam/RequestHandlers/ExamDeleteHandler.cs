using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = ExamAppSerene.School.ExamRow;

namespace ExamAppSerene.School;

public interface IExamDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class ExamDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IExamDeleteHandler
{
    public ExamDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}