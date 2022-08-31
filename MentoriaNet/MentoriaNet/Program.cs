
using MentoriaNet;

public class Program
{
    public static void Main(string[] args)
    {

        var cafeteria = new Cafeteria();
        var hario = new HarioV60();
        cafeteria.FazerCafe(hario, new Grao());

        var chemex = new Chemex();
        cafeteria.FazerCafe(chemex, new Grao());

        var lugarPraIr = new LugarPraIr();
        var lugar = lugarPraIr.Escolher(1);

        var cafe = lugar.FazerCafe();
    }
}

public class LugarPraIr
{
    public ILugar Escolher(int i)
    {
        if (i == 0)
        {
            return new Padaria();
        }
        else if(i==1)
        {
            return new Cafeteria();
        }
        else
        {
            return new Bistro();
        }
    }
}
public class Qq
{
    public void Metodo()
    {
        var maquinaDeCafe = new MaquinaDeCafe();
        var maquinaDeCafe2 = new MaquinaDeCafe();

        maquinaDeCafe.AdicionarAgua(400);
        maquinaDeCafe2.AdicionarAgua(600);

        maquinaDeCafe = maquinaDeCafe2;

        maquinaDeCafe.AdicionarGrao(new Grao());
        Cafe cafe = maquinaDeCafe.FazerCafe();

        Console.WriteLine(cafe);
    }
}
