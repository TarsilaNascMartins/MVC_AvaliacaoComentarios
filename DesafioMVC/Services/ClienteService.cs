using DesafioMVC.Models;
using DesafioMVC.Repositories;

namespace DesafioMVC.Services
{
    public class ClienteService: IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }


        public Cliente Create(Cliente cliente) {
            cliente.Nome = cliente.Nome?.ToUpper();
            return _clienteRepository.Create(cliente);
        }
        public Cliente Edit(Cliente cliente) {
            cliente.Nome = cliente.Nome?.ToUpper();
            return _clienteRepository.Update(cliente);
        }
        public Cliente? Find(int? id) { 
            if(id == null)
            {
                return null;
            }
            
            return _clienteRepository.Get(id);

        }
        //listar
        public List<Cliente> GetAll() { 
            return _clienteRepository.GetAll();
        }

   
    }
}
