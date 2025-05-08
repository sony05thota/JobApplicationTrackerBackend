using JobApplicationTracker.Models;
using JobApplicationTracker.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JobApplicationTracker.Repositories
{
    public class JobApplicationRepository : IJobApplicationRepository
    {
        private readonly ApplicationDBContext _context;

        public JobApplicationRepository(ApplicationDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<JobApplication>> GetAllJobApplicationssAsync()
        {
            return await _context.JobApplications.ToListAsync();
        }

        public async Task<JobApplication> GetJobApplicationByJobIdAsync(int jobId)
        {
            return await _context.JobApplications.FirstOrDefaultAsync(j => j.JobId == jobId);
        }

        public async Task AddJobApplication(JobApplication jobApplication)
        {
            await _context.JobApplications.AddAsync(jobApplication);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateJobApplication(JobApplication jobApplication)
        {
            _context.JobApplications.Update(jobApplication);
            await _context.SaveChangesAsync();
        }
    }
}
