using logic_page_net6.Datos;
using logic_page_net6.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace logic_page_net6.Pages.Categorias
{
    public class EditarModel : PageModel
    {
        private readonly context _context;
        public EditarModel(context context)
        {
            _context = context;
        }
        [BindProperty]
        public Categoria Categorias { get; set; }
        public async void OnGet(int id)
        {
            Categorias = await _context.Categorias.FindAsync(id);
        }
        public async Task<IActionResult> Onpost()
        {
            if (ModelState.IsValid)
            {
                var CategoriaDesdeDb = await _context.Categorias.FindAsync(Categorias.Id);
                CategoriaDesdeDb.Nombre = Categorias.Nombre;
                CategoriaDesdeDb.FechaCreacion = Categorias.FechaCreacion;

                await _context.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return RedirectToPage();
            }

        }

    }
}
