﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

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
        void DeleteProject(long currentProjectId);
        void DeleteProjectEntries(Project project, string[] entries);
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
                .OrderByDescending(p => p.LastUsed)
                .ToList();
        }

        public void AddProject(string name)
        {
            Projects.Add(new Project(name));
            Projects.Sort((x, y) => y.LastUsed.CompareTo(x.LastUsed));
            SaveProjects();
        }

        public void AddProjectEntry(Project project, ProjectEntry projectEntry)
        {
            project.UpdateUsage();
            project.Entries.Add(projectEntry);
            SaveProjects();
        }

        public void DeleteProject(long projectId)
        {
            Projects.Remove(Projects.First(p => p.Id == projectId));
            SaveProjects();
        }

        public void DeleteProjectEntries(Project project, string[] ids)
        {
            project.Entries.RemoveAll(e => ids.Contains(e.Id));
            SaveProjects();
        }

        public void SaveProjects()
        {
            _persistenceService.Save(Projects.ToArray());
        }

    }
}
