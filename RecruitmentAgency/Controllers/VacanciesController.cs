using Microsoft.AspNetCore.Mvc;
using RecruitmentAgency.Data.interfaces;

namespace RecruitmentAgency.Controllers
{
    public class VacanciesController : Controller
    {
        private readonly IAllVacanies _allVacanies;


        public VacanciesController(IAllVacanies allVacanies)
        {
            _allVacanies = allVacanies;
        }

        public ViewResult List() {
            var vacancies = _allVacanies.getVacanies; 
            return View(vacancies);
        }
    }
}
