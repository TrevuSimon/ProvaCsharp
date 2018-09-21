using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProvaGuilherme.Pages
{
    public class CadastroPessoaModel : PageModel
    {
        public static List<CadastroPessoaModel> ListaPessoas { get; set; } = new List<CadastroPessoaModel>();

        [BindProperty]
        public String Nome { get; set; }
        [BindProperty]
        public String Sobrenome { get; set; }
        [BindProperty]
        public String Email { get; set; }
        [BindProperty]
        public String Telefone { get; set; }
        [BindProperty]
        public String NomePai { get; set; }
        [BindProperty]
        public String NomeMae { get; set; }
        [BindProperty]
        public String CPF { get; set; }
        [BindProperty]
        public String RG { get; set; }
        [BindProperty]
        public String EstadoCivil { get; set; }

        public void OnGet()
        {

        }

        public RedirectToPageResult OnPost()
        {
            CadastroPessoaModel.ListaPessoas.Add(this);
            return RedirectToPage("ResultadoPessoa");
        }
    }
}