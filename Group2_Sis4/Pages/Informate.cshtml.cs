using Group2_Sis4.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Group2_Sis4.Pages
{
    public class InformateModel : PageModel
    {

        public List<Info> Informatat { get; set; }
        public InformateModel()
        {
           

        }
        public void OnGet()
        {
            List<Info> lista = new List<Info>();

            Info ob1 = new Info();
            ob1.Emri = "Info 1";
            ob1.Pershkrimi = "Pershkrimi 1";
            lista.Add(ob1);

            Info ob2 = new Info();
            ob2.Emri = "Info 2";
            ob2.Pershkrimi = "Pershkrimi 2";
            lista.Add(ob2);

            Info ob3 = new Info();
            ob3.Emri = "Info 3";
            ob3.Pershkrimi = "Pershkrimi 3";
            lista.Add(ob3);

            Informatat = lista;
        }

        public async Task<IActionResult> OnPost()
        {
            return Page();
        }
    }
}
