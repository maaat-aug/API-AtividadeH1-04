using AttH1.Classes;
using AttH1.Services;
using Microsoft.AspNetCore.Mvc;


namespace AttH1.Controllers
{
    [ApiController]
    [Route("api/pessoa")]
    public class PessoaController : ControllerBase
    {
        private readonly IAlunoRepository _repository;
        public PessoaController(IAlunoRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]

        public IActionResult AdicionarPessoa([FromBody] Pessoa pessoa)
        {
            _repository.CadastrarUsuário(pessoa);
            return Created(string.Empty, pessoa);
        }

        [HttpDelete]
        public IActionResult PessoaRemover(string cpf)
        {
            _repository.RemoverUsuário(cpf);
            return Ok();
        }

        [HttpGet]
        [Route("BuscarTodasPessoas")]
        public IActionResult BuscarTodasPessoas()
        {
            return Ok(_repository.BuscarTodosUsuarios());
        }

        [HttpGet]
        [Route("{cpf}")]
        public IActionResult BuscarPessoaCPF([FromRoute] string cpf)
        {
            return Ok(_repository.BuscarPorCpf(cpf));
        }

        [HttpGet]
        [Route("{nome}")]
        public IActionResult BuscarPessoaEspecifica([FromRoute] string nome)
        {
            return Ok(_repository.BuscarNome(nome));
        }


        [HttpGet]
        [Route("PessoasIMC")]
        public IActionResult CalcularIMC([FromBody] double peso, double altura)
        {
            return Ok(_repository.calcularImc(peso, altura));
        }
    }
}
