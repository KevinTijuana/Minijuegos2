using System;

public class Enemigo
{
    public string Nombre;
    public int Vida;

    public Enemigo(string nombre, int vida)
    {
        Nombre = nombre;
        Vida = vida;
    }

    public virtual void Atacar()
    {
        Console.WriteLine(Nombre + " ataca con fuerza bruta.");
    }
}

public class EnemigoVolador : Enemigo
{
    public EnemigoVolador(string nombre, int vida) : base(nombre, vida)
    {
    }

    public override void Atacar()
    {
        Console.WriteLine(Nombre + " canta una nota supersónica desde el cielo.");
    }
}

public class EnemigoFelino : Enemigo
{
    public EnemigoFelino(string nombre, int vida) : base(nombre, vida)
    {
    }

    public override void Atacar()
    {
        Console.WriteLine(Nombre + " ataca con velocidad y precisión metálica.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Enemigo shrek = new Enemigo("Shrek", 150);
        EnemigoVolador miku = new EnemigoVolador("Miku Hatsune", 90);
        EnemigoFelino megatron = new EnemigoFelino("Megatron", 200);

        shrek.Atacar();
        miku.Atacar();
        megatron.Atacar();
    }
}
