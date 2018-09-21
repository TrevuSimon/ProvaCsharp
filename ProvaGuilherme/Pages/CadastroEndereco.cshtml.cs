using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProvaGuilherme.Pages
{
    public class CadastroEnderecoModel : PageModel
    {
        [BindProperty]
        public String Pessoa { get; set; }
        [BindProperty]
        public String Estado { get; set; }
        [BindProperty]
        public String Cidade { get; set; }
        [BindProperty]
        public String CEP { get; set; }
        [BindProperty]
        public String Rua { get; set; }
        [BindProperty]
        public String Bairro { get; set; }
        [BindProperty]
        public String Numero { get; set; }
        [BindProperty]
        public String Complemento { get; set; }

        public void OnGet()
        {

        }

        public RedirectToPageResult OnPost()
        {
            
            return RedirectToPage("ResultadoEndereco",this);
        }
    }
}