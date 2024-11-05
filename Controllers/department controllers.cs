using Microsoft.AspNetCore.Mvc;

namespace MVCDemo_2.controllers
{
    public class department_controllers : Controller
    {
        public department_controllers (IDepartmentRepository departmentRepository)
        {
            _departnentRepository = departmentRepository;
        }

        public IActionResult index()
        {
            var dept = _departnentRepository.GetAll();
            return View();
        }
    }
}
