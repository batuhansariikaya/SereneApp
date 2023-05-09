using Serenity.Services;
using MyRequest = Serenity.Services.RetrieveRequest;
using MyResponse = Serenity.Services.RetrieveResponse<ExamAppSerene.School.QuestionRow>;
using MyRow = ExamAppSerene.School.QuestionRow;

namespace ExamAppSerene.School;

public interface IQuestionRetrieveHandler : IRetrieveHandler<MyRow, MyRequest, MyResponse> {}

public class QuestionRetrieveHandler : RetrieveRequestHandler<MyRow, MyRequest, MyResponse>, IQuestionRetrieveHandler
{
    public QuestionRetrieveHandler(IRequestContext context)
            : base(context)
    {
    }
}