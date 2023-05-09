using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<ExamAppSerene.School.GradeRow>;
using MyRow = ExamAppSerene.School.GradeRow;

namespace ExamAppSerene.School;

public interface IGradeListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class GradeListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IGradeListHandler
{
    public GradeListHandler(IRequestContext context)
            : base(context)
    {
    }
}