using ContactDoctor.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Controllers
{
    public class DoctorsController : Controller
    {
       

        //all doctors
        public IActionResult BookAppointment()=> View(new SampleDataDoctor().GetAllDoctors());
       

        public IActionResult CompleteAppointment(string Name) { 

        return View(new SampleDataDoctor().GetOneDoctor(Name));
        }

        
    }
}
