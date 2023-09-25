//Sempre que formos utilizar bibliotecas ou classes já criadas importamos ela com using
using Sesi.Model;

class Program
{
    public static void Main()
    {
        //Criando uma variavel aluno1 e instanciando da classe aluno
        //Ou seja, estamos criando nosso objeto
        var aluno1 = new Aluno();
        //Atribuindo um valor ao atributo nome do aluno1
        aluno1.nome = "Maria Fernanda";
        aluno1.idade = 16;
        aluno1.turma = "2º E.M";
        //Chamando o método da classe Aluno
        aluno1.Apresentar();
        aluno1.ResumirFaltas();
        aluno1.AdicionarFaltas(10);
        aluno1.JustificarFaltas(2);
        aluno1.ResumirFaltas();
        aluno1.AdicionarFaltas(7);
        aluno1.ResumirFaltas();

        var aluno2 = new Aluno();
        aluno2.nome = "Gustavo Farias";
        aluno2.idade = 16;
        aluno2.turma = "2º E.M";
        aluno2.Apresentar();
    }
}