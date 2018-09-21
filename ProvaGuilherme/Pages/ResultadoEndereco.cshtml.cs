using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ProvaGuilherme.Pages
{
    public class ResultadoEnderecoModel : PageModel
    {
        public CadastroEnderecoModel Result { get; set; }

        public void OnGet(object obj)
        {
            Result = (CadastroEnderecoModel)obj;
        }
    }
}