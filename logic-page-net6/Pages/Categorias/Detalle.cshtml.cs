using logic_page_net6.Datos;
using logic_page_net6.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace logic_page_net6.Pages
{
    public class DetalleModel : PageModel
    {
        private readonly context _context;
        public DetalleModel(context context)
        {
            _context = context;
        }
        [BindProperty]
        public Categoria Categorias { get; set; }
        public async void OnGet(int id)
        {
            Categorias = await _context.Categorias.FindAsync(id);
        }
    }
}
