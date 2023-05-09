using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<ExamAppSerene.School.GradeRow>;
using MyRow = ExamAppSerene.School.GradeRow;

namespace ExamAppSerene.School;

public interface IGradeRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class GradeRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IGradeRetrieveHandler
{
    public GradeRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}