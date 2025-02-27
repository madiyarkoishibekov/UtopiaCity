﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UtopiaCity.Models.Airport;
using UtopiaCity.Models.Business;
using UtopiaCity.Models.Airport.TransportManagerSystem;
using UtopiaCity.Models.Emergency;
using UtopiaCity.Models.Life;
using UtopiaCity.Models.CityAdministration;
using UtopiaCity.Models.PublicCatering;
using UtopiaCity.Models.Sport;
using UtopiaCity.Models.TimelineModel;
using UtopiaCity.Models.CitizenAccount;

namespace UtopiaCity.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SportEvent>()
                .HasOne(s => s.SportComplex)
                .WithMany(e => e.SportEvents)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<EmergencyCertificate> EmergencyCertificate { get; set; }
        public DbSet<EmergencyReport> EmergencyReport { get; set; }
        public DbSet<SportComplex> SportComplex { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<WeatherReport> WeatherReports { get; set; }
        public DbSet<ForPassenger> ForPassengers { get; set; }
        public DbSet<ForCompany> ForCompanies { get; set; }
        public DbSet<TransportManager> TransportManagers { get; set; }
        public DbSet<PermitedModel> PermitedModel { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Airline> Airlines { get; set; }
        public DbSet<ResidentAccount> ResidentAccount { get; set; }
        public DbSet<TimelineModel> TimelineModel { get; set; }
        public DbSet<ScheduleModel> ScheduleModel { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantType> RestaurantTypes { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<CompanyStatus> CompanyStatuses { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Vacancy> Vacancies { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<SportEvent> SportEvents { get; set; }
        public DbSet<AppUser> AppUser { get; set; }
        public DbSet<CitizensTask> CitizensTasks { get; set; }
        public DbSet<Marriage> Marriage { get; set; }
    }
}
