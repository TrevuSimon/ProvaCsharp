using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProvaGuilherme.Pages
{
    public class CadastroDetalhesModel : PageModel
    {
        public CadastroDetalhesModel Result { get; set; }

        [BindProperty]
        public String Comida { get; set; }
        [BindProperty]
        public String Cor { get; set; }
        [BindProperty]
        public String Suco { get; set; }
        [BindProperty]
        public String Restaurante { get; set; }

        public void OnGet(object obj)
        {
            Result = (CadastroDetalhesModel)obj;
        }

        public RedirectToPageResult OnPost()
        {
            return RedirectToPage("CadastroDetalhes", this); ;
        }
    }
}