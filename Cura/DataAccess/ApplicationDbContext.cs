using Cura.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Cura.ViewModel;

namespace Cura.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Clinic> Clinics { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<MedicalRecord> MedicalRecords { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<ApplicationUserOTP> ApplicationUserOTPs { get; set; }

        //override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=.;initial catalog = Ecommerce520 ;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        //}
        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
           // modelBuilder.Entity<ProductSubImage>().HasKey(p=>new { p.ProductId , p.Img}); 
            //modelBuilder.Entity<ProductColor>().HasKey(p=>new { p.ProductId , p.Color}); 
            //modelBuilder.Entity<Brand>().Property(b=>b.Img).HasDefaultValue("defaultImg.png"); 
        }
        public DbSet<Cura.ViewModel.ValidateOTPVM> ValidateOTPVM { get; set; } = default!;
    }
}
