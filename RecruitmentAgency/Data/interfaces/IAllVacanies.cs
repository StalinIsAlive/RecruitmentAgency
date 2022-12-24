using RecruitmentAgency.Data.Models;

namespace RecruitmentAgency.Data.interfaces
{
    public interface IAllVacanies
    {
        IEnumerable<Vacancy> getVacanies { get; }
        IEnumerable<Vacancy> getFavoriteVacancies { get; }
    }
}
