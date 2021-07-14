﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using UtopiaCity.Data;
using UtopiaCity.Models.Emergency;

namespace UtopiaCity.Services.Emergency
{
    /// <summary>
    /// Class to handle basic CRUD operations for <see cref="ClinicReport"/>
    /// </summary>
    public class EmergencyReportService
    {
        private readonly ApplicationDbContext _dbContext;

        public EmergencyReportService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        /// <summary>
        /// Gets <see cref="ClinicReport"/> by Id.
        /// </summary>
        /// <param name="id">Id of report.</param>
        /// <returns>Report if it exists, otherwise null.</returns>
        public async Task<ClinicReport> GetEmergencyReportById(string id)
        {
            return await _dbContext.EmergencyReport.FirstOrDefaultAsync(x => x.Id.Equals(id));
        }

        /// <summary>
        /// Gets list of all reports.
        /// </summary>
        /// <returns>List of all existing reports.</returns>
        public async Task<List<ClinicReport>> GetEmergencyReports()
        {
            return await _dbContext.EmergencyReport.ToListAsync();
        }

        /// <summary>
        /// Method to add new reports.
        /// </summary>
        /// <param name="report">Report to add.</param>
        /// <returns>Task to await for.</returns>
        public async Task AddEmergencyReport(ClinicReport report)
        {
            _dbContext.Add(report);
            await _dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Method to update existing report.
        /// </summary>
        /// <param name="report">Report to update.</param>
        /// <returns>Task to await for.</returns>
        public async Task UpdateEmergencyReport(ClinicReport report)
        {
            _dbContext.Update(report);
            await _dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Method to delete existing reports.
        /// </summary>
        /// <param name="report">Report to delete</param>
        /// <returns>Task to await for.</returns>
        public async Task DeleteEmergencyReport(ClinicReport report)
        {
            _dbContext.Remove(report);
            await _dbContext.SaveChangesAsync();
        }
    }
}
