using Serenity.Services;
using MyRequest = ExamAppSerene.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<ExamAppSerene.Administration.UserRow>;
using MyRow = ExamAppSerene.Administration.UserRow;

namespace ExamAppSerene.Administration
{
    public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

    public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
    {
        public UserListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}