using DesafioMVC.Models;

namespace DesafioMVC.Services
{
    public interface IClienteService
    {
        public Cliente Create(Cliente cliente);
        public Cliente Edit(Cliente cliente);
        public Cliente Find(int? id);
        public List<Cliente> GetAll();
    }
}