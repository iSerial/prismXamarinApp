using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using prismXamarinApp.Models;

namespace prismXamarinApp.Services
{
    public interface IJobService
    {
        Task<List<JobModel>> GetJob();
    }
}
