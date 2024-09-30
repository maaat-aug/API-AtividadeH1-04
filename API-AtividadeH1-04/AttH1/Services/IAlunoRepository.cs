using AttH1.Classes;

namespace AttH1.Services
{
    public interface IAlunoRepository
    {
        void CadastrarUsuário(Pessoa pessoa);
        void RemoverUsuário(string cpf);
        List<Pessoa> BuscarTodosUsuarios();
        Pessoa BuscarPorCpf(string cpf);
        List<Pessoa> BuscarNome(string nome);
        List<Pessoa> calcularImc(double peso, double altura);
    }
}
