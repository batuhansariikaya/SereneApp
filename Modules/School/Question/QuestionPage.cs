using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace ExamAppSerene.School.Pages;

[PageAuthorize(typeof(QuestionRow))]
public class QuestionPage : Controller
{
    [Route("School/Question")]
    public ActionResult Index()
    {
        return this.GridPage("@/School/Question/QuestionPage",
            QuestionRow.Fields.PageTitle());
    }
}