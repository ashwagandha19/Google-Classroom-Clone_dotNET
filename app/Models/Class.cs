using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectManagementSystem.Models
{
    public class Class
    {
        public Guid Id { get; set; }
        public string Subject_Title { get; set; }
        public string Description { get; set; }
        public Teacher Teacher { get; set; }
        public ICollection<Project> Projects { get; set; }
        public int PassGrade { get; set; }
        public int Difficulty { get; set; }
        public string LevelRequirement { get; set; }

        public Class() { }

        public Class(Guid Id, string SubjectTitle, string Description)
        {
            this.Id = Id;
            Subject_Title = SubjectTitle;
            this.Description = Description;
        }

        public Class(Guid Id, string subjectTitle, string description, int passGrade, int difficulty, string levelRequirement)
        {
            this.Id = Id;
            Subject_Title = subjectTitle;
            Description = description;
            PassGrade = passGrade;
            Difficulty = difficulty;
            LevelRequirement = levelRequirement;
        }

        public string ComputeOverallDifficulty()
        {
            switch (LevelRequirement)
            {
                case "Beginner":
                    {
                        switch (Difficulty)
                        {
                            case 1:
                                return "Very Easy";
                            case 2:
                                return "Easy";
                            case 3:
                                return "Medium";
                        }
                        break;
                    }
                case "Intermediate":
                    {
                        switch (Difficulty)
                        {
                            case 1:
                                return "Easy";
                            case 2:
                                return "Medium";
                            case 3:
                                return "Hard";
                        }
                        break;
                    }
                case "Advanced":
                    {
                        switch (Difficulty)
                        {
                            case 1:
                                return "Medium";
                            case 2:
                                return "Hard";
                            case 3:
                                return "Very Hard";
                        }
                        break;
                    }

            }
            return "Not Ranked";
        }

        public int ComputeImplicationRate()
        {
            return (PassGrade + Difficulty) / 2;
        }

        public void ChangeRequirement(int passGrade, string levelRequirement)
        {
            PassGrade = passGrade;
            LevelRequirement = levelRequirement;
        }

    }
}

