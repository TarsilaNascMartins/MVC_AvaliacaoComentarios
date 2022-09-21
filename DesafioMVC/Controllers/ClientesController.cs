using Microsoft.AspNetCore.Mvc;
using DesafioMVC.Data;
using DesafioMVC.Models;


namespace DesafioMVC.Controllers
{


    public class ClientesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClientesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var clientes = _context.Clientes?.ToList();
            return View(clientes);
        }

        public IActionResult Create()
        {
            return View();

        }

        [HttpPost]

        public IActionResult Create(Cliente cliente)
        {

            //Id gerado no banco de dados
            _context.Clientes?.Add(cliente);
            _context.SaveChanges();

           
            return RedirectToAction("Index");

            

    }
    }
}
