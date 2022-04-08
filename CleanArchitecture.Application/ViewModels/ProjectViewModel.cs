using System.Collections.Generic;
using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Application.ViewModels
{
    public class ProjectViewModel
    {
       public IEnumerable<Project> Projects { get; set; }
    }
}
