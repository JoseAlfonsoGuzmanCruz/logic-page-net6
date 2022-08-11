using logic_page_net6.Datos;
using logic_page_net6.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace logic_page_net6.Pages.Categorias
{
    public class IndexModel : PageModel
    {
        private readonly context _context;
        public IndexModel(context context)
        {
            _context = context;
        }
        public IEnumerable<Categoria> Categorias { get; set; }
        public async Task OnGet()
        {
            Categorias = await _context.Categorias.ToListAsync();
        }
    }
}
