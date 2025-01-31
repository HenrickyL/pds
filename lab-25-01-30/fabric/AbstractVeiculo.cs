namespace fabric;
public abstract class AbstractVeiculo : IVeiculo
{
    protected int _numRodas;

    public AbstractVeiculo(int numRodas) { 
        this._numRodas = numRodas;
    }
    public int NumRodas()
    {
        return _numRodas;
    }
}
