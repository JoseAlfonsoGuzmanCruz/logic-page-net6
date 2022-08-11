using logic_page_net6.Datos;
using logic_page_net6.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace logic_page_net6.Pages.Categorias
{
    public class BorrarModel : PageModel
    {
        private readonly context _context;
        public BorrarModel(context context)
        {
            _context = context;
        }
        [BindProperty]
        public Categoria Categorias { get; set; }
        public async void OnGet(int id)
        {
            Categorias = await _context.Categorias.FindAsync(id);
        }
        public async Task<ActionResult> Onpost()
        {
                var CategoriaDesdeDb = await _context.Categorias.FindAsync(Categorias.Id);
                if (CategoriaDesdeDb==null)
                {
                    return NotFound();
                }
                _context.Categorias.Remove(CategoriaDesdeDb);
                await _context.SaveChangesAsync();
                return RedirectToPage("Index");
        }
    }
}
