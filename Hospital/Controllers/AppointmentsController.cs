using Hospital.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Controllers
{
    public class AppointmentsController : Controller
    {

        public IActionResult Index()
        {

            return View(AppointmentsData.Appointments_List.ToList());

        }

        public IActionResult SaveAppointments(String DoctorName,string PatientName,DateOnly Date,TimeOnly Time)
        {

             Appointments appointment=  new Appointments() { DoctorName=DoctorName, PatientName=PatientName, Date=Date, Time=Time };
            AppointmentsData.Appointments_List.Add(appointment);

            return View(appointment);
            //return View("Index", AppointmentsData.Appointments_List.ToList());
        }
    }
}
