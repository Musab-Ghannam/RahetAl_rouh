using DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DAL.Data;

public partial class AppDbContext : IdentityDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }
    public  DbSet<Appointment> Appointments { get; set; }
    public  DbSet<Doctor> Doctors { get; set; }
    public DbSet<Feedback> Feedbacks { get; set; }
    public DbSet<Feedbackwebsite> Feedbackwebsites { get; set; }
    public DbSet<NotAvailableTime> NotAvailableTimes { get; set; }
    public DbSet<AvailableTime> AvailableTimes { get; set; }
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Specialization> Specializations { get; set; }
    public DbSet<Transactionsdoctor> Transactionsdoctors { get; set; }
    public DbSet<Transactionspatient> Transactionspatients { get; set; }


}