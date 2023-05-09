using Serenity.Services;
using MyRequest = Serenity.Services.DeleteRequest;
using MyResponse = Serenity.Services.DeleteResponse;
using MyRow = ExamAppSerene.School.QuestionRow;

namespace ExamAppSerene.School;

public interface IQuestionDeleteHandler : IDeleteHandler<MyRow, MyRequest, MyResponse> {}

public class QuestionDeleteHandler : DeleteRequestHandler<MyRow, MyRequest, MyResponse>, IQuestionDeleteHandler
{
    public QuestionDeleteHandler(IRequestContext context)
            : base(context)
    {
    }
}