using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryInternDal : IInternDal
    {
        private readonly List<Intern> _interns;

        public InMemoryInternDal()
        {
            _interns = new List<Intern>
            {
                new Intern
                {
                    Id = 1,
                    MentorId = 1,
                    FirstName = "Christian",
                    LastName = "Bale",
                    Phone = 5999999999,
                    Address = "Sesame Street",
                    EmailAddress = "abc@cs.com",
                    StartDate = new DateTime(2007, 5, 25),
                    EndDate = new DateTime(2007, 6, 25),
                    WorkSituation = "Remote", Wage = 2500
                }
            };
        }

        public List<Intern> GetAll(Expression<Func<Intern, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Intern Get(Expression<Func<Intern, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Add(Intern intern)
        {
            _interns.Add(intern);
        }

        public void Update(Intern intern)
        {
            var internToDelete = _interns.SingleOrDefault(i => i.Id == intern.Id);
            _interns.Remove(internToDelete);
        }

        public void Delete(Intern intern)
        {
            var internToUpdate = _interns.SingleOrDefault(i => i.Id == intern.Id);
            internToUpdate.FirstName = intern.FirstName;
            internToUpdate.LastName = intern.LastName;
            internToUpdate.Address = intern.Address;
            internToUpdate.Phone = intern.Phone;
            internToUpdate.EmailAddress = intern.EmailAddress;
            internToUpdate.Wage = intern.Wage;
            internToUpdate.MentorId = intern.MentorId;
            internToUpdate.StartDate = intern.StartDate;
            internToUpdate.EndDate = intern.EndDate;
            internToUpdate.WorkSituation = intern.WorkSituation;
        }

        public List<InternDetailDto> GetInternDetails()
        {
            throw new NotImplementedException();
        }

        public List<Intern> GetAll()
        {
            return _interns;
        }

        public List<Intern> GetAllByMentor(int mentorId)
        {
            return _interns.Where(i => i.MentorId == mentorId).ToList();
        }
    }
}