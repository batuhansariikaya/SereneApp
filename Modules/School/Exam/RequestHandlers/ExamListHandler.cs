using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<ExamAppSerene.School.ExamRow>;
using MyRow = ExamAppSerene.School.ExamRow;

namespace ExamAppSerene.School;

public interface IExamListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class ExamListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IExamListHandler
{
    public ExamListHandler(IRequestContext context)
            : base(context)
    {
    }
}