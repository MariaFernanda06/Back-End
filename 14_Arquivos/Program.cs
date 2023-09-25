using System.IO;

public class Program
{

    public static string CaminhoArquivo = "Arquivo/arquivo.txt";

    public static void Main()
    {
        GravarArquivo();
        LerArquivo();
    }

    public static void LerArquivo()
    {
        try
        {

            //Verificar se o arquivo existe
            if (File.Exists(CaminhoArquivo) == false)
            {
                //Criando meu arquivo.txt, este comando é executado quando a verificação do if é falsa, ou seja o arquivo não existe
                File.Create(CaminhoArquivo);
            }

                //Instanciando um objeto da classe StreamReader para ler o arquivo
                using (StreamReader arquivo = new StreamReader(CaminhoArquivo))
                {
                    string linha;
                    //Fazendo o while para ler linha por linha que contem no arquivo
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        //Escrevendo no console o conteudo da linha
                        Console.WriteLine(linha);
                    }
                }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro ao gravar o arquivo: {erro.Message}");
        }
    }

    public static void GravarArquivo()
    {
        try
        {
            //Instanciando um objeto da classe StreamWriter para gravar em arquivo
            //se colocar false é substituido as palavras escritas
            using (StreamWriter arquivo = new StreamWriter(CaminhoArquivo, true))
            {
                Console.WriteLine("Digite algo para gravar no arquivo:");
                arquivo.WriteLine(Console.ReadLine());
                Console.WriteLine("Você digitou:");
            }
        }
        catch (Exception erro)
        {
            Console.WriteLine($"Ocorreu um erro ao gravar o arquivo: {erro.Message}");
        }
    }
}