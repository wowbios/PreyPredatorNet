namespace PreyPredator
{
    public interface IEntity
    {
        void Tick();

        float X { get; }

        float Y { get; }
    }
}