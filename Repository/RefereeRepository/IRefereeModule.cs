using Domain;

namespace Repository
{
    public interface IRefereeModule
    {
        void addToFavouriteTeam(Referee referee);
        Referee GetRefereeById(int referee);
    }
}