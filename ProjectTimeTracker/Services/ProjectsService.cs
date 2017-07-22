using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjectTimeTracker.Models;

namespace ProjectTimeTracker.Services
{
    public interface IProjectsService
    {
        List<Project> Projects { get; }
        void AddProject(string name);
        void LoadProjects();
        void SaveProjects();
        void AddProjectEntry(Project project, ProjectEntry projectEntry);
    }

    public class ProjectsService : IProjectsService
    {
        private readonly IProjectsPersistenceService _persistenceService;
        public List<Project> Projects { get; private set; }

        public ProjectsService(IProjectsPersistenceService persistenceService)
        {
            _persistenceService = persistenceService;
        }

        public void LoadProjects()
        {
            Projects = _persistenceService
                .Load()
                .OrderByDescending(p=>p.LastUsed)
                .ToList();
        }
        
        public void AddProject(string name)
        {
            Projects.Add(new Project(name));
            SaveProjects();
        }

        public void AddProjectEntry(Project project, ProjectEntry projectEntry)
        {
            project.Entries.Add(projectEntry);
            SaveProjects();
        }

        public void SaveProjects()
        {
            _persistenceService.Save(Projects);
        }
    }
}
