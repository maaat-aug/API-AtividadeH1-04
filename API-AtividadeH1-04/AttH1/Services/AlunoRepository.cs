using AttH1.Classes;

namespace AttH1.Services
{
    public class AlunoRepository : IAlunoRepository
    {
        public List<Pessoa> Pessoas = new List<Pessoa>();

        public void CadastrarUsuário(Pessoa pessoa)
        {
            Pessoas.Add(pessoa);
        }
        public void RemoverUsuário(string cpf)
        {
            var pessoaDeletar = Pessoas.FirstOrDefault(pessoaDelete => pessoaDelete.Cpf == cpf);
            Pessoas.Remove(pessoaDeletar);
        }
        public List<Pessoa> BuscarTodosUsuarios()
        {
            return Pessoas;
        }
        public Pessoa BuscarPorCpf(string cpf)
        {
            var pessoaBuscar = Pessoas.FirstOrDefault(pessoaBusca => pessoaBusca.Cpf.Equals(cpf));
            return pessoaBuscar;
        }
        public List<Pessoa> BuscarNome(string nome)
        {
            var pessoaBuscar = Pessoas.Where(pessoaBusca => pessoaBusca.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase)).ToList();
            return pessoaBuscar;
        }

        public List<Pessoa> calcularImc(double peso, double altura)
        {
            var pessoasIMC = Pessoas.Where(p => { double imc = (p.Peso / p.Altura); return imc >= 18 && imc <= 24; }).ToList();
            return pessoasIMC;
        }
    }
}
