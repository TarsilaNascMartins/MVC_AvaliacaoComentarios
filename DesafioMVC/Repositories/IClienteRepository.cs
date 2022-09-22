using DesafioMVC.Models;

namespace DesafioMVC.Repositories
{
    public interface IClienteRepository
    {
        public List<Cliente> GetAll();

        public Cliente Create( Cliente cliente);
        public Cliente Update( Cliente cliente);
    
        public Cliente? Get (int? id);
    }

}
 