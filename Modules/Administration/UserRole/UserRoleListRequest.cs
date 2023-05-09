using Serenity.Services;

namespace ExamAppSerene.Administration
{
    public class UserRoleListRequest : ServiceRequest
    {
        public int? UserID { get; set; }
    }
}