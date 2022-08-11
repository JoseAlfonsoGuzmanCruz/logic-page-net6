using logic_page_net6.Datos;
using logic_page_net6.Modelos.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace logic_page_net6.Pages.Contactos
{
    public class CrearModel : PageModel
    {
        private readonly context _context;
        public CrearModel(context context)
        {
            _context = context;
        }
        [BindProperty]
        public CrearContactoVM ContactoVm { get; set; }
        public async Task<IActionResult> OnGet()
        {
            ContactoVm = new CrearContactoVM()
            {
                ListaCategorias = await _context.Categorias.ToListAsync(),
                Contactos = new Modelos.Contacto()
            };
            return Page();
        }
        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _context.Contactos.AddAsync(ContactoVm.Contactos);
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
