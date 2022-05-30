using ProjectManagementSystem.Models;
using ProjectManagementSystem.Repository.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectManagementSystem.Repository
{
    public class GradingRepository : BaseRepository<Grading>, IGradingRepository
    {
        public GradingRepository(PmsDbContext dbContext) : base(dbContext)
        {

        }


        public Grading GetFeedback(Guid gradeId)
        {
            var oneGrade = dbContext.Gradings.Where(p => p.Id == gradeId).SingleOrDefault();
            return oneGrade;
        }

        Grading IGradingRepository.getFeedbackById(Guid gradingId)
        {
            throw new NotImplementedException();
        }

        Grading IGradingRepository.getGradeByProjectID(Guid projectId)
        {
            throw new NotImplementedException();
        }
    }
}
