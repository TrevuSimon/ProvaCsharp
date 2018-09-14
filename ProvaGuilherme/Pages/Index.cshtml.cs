using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProvaGuilherme.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Login { get; set; }
        [BindProperty]
        public string Password { get; set; }

        public void OnGet()
        {

        }

        public RedirectToPageResult OnPost()
        {
            if (this.Login == "guilherme.1301703@fapi-pinhais.edu.br" && this.Password == "1301703")
                return RedirectToPage("Menu");
            else
                return null;
        }
    }
}