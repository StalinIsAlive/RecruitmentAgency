using RecruitmentAgency.Data.interfaces;
using RecruitmentAgency.Data.Models;

namespace RecruitmentAgency.Data.mocks
{
    public class MockVacancies : IAllVacanies
    {
        public IEnumerable<Vacancy> getVacanies {
            get {
                return new List<Vacancy> {
                    new Vacancy() { name = "Java разработчик", description = "Хороший дружный коллектив. Есть куллер." },
                    new Vacancy() { name = "C# разработчик", description = "Плохой коллектив. Нет куллера." },
                    new Vacancy() { name = "Prolog разработчик", description = "Нет коллектива. Есть куллер." }
                };
            }
        }

        public IEnumerable<Vacancy> getFavoriteVacancies => throw new NotImplementedException();
    }
}
