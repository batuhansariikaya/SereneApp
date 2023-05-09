using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace ExamAppSerene.School.Pages;

[PageAuthorize(typeof(GradeRow))]
public class GradePage : Controller
{
    [Route("School/Grade")]
    public ActionResult Index()
    {
        return this.GridPage("@/School/Grade/GradePage",
            GradeRow.Fields.PageTitle());
    }
}