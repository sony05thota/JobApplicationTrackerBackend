using Microsoft.AspNetCore.Mvc;
using JobApplicationTracker.Models;
using JobApplicationTracker.Repositories;
using static System.Net.Mime.MediaTypeNames;

namespace JobApplicationTracker.Controllers
{
    [ApiController]
    [Route("api/applications")]
    public class JobApplicationController : ControllerBase
    {
        private readonly IJobApplicationRepository _repository;

        public JobApplicationController(IJobApplicationRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<JobApplication>>> GetJobApplications()
        {
            var applications = await _repository.GetAllJobApplicationssAsync();
            return Ok(applications);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetApplicationsById(int id)
        {
            var app = await _repository.GetJobApplicationByJobIdAsync(id);
            if (app == null) return NotFound();
            return Ok(app);
        }

        [HttpPost]
        public async Task<IActionResult> Create(JobApplication application)
        {
            if (application == null)
            {
                return BadRequest();
            }
            await _repository.AddJobApplication(application);

            return CreatedAtAction(nameof(GetJobApplications), new { jobId = application.JobId }, application);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] JobApplication application)
        {
            if (id != application.JobId)
                return BadRequest("Job ID mismatch");
            var existingJob = await _repository.GetJobApplicationByJobIdAsync(id);
            if (existingJob == null)
                return NotFound($"No job application found with ID {id}");
            await _repository.UpdateJobApplication(application);
            return NoContent();
        }
    }
}
