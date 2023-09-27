using System;

public class Produto
{
    public string Descricao { get; set; }
    public double Preco { get; set; }
}

public class Burger : Produto
{
    public int Gramas { get; set; }
}

public class Sobremesa : Produto
{
    public string Tamanho { get; set; }
}

public class Bebida : Produto
{
    public int ML { get; set; }
}

public class Combo
{
    private Burger burger;
    private Sobremesa sobremesa;
    private Bebida bebida;

    public Combo()
    {
        burger = new Burger();
        sobremesa = new Sobremesa();
        bebida = new Bebida();
    }

    public void CriarCombo(int tipo)
    {
        switch (tipo)
        {
            case 1:
                burger.Descricao = "Combo Master - Burger";
                burger.Preco = 10.0;
                burger.Gramas = 200;
                sobremesa.Descricao = "Combo Master - Sobremesa";
                sobremesa.Preco = 5.0;
                sobremesa.Tamanho = "Grande";
                bebida.Descricao = "Combo Master - Bebida";
                bebida.Preco = 3.0;
                bebida.ML = 500;
                break;
            case 2:
                burger.Descricao = "Super Combo - Burger";
                burger.Preco = 8.0;
                burger.Gramas = 150;
                sobremesa.Descricao = "Super Combo - Sobremesa";
                sobremesa.Preco = 4.0;
                sobremesa.Tamanho = "Média";
                bebida.Descricao = "Super Combo - Bebida";
                bebida.Preco = 2.0;
                bebida.ML = 350;
                break;
            default:
                throw new ArgumentException("Tipo de combo inválido");
        }
    }

    public override string ToString()
    {
        return $"Combo:\n{burger.Descricao} - {burger.Gramas}g - R$ {burger.Preco}\n{sobremesa.Descricao} - {sobremesa.Tamanho} - R$ {sobremesa.Preco}\n{bebida.Descricao} - {bebida.ML}ml - R$ {bebida.Preco}\nTotal: R$ {burger.Preco + sobremesa.Preco + bebida.Preco}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Selecione seu combo");
        Console.WriteLine("1. Combo Master");
        Console.WriteLine("2. Super Combo");
        Console.Write("Sua escolha: ");

        int tipo = int.Parse(Console.ReadLine());
        Combo combo = new Combo();
        combo.CriarCombo(tipo);
        Console.WriteLine(combo);
    }
}

