using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using Newtonsoft.Json;

using ProjectTimeTracker.Models;

namespace ProjectTimeTracker.Services
{
    public interface IProjectsPersistenceService
    {
        Project[] Load();
        void Save(Project[] projects);
    }

    public class ProjectsPersistenceService : IProjectsPersistenceService
    {
#if DEBUG
        private const string FileName = ".project-time-tracker-debug.json";
#else
        private const string FileName = ".project-time-tracker.json";
#endif
        private string _filePath;
        private string FilePath => _filePath ?? (_filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), FileName));

        public Project[] Load()
        {
            Project[] result;

            if (!File.Exists(FilePath))
            {
                Save(result = new Project[0]);
            }
            else { result = JsonConvert.DeserializeObject<Project[]>(File.ReadAllText(FilePath)); }

            return result;
        }

        public void Save(Project[] projects)
        {
            var content = JsonConvert.SerializeObject(projects, Formatting.Indented);
            File.WriteAllText(FilePath, content, Encoding.UTF8);
        }
    }
}
