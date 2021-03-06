﻿using ITI.Enterprise.InterviewTask.DataModel;
using ITI.Enterprise.InterviewTask.DomainClasses;
using ITI.Enterprise.InterviewTask.Repositories.Repositories;

namespace ITI.Enterprise.InterviewTask.Repositories.Services
{
    public class CompanyRepository : Repository<Company, AppDbContext>, ICompanyRepository
    {
        public CompanyRepository(AppDbContext context) : base(context)
        {
        }

        //public async Task<IEnumerable<Company>> GetAllAsync()
        //{
        //    return await Set.ToListAsync();
        //}
    }
}
