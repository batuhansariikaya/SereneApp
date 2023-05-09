using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<ExamAppSerene.School.ExamRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = ExamAppSerene.School.ExamRow;

namespace ExamAppSerene.School;

public interface IExamSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class ExamSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IExamSaveHandler
{
    public ExamSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}