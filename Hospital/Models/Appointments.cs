namespace Hospital.Models
{
     public class Appointments
    {
         public string PatientName { get; set; }
         public DateOnly Date { get; set; }
         public TimeOnly Time { get; set; }
         public string DoctorName { get; set; }
    }
}
