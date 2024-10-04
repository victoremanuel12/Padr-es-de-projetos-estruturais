namespace Adapter
{
    public class Pessoa
    {
        public long Id { get; set; }
        public string Nome {  get; set; }
        public decimal Salario { get; set; }

        public Pessoa(long id, string nome, decimal salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

    }

}
