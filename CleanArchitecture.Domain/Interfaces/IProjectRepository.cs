using System.Collections.Generic;
using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Domain.Interfaces
{
    public interface IProjectRepository
    {
        IEnumerable<Project> GetProjects();
    }
}