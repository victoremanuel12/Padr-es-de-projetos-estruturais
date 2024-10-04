namespace Adapter
{
    public class SistemaItau
    {
        public static String[,] PessoasArrayString() 
        {
            string[,] alunos = new string[2,3];
            alunos[0,0] = "1";
            alunos[0, 1] = "Victor";
            alunos[0, 2] = "7000";
            alunos[1, 0] = "2";
            alunos[1, 1] = "Gerson";
            alunos[1, 2]= "300";
            return alunos;
        }
    }
}
