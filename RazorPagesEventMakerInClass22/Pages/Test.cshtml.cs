using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesEventMakerInClass22.Pages
{
    public class TestModel : PageModel
    {

        public int AnswerToMeaningOfLife { get; set; }
        public string Name { get; set; }

        public TestModel()
        {
            AnswerToMeaningOfLife = 42;
            Name += "Poul " + "lavet i constructor";
        }
        public void OnGet()
        {
            Name += " Poul " + "lavet i Onget";
        }
    }
}
