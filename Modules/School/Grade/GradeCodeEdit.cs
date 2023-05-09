using System;

namespace ExamAppSerene.Web.Modules.School.Grade
{
    public class GradeCodeEdit
    {
        public string EditCode(string gradeName)
        {
            string[] words= gradeName.Split(" ");
            string firstWord="";
            string secondWord="";
            for(int i=0; i<words.Length;)
            {
                firstWord = words[i];
                i++;
                secondWord = words[i];
            }
            string firstCharacter=firstWord.Substring(0,1).ToUpper();
            string secondCharacter=secondWord.Substring(0,1).ToUpper();
            Random random=new Random();
            int number=random.Next(300);
            string code = $"{firstCharacter}{secondCharacter}{number}";
            return code;
        }
    }
}
/* burada grade sayfasında sınıf kodunu rastgele oluştursun diye bir çözüm ürettim fakat bunu ui kısmına taşıyamadım
sadece algoritması ile bunu buraya bırakıyorum öğrendiğim vakit ekleyeceğim hocam..
 */