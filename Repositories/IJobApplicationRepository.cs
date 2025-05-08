using JobApplicationTracker.Models;

namespace JobApplicationTracker.Repositories
{
    public interface IJobApplicationRepository
    {
        Task<IEnumerable<JobApplication>> GetAllJobApplicationssAsync();
        Task<JobApplication> GetJobApplicationByJobIdAsync(int jobId);
        Task AddJobApplication (JobApplication jobApplication);
        Task UpdateJobApplication (JobApplication jobApplication);
    }
}
