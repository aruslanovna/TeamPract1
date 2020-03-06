namespace Repository
{
    public interface IPlayerProcessorFactory
    {
        
        void DeleteFromField(int Id);
        void ProduceOnField(int Id);
        void GiveYellowCard(int Id);
        void GiveRedCard(int Id);

    }
}