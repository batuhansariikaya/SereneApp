using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<ExamAppSerene.School.QuestionRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = ExamAppSerene.School.QuestionRow;

namespace ExamAppSerene.School;

public interface IQuestionSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class QuestionSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IQuestionSaveHandler
{
    public QuestionSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}