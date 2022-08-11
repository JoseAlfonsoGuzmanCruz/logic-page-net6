using logic_page_net6.Datos;
using logic_page_net6.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace logic_page_net6.Pages.Categorias
{
    public class CrearModel : PageModel
    {
        private readonly context _context;
        public CrearModel(context context)
        {
            _context = context;
        }
        [BindProperty]
        public Categoria Categorias { get; set; }
        public void OnGet()
        {
        }
        public async Task<ActionResult> Onpost()
        {
            if (ModelState.IsValid)
            {
                await _context.Categorias.AddAsync(Categorias);
                await _context.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
