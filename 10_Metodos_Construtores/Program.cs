using Models;

public class Program
{
    public static void Main()
    {
        //Criando um objeto da classe Pessoa
        //Instanciando sem um método construtor 
        /*Pessoa pessoa1 = new Pessoa();
        pessoa1.nome = "Maria Fernanda";
        pessoa1.idade = 16;
        pessoa1.Cantar();

        //Alternativa para criação de um objeto sem construtor
        Pessoa pessoa2 = new Pessoa{
            nome = "Gustavo",
            idade = 16
        };
        pessoa2.Cantar();*/

        Pessoa pessoa1 = new Pessoa("Mafer", 17, "mariamessias.fernanda@gmail.com");
        pessoa1.Cantar();
        pessoa1.Informacoes();

        Pessoa pessoa2 = new Pessoa("Gusta", 16, "farias.k1ng@gmail.com");
        pessoa2.Cantar();
        pessoa2.Informacoes();

        Pessoa pessoa3 = new Pessoa("Duda", 15, "mariaeduarda.adono@gmail.com");
        pessoa3.Cantar();
        pessoa3.Informacoes();
    }
}