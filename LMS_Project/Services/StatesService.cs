using AutoMapper;
using LMS_Project.Data;
using LMS_Project.DTO;
using LMS_Project.Models;
using LMS_Project.Repository;
using Microsoft.EntityFrameworkCore;

namespace LMS_Project.Services
{
    public class StatesService : IStatesService
    {
        ApplicationDbContext db;
        IMapper mapper;
        public StatesService(ApplicationDbContext db, IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        public void AddState(StatesDto state)
        {
            var data = mapper.Map<States>(state);
            db.States.Add(data);
            db.SaveChanges();
        }
        public List<GetStatesDTO> FetchAllStates()
        {
            var data = db.States.Where(x=>x.IsDeleted==false).Include(x=>x.Countries).ToList();
            return mapper.Map<List<GetStatesDTO>>(data);
        }
        public void UpdateState(StatesDto state)
        {
            var data = mapper.Map<States>(state);
            db.States.Update(data);
            db.SaveChanges();
        }
        public void DeleteState(int StateId)
        {
            var state = db.States.Find(StateId);
            if (state != null)
            {
                state.IsDeleted = true;
                db.SaveChanges();
            }
        }
    }
}
