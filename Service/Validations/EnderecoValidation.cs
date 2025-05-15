using ApiClientes.Service.DTOs;
using ApiClientes.Service.Exceptions;

namespace ApiClientes.Service.Validations
{
    public class EnderecoValidation
    {
        public static void ValidarEndereco(CriarEnderecoDTO criarEnderecoDTO)
        {
            if (string.IsNullOrEmpty(criarEnderecoDTO.cep))
                throw new BadRequestException("O campo 'cep' é obrigatório.");
            if (string.IsNullOrEmpty(criarEnderecoDTO.logradouro))
                throw new BadRequestException("O campo 'logradouro' é obrigatório.");
            if (string.IsNullOrEmpty(criarEnderecoDTO.numero))
                throw new BadRequestException("O campo 'numero' é obrigatório.");
            if (string.IsNullOrEmpty(criarEnderecoDTO.bairro))
                throw new BadRequestException("O campo 'bairro' é obrigatório.");
            if (string.IsNullOrEmpty(criarEnderecoDTO.cidade))
                throw new BadRequestException("O campo 'cidade' é obrigatório.");
            if (string.IsNullOrEmpty(criarEnderecoDTO.uf))
                throw new BadRequestException("O campo 'uf' é obrigatório.");
        }
    }
}
