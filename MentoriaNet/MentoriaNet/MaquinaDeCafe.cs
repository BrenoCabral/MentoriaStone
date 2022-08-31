internal class MaquinaDeCafe
{
    const int CAPACIDADE_DE_AGUA = 2000;
    public MaquinaDeCafe()
    {
    }

    public bool Ligada { get; private set; }
    public bool EstaLimpa { 
        get 
        {
            return BorraDeCafe == null;
        } 
    }
    public Grao Grao { get; private set; }
    public int Agua { get; private set; }
    public Po PodoCafe { get; internal set; }
    public BorraDeCafe BorraDeCafe { get; }

    public void Ligar()
    {
        Ligada = true;
    }
    public void Desligar()
    {
        Ligada = false;
    }
    public void AdicionarGrao(Grao grao)
    {
        Grao = grao;
    }

    public void AdicionarAgua(int mlsDeAgua)
    {   
        Agua += mlsDeAgua;
        Agua = Agua > CAPACIDADE_DE_AGUA ? CAPACIDADE_DE_AGUA : Agua;
    }

    internal Cafe FazerCafe()
    {
        if (Agua < 300 || Grao == null) return null;

        MoeGrao();
        return new Cafe();
    }

    private void MoeGrao()
    {
        if (Grao == null) return;

        PodoCafe = new Po();
    }
}