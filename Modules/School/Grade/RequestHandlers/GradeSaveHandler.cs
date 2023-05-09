using Serenity.Services;
using MyRequest = Serenity.Services.SaveRequest<ExamAppSerene.School.GradeRow>;
using MyResponse = Serenity.Services.SaveResponse;
using MyRow = ExamAppSerene.School.GradeRow;

namespace ExamAppSerene.School;

public interface IGradeSaveHandler : ISaveHandler<MyRow, MyRequest, MyResponse> {}

public class GradeSaveHandler : SaveRequestHandler<MyRow, MyRequest, MyResponse>, IGradeSaveHandler
{
    public GradeSaveHandler(IRequestContext context)
            : base(context)
    {
    }
}