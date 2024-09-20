namespace ChungnbAbstractClass.Abstraction;

internal abstract class AbstractSolutions: ISolution 
{
    public virtual void Run()
    {
        Console.WriteLine("Hãy override lại method 'Run' của abstract AbstractSolutions");
    }
}