using System;
using System.Collections.Generic;

namespace PortfolioWebApp
{
    public static class ProjectStorage
    {
        public static List<Project> Projects { get; private set; } = new List<Project>()
        {
            new Project
            {
                Name = "BullsAndCowsWindowsFormsApp",
                Link = "https://github.com/Roksikod/BullsAndCowsWindowsFormsApp",
                Description = "Windows Forms App was used to create this game",
            }
        };

        public static void Add(Project project)
        {
            Projects.Add(project);
        }

        public static void RemoveByName(string name)
        {
            Projects.RemoveAll(x => x.Name == name);
        }
    }
}
