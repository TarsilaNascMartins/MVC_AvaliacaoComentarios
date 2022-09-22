using Microsoft.AspNetCore.Mvc;
using DesafioMVC.Data;
using DesafioMVC.Models;
using Microsoft.EntityFrameworkCore;
using DesafioMVC.Services;

namespace DesafioMVC.Controllers
{


    public class ClientesController : Controller
    {
        private readonly IClienteService _clienteService;

        public ClientesController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public IActionResult Index()
        {
            //var clientes = _clienteService.Clientes?.ToList();
            var clientes = _clienteService.GetAll();
            return View(clientes);
        }

        public IActionResult Create()
        {
            return View();

        }

        [HttpPost]

        public IActionResult Create(Cliente cliente)
        {
            if(ModelState.IsValid){
                //Id gerado no banco de dados
                //_clienteService.Clientes?.Add(cliente);
                //_clienteService.SaveChanges();

                _clienteService.Create(cliente);
            return RedirectToAction("Index");
            }
            return View(cliente);

    }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var cliente = _clienteService.Clientes?.Find(id);

            var cliente = _clienteService.Find(id);

            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        [HttpPost]
        public IActionResult Edit(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                //_clienteService.Entry(cliente).State = EntityState.Modified;
                //_clienteService.SaveChanges();

                _clienteService.Edit(cliente);
                return RedirectToAction("Index");
            }
            return View(cliente);


        }








    }
}
