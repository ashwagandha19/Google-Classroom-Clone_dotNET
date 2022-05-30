using ProjectManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectManagementSystem.Repository.Abstractions
{
    public interface IGradingRepository : IRepository<Grading>
    {
        Grading getGradeByProjectID(Guid projectId);

        Grading getFeedbackById(Guid gradingId);

    }
}
