using Serenity.Services;
using MyRequest = Serenity.Services.ListRequest;
using MyResponse = Serenity.Services.ListResponse<ExamAppSerene.Administration.LanguageRow>;
using MyRow = ExamAppSerene.Administration.LanguageRow;


namespace ExamAppSerene.Administration
{
    public interface ILanguageListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

    public class LanguageListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, ILanguageListHandler
    {
        public LanguageListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}