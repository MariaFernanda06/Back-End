//classe pai que será herdada pelo filho - superclasse
class Animal
{
    public string cor { get; set; }

    public virtual void EmitirSom()
    {
        Console.WriteLine("Animal emitindo som");
    }
}

//classe filha que herdará da classe animal
//receberá todos os atributos e metodos da superclasse
class Cachorro : Animal
{
    public string tipoPelo { get; set; }
    public void Latir()
    {
        Console.WriteLine($"O cachorro {cor} está latindo");
    }
}


class Gato : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("O gato está miando");
    }
}

class Program
{
    static void Main()
    {
        var animalGenerico = new Animal();
        animalGenerico.EmitirSom();

        Cachorro meuCachorro = new Cachorro();
        meuCachorro.cor = "Caramelo";
        meuCachorro.EmitirSom();
        meuCachorro.Latir();

        Gato meuGato = new Gato();
        meuGato.EmitirSom();
    }
}

