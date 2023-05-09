using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<ExamAppSerene.School.QuestionRow>;
using MyRow = ExamAppSerene.School.QuestionRow;

namespace ExamAppSerene.School;

public interface IQuestionListHandler : IListHandler<MyRow, MyRequest, MyResponse> {}

public class QuestionListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IQuestionListHandler
{
    public QuestionListHandler(IRequestContext context)
            : base(context)
    {
    }
}