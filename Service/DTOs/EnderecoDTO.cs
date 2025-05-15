namespace ApiClientes.Service.DTOs
{
   
        public class CriarEnderecoDTO
        {
            public string cep { get; set; }
            public string logradouro { get; set; }
            public string numero { get; set; }
            public string bairro { get; set; }
            public string cidade { get; set; }
            public string uf { get; set; }
            public string status { get; set; }

        }
        public class EnderecoDTO
        {
        public int Id { get; set; }
        public int cep { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string uf { get; set; }
        public int clienteid { get; set; }
        public int status { get; set; }
    }

}
