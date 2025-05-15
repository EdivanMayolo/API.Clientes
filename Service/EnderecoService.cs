using ApiClientes.Database.Models;

namespace ApiClientes.Service
{
    public class EnderecoService
    {
        private readonly ClientesContext _dbcontext;

        public EnderecoService(ClientesContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
    }
}
