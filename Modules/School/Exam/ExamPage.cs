using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace ExamAppSerene.School.Pages;

[PageAuthorize(typeof(ExamRow))]
public class ExamPage : Controller
{
    [Route("School/Exam")]
    public ActionResult Index()
    {
        return this.GridPage("@/School/Exam/ExamPage",
            ExamRow.Fields.PageTitle());
    }
}