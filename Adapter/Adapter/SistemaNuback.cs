namespace Adapter
{
    public class SistemaNuback
    {
        public void  CalcularValorHora(List<Pessoa> pessoas)
        {       
            List<decimal> valorHoraFuncionarios = new List<decimal>();
            foreach (var pessoa in pessoas)
            {
                decimal valorHora = pessoa.Salario / 30 / 8;
                valorHoraFuncionarios.Add(valorHora);
            }
            foreach (var hora in valorHoraFuncionarios)
            {
                Console.WriteLine(hora);
            }
        }
    }
}
