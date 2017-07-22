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
        List<Project> Load();
        void Save(List<Project> projects);
    }

    public class ProjectsPersistenceService : IProjectsPersistenceService
    {
        private const string FileName = ".project-time-tracker.json";

        private string _filePath;
        private string FilePath => _filePath ?? (_filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), FileName));

        public List<Project> Load()
        {
            List<Project> result;

            if (!File.Exists(FilePath))
            {
                Save(result = new List<Project>());
            }
            else { result = JsonConvert.DeserializeObject<List<Project>>(File.ReadAllText(FilePath)); }

            return result;
        }

        public void Save(List<Project> projects)
        {
            var content = JsonConvert.SerializeObject(projects, Formatting.Indented);
            File.WriteAllText(FilePath, content, Encoding.UTF8);
        }
    }
}
