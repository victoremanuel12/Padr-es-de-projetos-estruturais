
namespace Adapter
{
    public class NubackAdapter : ICalculaValorHora
    {
        private SistemaNuback sistemaNuback = new SistemaNuback();
        public void ProcessaCalculoValorHora(string[,] pessoasString)
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();

            ConvertArrayStingParaPessoa(pessoasString,listaPessoas);
            sistemaNuback.CalcularValorHora(listaPessoas);
        }

        private void ConvertArrayStingParaPessoa(string[,] pessoasString, List<Pessoa> listaPessoas)
        {
            for (int i = 0; i < pessoasString.GetLength(0); i++) 
            {
                long id = long.Parse(pessoasString[i, 0]);
                string nome = pessoasString[i, 1];
                decimal salario = decimal.Parse(pessoasString[i, 2]);
                Pessoa pessoa = new Pessoa(id, nome, salario);
                Console.WriteLine(pessoa);
                listaPessoas.Add(pessoa);
            }
        }
    }
}
