using Serenity.Navigation;
using MyPages = ExamAppSerene.School.Pages;

[assembly: NavigationLink(int.MaxValue, "School/Exam", typeof(MyPages.ExamPage), icon: "fa-pencil")]
[assembly: NavigationLink(int.MaxValue, "School/Question", typeof(MyPages.QuestionPage), icon: " fa-question")]
[assembly: NavigationLink(int.MaxValue, "School/Grade", typeof(MyPages.GradePage), icon: "fa-building-o")]
