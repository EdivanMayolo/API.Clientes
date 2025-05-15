using ApiClientes.Database.Models;
using ApiClientes.Service.DTOs;

namespace ApiClientes.Service.Parses
{
    public class EnderecoParse
    {
        public static TbEndereco ToTbEndereco(CriarEnderecoDTO dto)
        {
            TbEndereco novoEndereco = new();
            novoEndereco.Cep = int.Parse(dto.cep);
            novoEndereco.Logradouro = dto.logradouro;
            novoEndereco.Numero = dto.numero;
            novoEndereco.Bairro = dto.bairro;
            novoEndereco.Cidade = dto.cidade;
            novoEndereco.Uf = dto.uf;
            novoEndereco.Status = int.Parse(dto.status);
            return novoEndereco;
        }
        public static EnderecoDTO ToEnderecoDTO(TbEndereco tbEndereco)
        {
            EnderecoDTO Response = new();
            Response.Id = tbEndereco.Id;
            Response.logradouro = tbEndereco.Logradouro;
            Response.numero = tbEndereco.Numero;
            Response.bairro = tbEndereco.Bairro;
            Response.cidade = tbEndereco.Cidade;
            Response.uf = tbEndereco.Uf;
            Response.cep = tbEndereco.Cep;
            Response.clienteid = tbEndereco.Clienteid;
            Response.status = tbEndereco.Status;

            return Response;
        }
    }
}
