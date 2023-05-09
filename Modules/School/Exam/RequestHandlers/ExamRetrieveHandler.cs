using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<ExamAppSerene.School.ExamRow>;
using MyRow = ExamAppSerene.School.ExamRow;

namespace ExamAppSerene.School;

public interface IExamRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class ExamRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IExamRetrieveHandler
{
    public ExamRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}